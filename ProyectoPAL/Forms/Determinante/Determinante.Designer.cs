namespace ProyectoPAL
{
    partial class Determinante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Determinante));
            BackBttn = new Button();
            CalcularBttn = new Button();
            DeleteBttn = new Button();
            label1 = new Label();
            label2 = new Label();
            Ec1Box = new TextBox();
            Ec2Box = new TextBox();
            ReBox = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // BackBttn
            // 
            BackBttn.Location = new Point(24, 24);
            BackBttn.Name = "BackBttn";
            BackBttn.Size = new Size(115, 36);
            BackBttn.TabIndex = 0;
            BackBttn.Text = "Regresar";
            BackBttn.UseVisualStyleBackColor = true;
            BackBttn.Click += BackBttn_Click;
            // 
            // CalcularBttn
            // 
            CalcularBttn.Location = new Point(24, 225);
            CalcularBttn.Name = "CalcularBttn";
            CalcularBttn.Size = new Size(115, 36);
            CalcularBttn.TabIndex = 1;
            CalcularBttn.Text = "Calcular";
            CalcularBttn.UseVisualStyleBackColor = true;
            CalcularBttn.Click += CalcularBttn_Click;
            // 
            // DeleteBttn
            // 
            DeleteBttn.Location = new Point(24, 282);
            DeleteBttn.Name = "DeleteBttn";
            DeleteBttn.Size = new Size(115, 36);
            DeleteBttn.TabIndex = 2;
            DeleteBttn.Text = "Limpiar";
            DeleteBttn.UseVisualStyleBackColor = true;
            DeleteBttn.Click += DeleteBttn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 72);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "Ecuacion 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 149);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "Ecuacion 2";
            // 
            // Ec1Box
            // 
            Ec1Box.Location = new Point(24, 106);
            Ec1Box.Name = "Ec1Box";
            Ec1Box.Size = new Size(115, 27);
            Ec1Box.TabIndex = 5;
            // 
            // Ec2Box
            // 
            Ec2Box.Location = new Point(24, 181);
            Ec2Box.Name = "Ec2Box";
            Ec2Box.Size = new Size(115, 27);
            Ec2Box.TabIndex = 6;
            // 
            // ReBox
            // 
            ReBox.Location = new Point(24, 342);
            ReBox.Multiline = true;
            ReBox.Name = "ReBox";
            ReBox.ReadOnly = true;
            ReBox.Size = new Size(115, 96);
            ReBox.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(307, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 283);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(312, 387);
            label3.Name = "label3";
            label3.Size = new Size(236, 20);
            label3.TabIndex = 9;
            label3.Text = "Cristian Alexander Menjivar Lemus";
            // 
            // Determinante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(ReBox);
            Controls.Add(Ec2Box);
            Controls.Add(Ec1Box);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DeleteBttn);
            Controls.Add(CalcularBttn);
            Controls.Add(BackBttn);
            Name = "Determinante";
            Text = "Determinante";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackBttn;
        private Button CalcularBttn;
        private Button DeleteBttn;
        private Label label1;
        private Label label2;
        private TextBox Ec1Box;
        private TextBox Ec2Box;
        private TextBox ReBox;
        private PictureBox pictureBox1;
        private Label label3;
    }
}