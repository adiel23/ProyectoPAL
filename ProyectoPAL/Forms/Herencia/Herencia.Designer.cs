namespace ProyectoPAL
{
    partial class Herencia
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
            label1 = new Label();
            inheritanceTextBox = new TextBox();
            juanLabel = new Label();
            luisLabel = new Label();
            rosaLabel = new Label();
            calculateBtn = new Button();
            abogadoLabel = new Label();
            button1 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 63);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "digite la herencia";
            // 
            // inheritanceTextBox
            // 
            inheritanceTextBox.Location = new Point(26, 103);
            inheritanceTextBox.Name = "inheritanceTextBox";
            inheritanceTextBox.Size = new Size(125, 27);
            inheritanceTextBox.TabIndex = 1;
            // 
            // juanLabel
            // 
            juanLabel.AutoSize = true;
            juanLabel.Location = new Point(26, 159);
            juanLabel.Name = "juanLabel";
            juanLabel.Size = new Size(143, 20);
            juanLabel.TabIndex = 2;
            juanLabel.Text = "Cantidad para Juan: ";
            // 
            // luisLabel
            // 
            luisLabel.AutoSize = true;
            luisLabel.Location = new Point(26, 205);
            luisLabel.Name = "luisLabel";
            luisLabel.Size = new Size(135, 20);
            luisLabel.TabIndex = 3;
            luisLabel.Text = "Cantidad para Luis:";
            // 
            // rosaLabel
            // 
            rosaLabel.AutoSize = true;
            rosaLabel.Location = new Point(26, 251);
            rosaLabel.Name = "rosaLabel";
            rosaLabel.Size = new Size(146, 20);
            rosaLabel.TabIndex = 4;
            rosaLabel.Text = "Cantidad para Rosa: ";
            // 
            // calculateBtn
            // 
            calculateBtn.Location = new Point(37, 356);
            calculateBtn.Name = "calculateBtn";
            calculateBtn.Size = new Size(94, 29);
            calculateBtn.TabIndex = 5;
            calculateBtn.Text = "calcular";
            calculateBtn.UseVisualStyleBackColor = true;
            calculateBtn.Click += calculateBtn_Click;
            // 
            // abogadoLabel
            // 
            abogadoLabel.AutoSize = true;
            abogadoLabel.Location = new Point(26, 298);
            abogadoLabel.Name = "abogadoLabel";
            abogadoLabel.Size = new Size(187, 20);
            abogadoLabel.TabIndex = 6;
            abogadoLabel.Text = "Cantidad para el abogado:";
            abogadoLabel.Click += abogadoLabel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(522, 393);
            label2.Name = "label2";
            label2.Size = new Size(243, 20);
            label2.TabIndex = 8;
            label2.Text = "Moisés Eduardo Monchez Alvarado";
            // 
            // Herencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(abogadoLabel);
            Controls.Add(calculateBtn);
            Controls.Add(rosaLabel);
            Controls.Add(luisLabel);
            Controls.Add(juanLabel);
            Controls.Add(inheritanceTextBox);
            Controls.Add(label1);
            Name = "Herencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Herencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inheritanceTextBox;
        private Label juanLabel;
        private Label luisLabel;
        private Label rosaLabel;
        private Button calculateBtn;
        private Label abogadoLabel;
        private Button button1;
        private Label label2;
    }
}