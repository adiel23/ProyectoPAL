namespace ProyectoPAL
{
    partial class Depositar
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
            amountTextBox = new TextBox();
            successMessage = new Label();
            balanceText = new Label();
            depositBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 69);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la cantidad a depositar:";
            // 
            // amountTextBox
            // 
            amountTextBox.Location = new Point(319, 123);
            amountTextBox.Name = "amountTextBox";
            amountTextBox.Size = new Size(125, 27);
            amountTextBox.TabIndex = 1;
            // 
            // successMessage
            // 
            successMessage.AutoSize = true;
            successMessage.Location = new Point(305, 265);
            successMessage.Name = "successMessage";
            successMessage.Size = new Size(0, 20);
            successMessage.TabIndex = 2;
            // 
            // balanceText
            // 
            balanceText.AutoSize = true;
            balanceText.Location = new Point(134, 22);
            balanceText.Name = "balanceText";
            balanceText.Size = new Size(50, 20);
            balanceText.TabIndex = 3;
            balanceText.Text = "label2";
            // 
            // depositBtn
            // 
            depositBtn.Location = new Point(338, 184);
            depositBtn.Name = "depositBtn";
            depositBtn.Size = new Size(94, 29);
            depositBtn.TabIndex = 4;
            depositBtn.Text = "Depositar";
            depositBtn.UseVisualStyleBackColor = true;
            depositBtn.Click += depositBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(21, 18);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "←";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Depositar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(depositBtn);
            Controls.Add(balanceText);
            Controls.Add(successMessage);
            Controls.Add(amountTextBox);
            Controls.Add(label1);
            Name = "Depositar";
            Text = "Depositar";
            Load += Depositar_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox amountTextBox;
        private Label successMessage;
        private Label balanceText;
        private Button depositBtn;
        private Button button1;
    }
}