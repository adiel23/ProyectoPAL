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

            balanceText.Text = "saldo: " + GlobalData.ATMbalance;
        }

        private void Depositar_Load(object sender, EventArgs e)
        {

        }

        private void depositBtn_Click(object sender, EventArgs e)
        {
            GlobalData.ATMbalance += decimal.Parse(amountTextBox.Text);

            balanceText.Text = "saldo: " + GlobalData.ATMbalance.ToString();

            successMessage.Text = "saldo actualizado con exito";
        }

        private void Depositar_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cajero ATMWindow = new Cajero();

            ATMWindow.Show();

            this.Hide();
        }
    }
}
