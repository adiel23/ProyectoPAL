namespace ProyectoPAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openAngleBtn_Click(object sender, EventArgs e)
        {
            Angulos anglesWindow = new Angulos();

            anglesWindow.Show();

            this.Hide();
        }

        private void openDeterminantBtn_Click(object sender, EventArgs e)
        {
            Determinante determinantWindow = new Determinante();

            determinantWindow.Show();

            this.Hide();
        }

        private void openATMBtn_Click(object sender, EventArgs e)
        {
            Cajero ATMWindow = new Cajero();

            ATMWindow.Show();

            this.Hide();
        }

        private void openInheritenceBtn_Click(object sender, EventArgs e)
        {
            Herencia inheritanceWindow = new Herencia();

            inheritanceWindow.Show();

            this.Hide();
        }
    }
}
