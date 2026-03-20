namespace ProyectoPAL
{
    partial class Registrarse
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
            label2 = new Label();
            usernameInput = new TextBox();
            passwordInput = new TextBox();
            registerBtn = new Button();
            errorMessage = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(334, 28);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Registrarse";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(258, 355);
            label2.Name = "label2";
            label2.Size = new Size(255, 20);
            label2.TabIndex = 1;
            label2.Text = "Si ya tienes una cuenta, haz click aqui";
            label2.Click += label2_Click;
            // 
            // usernameInput
            // 
            usernameInput.Location = new Point(288, 137);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(195, 27);
            usernameInput.TabIndex = 2;
            // 
            // passwordInput
            // 
            passwordInput.Location = new Point(288, 222);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(195, 27);
            passwordInput.TabIndex = 3;
            // 
            // registerBtn
            // 
            registerBtn.Location = new Point(334, 283);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(94, 29);
            registerBtn.TabIndex = 4;
            registerBtn.Text = "registrarse";
            registerBtn.UseVisualStyleBackColor = true;
            registerBtn.Click += registerBtn_Click;
            // 
            // errorMessage
            // 
            errorMessage.AutoSize = true;
            errorMessage.Location = new Point(325, 85);
            errorMessage.Name = "errorMessage";
            errorMessage.Size = new Size(0, 20);
            errorMessage.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 114);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 9;
            label3.Text = "nombre de usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(343, 199);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 10;
            label4.Text = "contrasenia";
            // 
            // Registrarse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(errorMessage);
            Controls.Add(registerBtn);
            Controls.Add(passwordInput);
            Controls.Add(usernameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Registrarse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registrarse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Button registerBtn;
        private Label errorMessage;
        private Label label3;
        private Label label4;
    }
}