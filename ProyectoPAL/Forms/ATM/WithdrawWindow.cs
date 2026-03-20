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

            // convertir de text a double

            if (!double.TryParse(amountTextBox.Text, out double amount))
            {
                MessageBox.Show("Ingresa un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validar que no se ingrese un numero negativo

            if (amount <= 0)
            {
                MessageBox.Show("El monto a retirar debe ser mayor a cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que se tenga saldo suficiente
            
            if (amount > GlobalData.balance)
            {
                MessageBox.Show("Fondos insuficientes para realizar este retiro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                successMessage.Text = $"Saldo actualizado. Nuevo balance: {GlobalData.balance}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el saldo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
