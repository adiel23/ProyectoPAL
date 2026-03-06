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
    public partial class Cajero : Form
    {
        public Cajero()
        {
            InitializeComponent();

            balanceMessage.Text = "tu saldo actual es de " + GlobalData.ATMbalance + " dolares";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cajero_Load(object sender, EventArgs e)
        {

        }

        private void openDepositBtn_Click(object sender, EventArgs e)
        {
            Depositar depositWindow = new Depositar();

            depositWindow.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();

            home.Show();

            this.Hide();
        }
    }
}
