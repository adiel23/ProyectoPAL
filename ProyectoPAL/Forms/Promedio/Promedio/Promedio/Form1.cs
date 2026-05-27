using System;
using System.Windows.Forms;


namespace Promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double v1) &&
                double.TryParse(textBox2.Text, out double v2) &&
                double.TryParse(textBox3.Text, out double v3))
            {
                double p = (v1 + v2 + v3) / 3.0;
                string msg = p >= 500 ? "Se ha ganado un regalito" : "Lo esperamos pronto";

                textBox4.Text = "Promedio: " + p.ToString("F2") + " - " + msg;

            }
            else
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
