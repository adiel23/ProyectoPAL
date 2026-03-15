using ProyectoPAL.Forms.ATM;
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
    public partial class ATMWindow : Form
    {
        public ATMWindow()
        {
            InitializeComponent();

            balanceText.Text = "Bienvenido " + GlobalData.username + ". Tu saldo es de " + GlobalData.balance + " dolares";
        }

        private void goBackBtn_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();

            loginWindow.Show();

            this.Hide();
        }

        private void balanceText_Click(object sender, EventArgs e)
        {

        }

        private void openDepositWindowBtn_Click(object sender, EventArgs e)
        {
            Depositar depositWindow = new Depositar();

            depositWindow.Show();

            this.Hide();
        }

        private void openTransferWindowBtn_Click(object sender, EventArgs e)
        {
            TransferWindow transferWindow = new();

            transferWindow.Show();

            this.Hide();
        }
    }
}
