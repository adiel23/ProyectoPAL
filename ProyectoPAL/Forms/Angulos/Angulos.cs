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
    public partial class Angulos : Form
    {
        public Angulos()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double b, c, h, angB, angC;

            if (!double.TryParse(txtB.Text, out b) || !double.TryParse(txtC.Text, out c))
            {
                MessageBox.Show("Ingrese valores numéricos");
                return;
            }

            h = Math.Sqrt(b * b + c * c);
            txtH.Text = h.ToString("0.00");

            angB = Math.Atan(b / c) * 180 / Math.PI;
            angC = 90 - angB;

            txtAngB.Text = Math.Round(angB).ToString();
            txtAngC.Text = Math.Round(angC).ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtB.Text = "";
            txtC.Text = "";
            txtH.Text = "";
            txtAngB.Text = "";
            txtAngC.Text = "";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1();
            menu.Show();
            this.Hide();
        }
    }
}
