namespace ProyectoPAL.Forms.ATM
{
    partial class WithdrawWindow
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
            withdrawBtn = new Button();
            balanceText = new Label();
            amountTextBox = new TextBox();
            label1 = new Label();
            successMessage = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(16, 13);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // withdrawBtn
            // 
            withdrawBtn.Location = new Point(347, 180);
            withdrawBtn.Name = "withdrawBtn";
            withdrawBtn.Size = new Size(94, 29);
            withdrawBtn.TabIndex = 9;
            withdrawBtn.Text = "Retirar";
            withdrawBtn.UseVisualStyleBackColor = true;
            withdrawBtn.Click += withdrawBtn_Click;
            // 
            // balanceText
            // 
            balanceText.AutoSize = true;
            balanceText.Location = new Point(129, 17);
            balanceText.Name = "balanceText";
            balanceText.Size = new Size(50, 20);
            balanceText.TabIndex = 8;
            balanceText.Text = "label2";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(332, 130);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(125, 27);
            amountTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(300, 78);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 6;
            label1.Text = "Ingrese la cantidad a retirar:";
            // 
            // successMessage
            // 
            successMessage.AutoSize = true;
            successMessage.Location = new Point(276, 239);
            successMessage.Name = "successMessage";
            successMessage.Size = new Size(0, 20);
            successMessage.TabIndex = 11;
            // 
            // WithdrawWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(successMessage);
            Controls.Add(button1);
            Controls.Add(withdrawBtn);
            Controls.Add(balanceText);
            Controls.Add(amountTextBox);
            Controls.Add(label1);
            Name = "WithdrawWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WithdrawWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button withdrawBtn;
        private Label balanceText;
        private TextBox amountTextBox;
        private Label label1;
        private Label successMessage;
    }
}