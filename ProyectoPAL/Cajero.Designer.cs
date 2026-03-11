namespace ProyectoPAL
{
    partial class Cajero
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
            balanceMessage = new Label();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // balanceMessage
            // 
            balanceMessage.AutoSize = true;
            balanceMessage.Location = new Point(267, 50);
            balanceMessage.Name = "balanceMessage";
            balanceMessage.Size = new Size(0, 20);
            balanceMessage.TabIndex = 1;
            balanceMessage.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 74);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 3;
            label1.Text = "Iniciar sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 299);
            label2.Name = "label2";
            label2.Size = new Size(245, 20);
            label2.TabIndex = 4;
            label2.Text = "si no tienes una cuenta haz clic aqui";
            label2.Click += label2_Click;
            // 
            // Cajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(balanceMessage);
            Name = "Cajero";
            Text = "Cajero";
            Load += Cajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label balanceMessage;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}