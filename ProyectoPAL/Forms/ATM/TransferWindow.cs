using ProyectoPAL.Models;
using ProyectoPAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAL.Forms.ATM
{
    public partial class TransferWindow : Form
    {
        public TransferWindow()
        {
            InitializeComponent();

            balanceText.Text = "saldo: " + GlobalData.balance + " dolares";
        }

        private void TransferWindow_Load(object sender, EventArgs e)
        {
            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label2.Left = (this.ClientSize.Width - label2.Width) / 2;
            usernameTextBox.Left = (this.ClientSize.Width - usernameTextBox.Width) / 2;
            amountTextBox.Left = (this.ClientSize.Width - amountTextBox.Width) / 2;
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void transferBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;

            if (!double.TryParse(amountTextBox.Text, out double amount))
            {
                MessageBox.Show("El monto ingresado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amount <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (username == GlobalData.username)
            {
                MessageBox.Show("No puedes transferirte a ti mismo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (amount > GlobalData.balance)
            {
                MessageBox.Show("No puedes enviar mas dinero del que tienes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                User? user = UserRepository.FindUser(username);

                if (user == null)
                {
                    throw new InvalidOperationException("No se encontro el usuario " + '"' + username + '"');
                }

                using (var connection = new SQLiteConnection(DatabaseHelper.ConnectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            UserRepository.UpdateBalance(GlobalData.id, -amount, connection, transaction);
                            UserRepository.UpdateBalance(user.id, amount, connection, transaction);

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }

                user = UserRepository.FindUserById(GlobalData.id);

                if (user == null)
                {
                    successMessage.Text = "Transaccion exitosa. Error al obtener el nuevo saldo";
                } else
                {
                    GlobalData.balance = user.balance;

                    successMessage.Text = "Transaccion exitosa. Su nuevo saldo es: " + GlobalData.balance + " dolares";
                }

                successMessage.Left = (this.ClientSize.Width - successMessage.Width) / 2;

                balanceText.Text = "saldo: " + GlobalData.balance + " dolares";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al realizar la transferencia: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATMWindow atmWindow = new();

            atmWindow.Show();

            this.Hide();
        }
    }
}
