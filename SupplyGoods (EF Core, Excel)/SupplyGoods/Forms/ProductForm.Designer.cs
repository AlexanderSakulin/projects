namespace SupplyGoods.Forms
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
            label1 = new Label();
            label2 = new Label();
            errorLabel = new Label();
            nameInput = new TextBox();
            priceInput = new NumericUpDown();
            okButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)priceInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(80, 13);
            label1.TabIndex = 0;
            label1.Text = "Наименование";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 37);
            label2.Name = "label2";
            label2.Size = new Size(33, 13);
            label2.TabIndex = 1;
            label2.Text = "Цена";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(93, 58);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(47, 13);
            errorLabel.TabIndex = 2;
            errorLabel.Text = "Ошибки";
            errorLabel.Visible = false;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(93, 10);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(340, 21);
            nameInput.TabIndex = 3;
            nameInput.TextChanged += nameInput_TextChanged;
            // 
            // priceInput
            // 
            priceInput.DecimalPlaces = 2;
            priceInput.Location = new Point(93, 36);
            priceInput.Maximum = new decimal(new int[] { 1410065407, 2, 0, 0 });
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(103, 21);
            priceInput.TabIndex = 4;
            // 
            // okButton
            // 
            okButton.Location = new Point(298, 55);
            okButton.Name = "okButton";
            okButton.Size = new Size(64, 20);
            okButton.TabIndex = 5;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(368, 55);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(64, 20);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 86);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(priceInput);
            Controls.Add(nameInput);
            Controls.Add(errorLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)priceInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label errorLabel;
        private TextBox nameInput;
        private NumericUpDown priceInput;
        private Button okButton;
        private Button cancelButton;
    }
}