namespace SupplyGoods.Forms
{
    partial class ClientForm
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
            label3 = new Label();
            errorLabel = new Label();
            nameInput = new TextBox();
            addressInput = new TextBox();
            phoneInput = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(26, 13);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 38);
            label2.Name = "label2";
            label2.Size = new Size(38, 13);
            label2.TabIndex = 1;
            label2.Text = "Адрес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 63);
            label3.Name = "label3";
            label3.Size = new Size(51, 13);
            label3.TabIndex = 2;
            label3.Text = "Телефон";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(96, 83);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(47, 13);
            errorLabel.TabIndex = 3;
            errorLabel.Text = "Ошибка";
            errorLabel.Visible = false;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(96, 10);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(465, 21);
            nameInput.TabIndex = 4;
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // addressInput
            // 
            addressInput.Location = new Point(96, 36);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(465, 21);
            addressInput.TabIndex = 5;
            addressInput.TextChanged += addressInput_TextChanged;
            // 
            // phoneInput
            // 
            phoneInput.Location = new Point(96, 61);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(220, 21);
            phoneInput.TabIndex = 6;
            phoneInput.TextChanged += phoneInput_TextChanged;
            // 
            // okButton
            // 
            okButton.Location = new Point(427, 83);
            okButton.Name = "okButton";
            okButton.Size = new Size(64, 20);
            okButton.TabIndex = 7;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(496, 83);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(64, 20);
            cancelButton.TabIndex = 8;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(571, 114);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(phoneInput);
            Controls.Add(addressInput);
            Controls.Add(nameInput);
            Controls.Add(errorLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ClientForm";
            Text = "ClientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label errorLabel;
        private TextBox nameInput;
        private TextBox addressInput;
        private TextBox phoneInput;
        private Button okButton;
        private Button cancelButton;
    }
}