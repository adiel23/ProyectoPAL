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
    public partial class PlanoCartesiano : Form
    {
        Point centro;

        public PlanoCartesiano()
        {
            InitializeComponent();
            centro = new
                Point(pnlPlano.Width / 2,
                pnlPlano.Height / 2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlPlano.Refresh();
            txtX.Clear();
            txtY.Clear();
            lblResultado.Text = "";
        }

        private void lblY_Click(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)

        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            int px = centro.X + x;
            int py = centro.Y - y;

            Graphics g = pnlPlano.CreateGraphics();
            g.FillEllipse(Brushes.Red, px, py, 6, 6);

            if (x > 0 && y > 0)
                lblResultado.Text = "Cuadrante I";
            else if (x < 0 && y > 0)
                lblResultado.Text = "Cuadrante II";
            else if (x < 0 && y < 0)
                lblResultado.Text = "Cuadrante III";
            else if (x > 0 && y < 0)
                lblResultado.Text = "Cuadrante IV";
            else
                lblResultado.Text = "Eje";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form menu =
        Application.OpenForms[0];
            menu.Show();
        }

        private void pnlPlano_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int ancho = pnlPlano.Width;
            int alto = pnlPlano.Height;

            int centroX = ancho / 2;
            int centroY = alto / 2;

            // fondo limpio
            g.Clear(Color.White);

            // líneas de rejilla
            Pen gris = new Pen(Color.LightGray);

            for (int x = 0; x < ancho; x += 20)
                g.DrawLine(gris, x, 0, x, alto);

            for (int y = 0; y < alto; y += 20)
                g.DrawLine(gris, 0, y, ancho, y);

            // ejes principales
            g.DrawLine(Pens.Black, 0, centroY, ancho, centroY);
            g.DrawLine(Pens.Black, centroX, 0, centroX, alto);
        }
    }
}

