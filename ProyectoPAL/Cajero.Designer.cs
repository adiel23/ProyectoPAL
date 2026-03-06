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
            openDepositBtn = new Button();
            balanceMessage = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // openDepositBtn
            // 
            openDepositBtn.Location = new Point(76, 142);
            openDepositBtn.Name = "openDepositBtn";
            openDepositBtn.Size = new Size(149, 29);
            openDepositBtn.TabIndex = 0;
            openDepositBtn.Text = "depositar";
            openDepositBtn.UseVisualStyleBackColor = true;
            openDepositBtn.Click += openDepositBtn_Click;
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
            // Cajero
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(balanceMessage);
            Controls.Add(openDepositBtn);
            Name = "Cajero";
            Text = "Cajero";
            Load += Cajero_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openDepositBtn;
        private Label balanceMessage;
        private Button button1;
    }
}