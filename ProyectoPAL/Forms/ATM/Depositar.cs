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

namespace ProyectoPAL
{
    public partial class Depositar : Form
    {
        public Depositar()
        {
            InitializeComponent();

            balanceText.Text = "saldo: " + GlobalData.balance;
        }

        private void Depositar_Load(object sender, EventArgs e)
        {

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            int userId = GlobalData.id;

            if (!double.TryParse(amountTextBox.Text, out double amount))
            {
                MessageBox.Show("Ingresa un monto válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                UserRepository.UpdateBalance(userId, amount);

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

        private void Depositar_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATMWindow atmWindow = new();

            atmWindow.Show();

            this.Hide();
        }
    }
}
