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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {
            Registrarse registerForm = new Registrarse();
            registerForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            User? user = UserRepository.FindUser(username);

            if (user == null)
            {
                MessageBox.Show("usuario no encontrado");
            } else
            {
                string password = passwordInput.Text;

                if (password != user.password)
                {
                    MessageBox.Show("clave incorrecta");
                } else
                {
                    GlobalData.id = user.id;
                    GlobalData.username = user.username;
                    GlobalData.balance = user.balance;

                    ATMWindow atmWindow = new ATMWindow();

                    atmWindow.Show();

                    this.Hide();
                }
            }
        }

    }
}
