namespace ProyectoPAL
{
    partial class ATMWindow
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
            goBackBtn = new Button();
            balanceText = new Label();
            openDepositWindowBtn = new Button();
            openWithdrawWindowBtn = new Button();
            openTransferWindowBtn = new Button();
            SuspendLayout();
            // 
            // goBackBtn
            // 
            goBackBtn.Location = new Point(25, 27);
            goBackBtn.Name = "goBackBtn";
            goBackBtn.Size = new Size(94, 29);
            goBackBtn.TabIndex = 6;
            goBackBtn.Text = "←";
            goBackBtn.UseVisualStyleBackColor = true;
            goBackBtn.Click += goBackBtn_Click;
            // 
            // balanceText
            // 
            balanceText.AutoSize = true;
            balanceText.Location = new Point(145, 31);
            balanceText.Name = "balanceText";
            balanceText.Size = new Size(50, 20);
            balanceText.TabIndex = 7;
            balanceText.Text = "label1";
            balanceText.Click += balanceText_Click;
            // 
            // openDepositWindowBtn
            // 
            openDepositWindowBtn.Location = new Point(145, 157);
            openDepositWindowBtn.Name = "openDepositWindowBtn";
            openDepositWindowBtn.Size = new Size(94, 29);
            openDepositWindowBtn.TabIndex = 8;
            openDepositWindowBtn.Text = "depositar";
            openDepositWindowBtn.UseVisualStyleBackColor = true;
            openDepositWindowBtn.Click += openDepositWindowBtn_Click;
            // 
            // openWithdrawWindowBtn
            // 
            openWithdrawWindowBtn.Location = new Point(354, 157);
            openWithdrawWindowBtn.Name = "openWithdrawWindowBtn";
            openWithdrawWindowBtn.Size = new Size(94, 29);
            openWithdrawWindowBtn.TabIndex = 9;
            openWithdrawWindowBtn.Text = "retirar";
            openWithdrawWindowBtn.UseVisualStyleBackColor = true;
            // 
            // openTransferWindowBtn
            // 
            openTransferWindowBtn.Location = new Point(547, 157);
            openTransferWindowBtn.Name = "openTransferWindowBtn";
            openTransferWindowBtn.Size = new Size(94, 29);
            openTransferWindowBtn.TabIndex = 10;
            openTransferWindowBtn.Text = "transferir";
            openTransferWindowBtn.UseVisualStyleBackColor = true;
            // 
            // ATMWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(openTransferWindowBtn);
            Controls.Add(openWithdrawWindowBtn);
            Controls.Add(openDepositWindowBtn);
            Controls.Add(balanceText);
            Controls.Add(goBackBtn);
            Name = "ATMWindow";
            Text = "ATM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goBackBtn;
        private Label balanceText;
        private Button openDepositWindowBtn;
        private Button openWithdrawWindowBtn;
        private Button openTransferWindowBtn;
    }
}