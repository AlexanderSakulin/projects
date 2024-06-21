namespace Sales.Forms
{
    partial class ProductForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.vendorСodeInput = new System.Windows.Forms.TextBox();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.categoryInput = new System.Windows.Forms.ComboBox();
            this.manufacturerInput = new System.Windows.Forms.ComboBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Артикул";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Категория";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Производитель";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(108, 170);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(54, 15);
            this.errorLabel.TabIndex = 5;
            this.errorLabel.Text = "Ошибки";
            this.errorLabel.Visible = false;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(108, 12);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(566, 23);
            this.nameInput.TabIndex = 6;
            // 
            // vendorСodeInput
            // 
            this.vendorСodeInput.Location = new System.Drawing.Point(108, 41);
            this.vendorСodeInput.Name = "vendorСodeInput";
            this.vendorСodeInput.Size = new System.Drawing.Size(566, 23);
            this.vendorСodeInput.TabIndex = 7;
            // 
            // priceInput
            // 
            this.priceInput.Location = new System.Drawing.Point(108, 70);
            this.priceInput.Name = "priceInput";
            this.priceInput.Size = new System.Drawing.Size(566, 23);
            this.priceInput.TabIndex = 8;
            // 
            // categoryInput
            // 
            this.categoryInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryInput.FormattingEnabled = true;
            this.categoryInput.Location = new System.Drawing.Point(108, 99);
            this.categoryInput.Name = "categoryInput";
            this.categoryInput.Size = new System.Drawing.Size(170, 23);
            this.categoryInput.TabIndex = 9;
            // 
            // manufacturerInput
            // 
            this.manufacturerInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerInput.FormattingEnabled = true;
            this.manufacturerInput.Location = new System.Drawing.Point(108, 128);
            this.manufacturerInput.Name = "manufacturerInput";
            this.manufacturerInput.Size = new System.Drawing.Size(170, 23);
            this.manufacturerInput.TabIndex = 10;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(490, 170);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(588, 170);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 217);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.manufacturerInput);
            this.Controls.Add(this.categoryInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.vendorСodeInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label errorLabel;
        private TextBox nameInput;
        private TextBox vendorСodeInput;
        private TextBox priceInput;
        private ComboBox categoryInput;
        private ComboBox manufacturerInput;
        private Button okButton;
        private Button cancelButton;
    }
}