namespace Sales.Forms
{
    partial class EmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.surnameInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.patronymicInput = new System.Windows.Forms.TextBox();
            this.positionsInput = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Должность";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(102, 137);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(54, 15);
            this.errorLabel.TabIndex = 4;
            this.errorLabel.Text = "Ошибки";
            this.errorLabel.Visible = false;
            // 
            // surnameInput
            // 
            this.surnameInput.Location = new System.Drawing.Point(102, 15);
            this.surnameInput.Name = "surnameInput";
            this.surnameInput.Size = new System.Drawing.Size(686, 23);
            this.surnameInput.TabIndex = 5;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(102, 44);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(686, 23);
            this.nameInput.TabIndex = 6;
            // 
            // patronymicInput
            // 
            this.patronymicInput.Location = new System.Drawing.Point(102, 73);
            this.patronymicInput.Name = "patronymicInput";
            this.patronymicInput.Size = new System.Drawing.Size(686, 23);
            this.patronymicInput.TabIndex = 7;
            // 
            // positionsInput
            // 
            this.positionsInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionsInput.FormattingEnabled = true;
            this.positionsInput.Location = new System.Drawing.Point(102, 102);
            this.positionsInput.Name = "positionsInput";
            this.positionsInput.Size = new System.Drawing.Size(200, 23);
            this.positionsInput.TabIndex = 8;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(576, 125);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(80, 27);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(676, 125);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(80, 27);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 181);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.positionsInput);
            this.Controls.Add(this.patronymicInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.surnameInput);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label errorLabel;
        private TextBox surnameInput;
        private TextBox nameInput;
        private TextBox patronymicInput;
        private ComboBox positionsInput;
        private Button okButton;
        private Button cancelButton;
    }
}