using Microsoft.VisualBasic.Logging;
using ProyectoPAL.Models;
using ProyectoPAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAL.Forms.ATM
{
    public partial class WithdrawWindow : Form
    {
        public WithdrawWindow()
        {
            InitializeComponent();

            balanceText.Text = "saldo: " + GlobalData.balance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATMWindow atmWindow = new();

            atmWindow.Show();

            this.Hide();
        }

        private void withdrawBtn_Click(object sender, EventArgs e)
        {
            int userId = GlobalData.id;

            if (!double.TryParse(amountTextBox.Text, out double amount))
            {
                MessageBox.Show("Ingresa un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("El monto a retirar debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (amount > GlobalData.balance)
            {
                MessageBox.Show("Fondos insuficientes para realizar este retiro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el monto sea entero (el cajero no maneja centavos)
            if (amount != Math.Floor(amount))
            {
                MessageBox.Show("El monto debe ser un número entero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                UserRepository.UpdateBalance(userId, -amount);
                User? user = UserRepository.FindUserById(userId);
                if (user == null)
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                GlobalData.balance = user.balance;
                balanceText.Text = "saldo: " + GlobalData.balance;

                // Calcular billetes
                string billetes = CalcularBilletes((int)amount);
                successMessage.Text = $"Retiro exitoso.\n{billetes}\nNuevo balance: {GlobalData.balance}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el saldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string CalcularBilletes(int monto)
        {
            int[] denominaciones = { 100, 20, 10, 5, 1 };
            var resultado = new StringBuilder();
            resultado.AppendLine("Billetes entregados:");

            foreach (int billete in denominaciones)
            {
                int cantidad = monto / billete;
                if (cantidad > 0)
                {
                    resultado.AppendLine($"  ${billete}: {cantidad} billete(s)");
                    monto -= cantidad * billete;
                }
            }

            return resultado.ToString();
        }
    }
}
