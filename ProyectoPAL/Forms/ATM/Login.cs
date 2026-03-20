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
            Depositar depositWindow = new();

            depositWindow.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new();

            home.Show();

            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registrarse registerForm = new();
            registerForm.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("rellena ambos campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                User? user = UserRepository.FindUser(username);

                if (user == null)
                {
                    MessageBox.Show("Usuario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (password != user.password)
                    {
                        MessageBox.Show("clave incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        GlobalData.id = user.id;
                        GlobalData.username = user.username;
                        GlobalData.balance = user.balance;

                        ATMWindow atmWindow = new();

                        atmWindow.Show();

                        this.Hide();
                    }
                }
            }
        }

    }
}
