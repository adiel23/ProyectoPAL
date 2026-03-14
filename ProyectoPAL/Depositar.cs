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
            GlobalData.balance += double.Parse(amountTextBox.Text);

            balanceText.Text = "saldo: " + GlobalData.balance.ToString();

            successMessage.Text = "saldo actualizado con exito";
        }

        private void Depositar_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login ATMWindow = new Login();

            ATMWindow.Show();

            this.Hide();
        }
    }
}
