using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAL.Forms.Ordenamiento
{
    public partial class OrdenamientoForm : Form
    {
        public OrdenamientoForm()
        {
            InitializeComponent();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            // Crear variables para almacenar los números convertidos
            int num1, num2, num3;

            // Validar que los 3 campos tengan números válidos antes de hacer nada
            if (!int.TryParse(textBox1.Text, out num1) || !int.TryParse(textBox2.Text, out num2) || !int.TryParse(textBox3.Text, out num3))
            {
                MessageBox.Show("Por favor, asegúrate de digitar números enteros válidos en los tres campos.",
                                "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método para que no intente procesar datos vacíos o erróneos
            }

            // Crear variables para almacenar los resultados
            int mayor, menor, centro;

            // ENCONTRAR EL MAYOR
            if (num1 >= num2 && num1 >= num3)
            {
                mayor = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                mayor = num2;
            }
            else
            {
                mayor = num3;
            }

            // ENCONTRAR EL MENOR
            if (num1 <= num2 && num1 <= num3)
            {
                menor = num1;
            }
            else if (num2 <= num1 && num2 <= num3)
            {
                menor = num2;
            }
            else
            {
                menor = num3;
            }

            // Encontrar el del centro

            centro = (num1 + num2 + num3) - mayor - menor;

            // Mostrar el resultado
 
            label1.Text = $"Menor: {menor}";
            label2.Text = $"Centro: {centro}";
            label3.Text = $"Mayor: {mayor}";
        }

        private void OrdenamientoForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();

            home.Show();

            this.Hide();
        }
    }
}
