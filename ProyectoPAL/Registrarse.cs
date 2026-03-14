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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = usernameInput.Text;
            string password = passwordInput.Text;

            if (username == "" || password == "")
            {
                errorMessage.Text = "el usuario o la contrasena estan incorrectos";
                usernameInput.Text = "";
                passwordInput.Text = "";
            }
            else
            {
                UserRepository.Insert(username, password);
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Login loginWindow = new Login();

            loginWindow.Show();

            this.Hide();
        }
    }
}
