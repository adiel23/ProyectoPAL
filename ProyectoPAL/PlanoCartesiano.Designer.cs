namespace ProyectoPAL
{
    partial class PlanoCartesiano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegresar = new Button();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            pnlPlano = new Panel();
            lblEnunciado = new Label();
            txtX = new TextBox();
            txtY = new TextBox();
            lblX = new Label();
            lblY = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Red;
            btnRegresar.Location = new Point(267, 246);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(90, 35);
            btnRegresar.TabIndex = 0;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Yellow;
            btnLimpiar.Location = new Point(267, 171);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 35);
            btnLimpiar.TabIndex = 1;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += button2_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.FromArgb(0, 192, 0);
            btnCalcular.ForeColor = Color.Black;
            btnCalcular.Location = new Point(267, 98);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(90, 35);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 154);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 191);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // pnlPlano
            // 
            pnlPlano.BackColor = Color.White;
            pnlPlano.BorderStyle = BorderStyle.FixedSingle;
            pnlPlano.Location = new Point(468, 76);
            pnlPlano.Name = "pnlPlano";
            pnlPlano.Size = new Size(300, 230);
            pnlPlano.TabIndex = 5;
            pnlPlano.Paint += pnlPlano_Paint;
            // 
            // lblEnunciado
            // 
            lblEnunciado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnunciado.Location = new Point(27, 23);
            lblEnunciado.Name = "lblEnunciado";
            lblEnunciado.Size = new Size(500, 50);
            lblEnunciado.TabIndex = 6;
            lblEnunciado.Text = "Este programa solicita cordenadas X y Y, las grafica en el plano cartesiano y determina su cuadrante.";
            lblEnunciado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtX
            // 
            txtX.BackColor = Color.FromArgb(255, 224, 192);
            txtX.Location = new Point(78, 98);
            txtX.Name = "txtX";
            txtX.Size = new Size(99, 23);
            txtX.TabIndex = 7;
            // 
            // txtY
            // 
            txtY.BackColor = Color.FromArgb(255, 224, 192);
            txtY.Location = new Point(78, 139);
            txtY.Name = "txtY";
            txtY.Size = new Size(99, 23);
            txtY.TabIndex = 8;
            txtY.TextChanged += txtY_TextChanged;
            // 
            // lblX
            // 
            lblX.AutoSize = true;
            lblX.BackColor = Color.FromArgb(192, 192, 255);
            lblX.Location = new Point(27, 98);
            lblX.Name = "lblX";
            lblX.Size = new Size(17, 15);
            lblX.TabIndex = 9;
            lblX.Text = "X:";
            // 
            // lblY
            // 
            lblY.AutoSize = true;
            lblY.BackColor = Color.FromArgb(192, 192, 255);
            lblY.Location = new Point(27, 139);
            lblY.Name = "lblY";
            lblY.Size = new Size(17, 15);
            lblY.TabIndex = 10;
            lblY.Text = "Y:";
            lblY.Click += lblY_Click;
            // 
            // lblResultado
            // 
            lblResultado.BackColor = Color.FromArgb(255, 192, 255);
            lblResultado.Location = new Point(78, 197);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(100, 23);
            lblResultado.TabIndex = 11;
            lblResultado.TextAlign = ContentAlignment.MiddleCenter;
            lblResultado.Click += lblResultado_Click;
            // 
            // PlanoCartesiano
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(lblY);
            Controls.Add(lblX);
            Controls.Add(txtY);
            Controls.Add(txtX);
            Controls.Add(lblEnunciado);
            Controls.Add(pnlPlano);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegresar);
            Name = "PlanoCartesiano";
            Text = "PlanoCartesiano";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegresar;
        private Button btnLimpiar;
        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Panel pnlPlano;
        private Label lblEnunciado;
        private TextBox txtX;
        private TextBox txtY;
        private Label lblX;
        private Label lblY;
        private Label lblResultado;
    }
}