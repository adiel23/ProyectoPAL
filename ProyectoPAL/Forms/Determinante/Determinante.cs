using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProyectoPAL
{
    public partial class Determinante : Form
    {
        public Determinante()
        {
            InitializeComponent();
        }

        private void BackBttn_Click(object sender, EventArgs e)
        {
            Form1 principal = new Form1();
            principal.Show();
            this.Hide();
        }

        private void CalcularBttn_Click(object sender, EventArgs e)
        {
            try
            {
                string ecuacion1 = Ec1Box.Text.Replace(" ", "");
                string ecuacion2 = Ec2Box.Text.Replace(" ", "");

                double a, b, r;
                double c, d, s;

                ObtenerCoeficientes(ecuacion1, out a, out b, out r);
                ObtenerCoeficientes(ecuacion2, out c, out d, out s);

                double determinante = (a * d) - (b * c);

                if (determinante == 0)
                {
                    ReBox.Text = "No hay solución única (determinante = 0)";
                    return;
                }

                double determinanteX = (r * d) - (b * s);
                double determinanteY = (a * s) - (r * c);

                double x = determinanteX / determinante;
                double y = determinanteY / determinante;

                ReBox.Text =
                    "Determinante = " + determinante + Environment.NewLine +
                    "X = " + x.ToString("0.00")  + Environment.NewLine +
                    "Y = " + y.ToString("0.00");
            }
            catch (Exception)
            {
                MessageBox.Show("Formato incorrecto. Ejemplo: 2x+3y=20",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            Ec1Box.Clear();
            Ec2Box.Clear();
            ReBox.Clear();

            Ec1Box.Focus();
        }

        private void ObtenerCoeficientes(string ecuacion, out double coefX, out double coefY, out double resultado)
        {
            string[] partes = ecuacion.Split('=');

            if (partes.Length != 2)
                throw new Exception("Ecuación inválida");

            string izquierda = partes[0].Replace("-", "+-");
            string derecha = partes[1];

            resultado = Convert.ToDouble(derecha);

            coefX = 0;
            coefY = 0;

            Match matchX = Regex.Match(izquierda, @"([+-]?\d*)x");
            Match matchY = Regex.Match(izquierda, @"([+-]?\d*)y");

            if (matchX.Success)
                coefX = ConvertirCoeficiente(matchX.Groups[1].Value);

            if (matchY.Success)
                coefY = ConvertirCoeficiente(matchY.Groups[1].Value);
        }

        private double ConvertirCoeficiente(string valor)
        {
            if (valor == "" || valor == "+")
                return 1;

            if (valor == "-")
                return -1;

            return Convert.ToDouble(valor);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
