namespace ProyectoPAL.Forms.ATM
{
    partial class TransferWindow
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
            button1 = new Button();
            balanceText = new Label();
            usernameTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            amountTextBox = new TextBox();
            transferBtn = new Button();
            successMessage = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // balanceText
            // 
            balanceText.AutoSize = true;
            balanceText.Location = new Point(112, 16);
            balanceText.Name = "balanceText";
            balanceText.Size = new Size(50, 20);
            balanceText.TabIndex = 8;
            balanceText.Text = "label1";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(318, 124);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(134, 27);
            usernameTextBox.TabIndex = 9;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 89);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 10;
            label1.Text = "nombre de usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 189);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 11;
            label2.Text = "cantidad a enviar";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(318, 225);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(125, 27);
            amountTextBox.TabIndex = 12;
            // 
            // transferBtn
            // 
            transferBtn.Location = new Point(335, 297);
            transferBtn.Name = "transferBtn";
            transferBtn.Size = new Size(94, 29);
            transferBtn.TabIndex = 13;
            transferBtn.Text = "transferir";
            transferBtn.UseVisualStyleBackColor = true;
            transferBtn.Click += transferBtn_Click;
            // 
            // successMessage
            // 
            successMessage.AutoSize = true;
            successMessage.Location = new Point(305, 364);
            successMessage.Name = "successMessage";
            successMessage.Size = new Size(0, 20);
            successMessage.TabIndex = 14;
            // 
            // TransferWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(successMessage);
            Controls.Add(transferBtn);
            Controls.Add(amountTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(usernameTextBox);
            Controls.Add(balanceText);
            Controls.Add(button1);
            Name = "TransferWindow";
            Text = "TransferWindow";
            Load += TransferWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label balanceText;
        private TextBox usernameTextBox;
        private Label label1;
        private Label label2;
        private TextBox amountTextBox;
        private Button transferBtn;
        private Label successMessage;
    }
}