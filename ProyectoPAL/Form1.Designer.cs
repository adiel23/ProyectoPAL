namespace ProyectoPAL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            openAngleBtn = new Button();
            openDeterminantBtn = new Button();
            openATMBtn = new Button();
            openInheritenceBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(233, 29);
            label1.Name = "label1";
            label1.Size = new Size(322, 28);
            label1.TabIndex = 0;
            label1.Text = "PROGRAMACION DE ALGORITMOS";
            // 
            // openAngleBtn
            // 
            openAngleBtn.Location = new Point(135, 132);
            openAngleBtn.Name = "openAngleBtn";
            openAngleBtn.Size = new Size(158, 29);
            openAngleBtn.TabIndex = 1;
            openAngleBtn.Text = "Angulos Agudos";
            openAngleBtn.UseVisualStyleBackColor = true;
            openAngleBtn.Click += openAngleBtn_Click;
            // 
            // openDeterminantBtn
            // 
            openDeterminantBtn.Location = new Point(469, 132);
            openDeterminantBtn.Name = "openDeterminantBtn";
            openDeterminantBtn.Size = new Size(232, 29);
            openDeterminantBtn.TabIndex = 2;
            openDeterminantBtn.Text = "Determinante regla cramer";
            openDeterminantBtn.UseVisualStyleBackColor = true;
            openDeterminantBtn.Click += openDeterminantBtn_Click;
            // 
            // openATMBtn
            // 
            openATMBtn.Location = new Point(135, 259);
            openATMBtn.Name = "openATMBtn";
            openATMBtn.Size = new Size(155, 29);
            openATMBtn.TabIndex = 3;
            openATMBtn.Text = "Cajero del banco";
            openATMBtn.UseVisualStyleBackColor = true;
            openATMBtn.Click += openATMBtn_Click;
            // 
            // openInheritenceBtn
            // 
            openInheritenceBtn.Location = new Point(547, 259);
            openInheritenceBtn.Name = "openInheritenceBtn";
            openInheritenceBtn.Size = new Size(94, 29);
            openInheritenceBtn.TabIndex = 4;
            openInheritenceBtn.Text = "Herencia";
            openInheritenceBtn.UseVisualStyleBackColor = true;
            openInheritenceBtn.Click += openInheritenceBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(356, 363);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "creditos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(openInheritenceBtn);
            Controls.Add(openATMBtn);
            Controls.Add(openDeterminantBtn);
            Controls.Add(openAngleBtn);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button openAngleBtn;
        private Button openDeterminantBtn;
        private Button openATMBtn;
        private Button openInheritenceBtn;
        private Button button1;
    }
}
