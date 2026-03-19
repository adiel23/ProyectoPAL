namespace ProyectoPAL
{
    partial class Angulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Angulos));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtB = new TextBox();
            txtC = new TextBox();
            txtAngC = new TextBox();
            txtAngB = new TextBox();
            txtH = new TextBox();
            btnCalcular = new Button();
            btnBorrar = new Button();
            btnRegresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(383, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(405, 284);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 23);
            label1.Name = "label1";
            label1.Size = new Size(260, 33);
            label1.TabIndex = 1;
            label1.Text = "Angulos agudos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(255, 192, 255);
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(2, 75);
            label2.Name = "label2";
            label2.Size = new Size(363, 84);
            label2.TabIndex = 2;
            label2.Text = "El programa te ayudara a encontrar la hipotenusa,\r\nel angulo B y C con ayuda de los catetos.\r\nPara ello, rellena los campos con la información\r\nnecesaria.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(30, 192);
            label3.Name = "label3";
            label3.Size = new Size(210, 21);
            label3.TabIndex = 3;
            label3.Text = "Valor del cateto Menor [b].....:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(30, 242);
            label4.Name = "label4";
            label4.Size = new Size(208, 21);
            label4.TabIndex = 4;
            label4.Text = "Valor del cateto Mayor [c].....:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 314);
            label5.Name = "label5";
            label5.Size = new Size(185, 21);
            label5.TabIndex = 5;
            label5.Text = "Valor de la hipotenusa.....:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(413, 250);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 354);
            label7.Name = "label7";
            label7.Size = new Size(167, 21);
            label7.TabIndex = 7;
            label7.Text = "Valor del angulo [B].....:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.Location = new Point(29, 400);
            label8.Name = "label8";
            label8.Size = new Size(168, 21);
            label8.TabIndex = 8;
            label8.Text = "Valor del angulo [C].....:";
            // 
            // txtB
            // 
            txtB.Location = new Point(248, 194);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 9;
            // 
            // txtC
            // 
            txtC.Location = new Point(248, 242);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 10;
            // 
            // txtAngC
            // 
            txtAngC.Location = new Point(248, 398);
            txtAngC.Name = "txtAngC";
            txtAngC.Size = new Size(100, 23);
            txtAngC.TabIndex = 11;
            // 
            // txtAngB
            // 
            txtAngB.Location = new Point(248, 354);
            txtAngB.Name = "txtAngB";
            txtAngB.Size = new Size(100, 23);
            txtAngB.TabIndex = 12;
            // 
            // txtH
            // 
            txtH.Location = new Point(248, 312);
            txtH.Name = "txtH";
            txtH.Size = new Size(100, 23);
            txtH.TabIndex = 13;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lime;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Location = new Point(486, 401);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Red;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Location = new Point(648, 397);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 15;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Yellow;
            btnRegresar.FlatStyle = FlatStyle.Flat;
            btnRegresar.Location = new Point(657, 65);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(75, 23);
            btnRegresar.TabIndex = 16;
            btnRegresar.Text = "Regresar";
            btnRegresar.UseVisualStyleBackColor = false;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // Angulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresar);
            Controls.Add(btnBorrar);
            Controls.Add(btnCalcular);
            Controls.Add(txtH);
            Controls.Add(txtAngB);
            Controls.Add(txtAngC);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Angulos";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtB;
        private TextBox txtC;
        private TextBox txtAngC;
        private TextBox txtAngB;
        private TextBox txtH;
        private Button btnCalcular;
        private Button btnBorrar;
        private Button btnRegresar;
    }
}