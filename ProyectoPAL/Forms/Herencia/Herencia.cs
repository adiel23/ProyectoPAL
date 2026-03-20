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
    public partial class Herencia : Form
    {
        public Herencia()
        {
            InitializeComponent();
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            double herenciaTotal;
            if (!double.TryParse(inheritanceTextBox.Text, out herenciaTotal))
            {
                MessageBox.Show("La herencia ingresada no es válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (herenciaTotal <= 0)
            {
                MessageBox.Show("La herencia debe ser mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fórmulas según el enunciado
            double juan = herenciaTotal / 3;
            double luis = (herenciaTotal * 4) / 9;
            double rosa = (herenciaTotal * 2) / 9;

            // Umbral: tercera parte de la herencia total
            double umbral = herenciaTotal / 3;

            // El abogado cobra un % de lo que recibe cada hijo
            // Si el monto es MENOR a la tercera parte → 3%, si no → 5%
            double ComisionAbogado(double monto) =>
                monto < umbral ? monto * 0.03 : monto * 0.05;

            double totalAbogado = ComisionAbogado(juan) + ComisionAbogado(luis) + ComisionAbogado(rosa);

            // Los hijos reciben su monto íntegro; el abogado cobra por separado
            juanLabel.Text = $"Juan recibe: {juan:C}";
            luisLabel.Text = $"Luis recibe: {luis:C}";
            rosaLabel.Text = $"Rosa recibe: {rosa:C}";
            abogadoLabel.Text = $"Abogado recibe: {totalAbogado:C}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new();

            home.Show();

            this.Hide();
        }

        private void abogadoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
