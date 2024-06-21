namespace SupplyGoods.Forms
{
    partial class OrderForm
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
            clientsSearch = new TextBox();
            label2 = new Label();
            productsSearch = new TextBox();
            clientsListBox = new ListBox();
            productsListBox = new ListBox();
            label3 = new Label();
            label4 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            quantityInput = new NumericUpDown();
            label5 = new Label();
            errorClientLabel = new Label();
            errorProductLabel = new Label();
            errorQuantityLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(37, 13);
            label1.TabIndex = 0;
            label1.Text = "Поиск";
            // 
            // clientsSearch
            // 
            clientsSearch.Location = new Point(53, 41);
            clientsSearch.Name = "clientsSearch";
            clientsSearch.Size = new Size(401, 21);
            clientsSearch.TabIndex = 1;
            clientsSearch.TextChanged += clientsSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(512, 44);
            label2.Name = "label2";
            label2.Size = new Size(37, 13);
            label2.TabIndex = 2;
            label2.Text = "Поиск";
            // 
            // productsSearch
            // 
            productsSearch.Location = new Point(555, 41);
            productsSearch.Name = "productsSearch";
            productsSearch.Size = new Size(401, 21);
            productsSearch.TabIndex = 3;
            productsSearch.TextChanged += productsSearch_TextChanged;
            // 
            // clientsListBox
            // 
            clientsListBox.FormattingEnabled = true;
            clientsListBox.Location = new Point(12, 68);
            clientsListBox.Name = "clientsListBox";
            clientsListBox.Size = new Size(442, 199);
            clientsListBox.TabIndex = 4;
            // 
            // productsListBox
            // 
            productsListBox.FormattingEnabled = true;
            productsListBox.Location = new Point(512, 68);
            productsListBox.Name = "productsListBox";
            productsListBox.Size = new Size(444, 199);
            productsListBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(76, 16);
            label3.TabIndex = 6;
            label3.Text = "Заказчики";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(512, 9);
            label4.Name = "label4";
            label4.Size = new Size(57, 16);
            label4.TabIndex = 7;
            label4.Text = "Товары";
            // 
            // okButton
            // 
            okButton.Location = new Point(800, 293);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 8;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(881, 293);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // quantityInput
            // 
            quantityInput.Location = new Point(85, 291);
            quantityInput.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(120, 21);
            quantityInput.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 293);
            label5.Name = "label5";
            label5.Size = new Size(67, 13);
            label5.TabIndex = 11;
            label5.Text = "Количество";
            // 
            // errorClientLabel
            // 
            errorClientLabel.AutoSize = true;
            errorClientLabel.ForeColor = Color.Red;
            errorClientLabel.Location = new Point(12, 270);
            errorClientLabel.Name = "errorClientLabel";
            errorClientLabel.Size = new Size(167, 13);
            errorClientLabel.TabIndex = 12;
            errorClientLabel.Text = "Выберите заказчика из списка!";
            errorClientLabel.Visible = false;
            // 
            // errorProductLabel
            // 
            errorProductLabel.AutoSize = true;
            errorProductLabel.ForeColor = Color.Red;
            errorProductLabel.Location = new Point(512, 270);
            errorProductLabel.Name = "errorProductLabel";
            errorProductLabel.Size = new Size(222, 13);
            errorProductLabel.TabIndex = 13;
            errorProductLabel.Text = "Выберите заказываемый товар из списка!";
            errorProductLabel.Visible = false;
            // 
            // errorQuantityLabel
            // 
            errorQuantityLabel.AutoSize = true;
            errorQuantityLabel.ForeColor = Color.Red;
            errorQuantityLabel.Location = new Point(85, 315);
            errorQuantityLabel.Name = "errorQuantityLabel";
            errorQuantityLabel.Size = new Size(155, 13);
            errorQuantityLabel.TabIndex = 14;
            errorQuantityLabel.Text = "Введите количество товара!";
            errorQuantityLabel.Visible = false;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 345);
            Controls.Add(errorQuantityLabel);
            Controls.Add(errorProductLabel);
            Controls.Add(errorClientLabel);
            Controls.Add(label5);
            Controls.Add(quantityInput);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(productsListBox);
            Controls.Add(clientsListBox);
            Controls.Add(productsSearch);
            Controls.Add(label2);
            Controls.Add(clientsSearch);
            Controls.Add(label1);
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox clientsSearch;
        private Label label2;
        private TextBox productsSearch;
        private ListBox clientsListBox;
        private ListBox productsListBox;
        private Label label3;
        private Label label4;
        private Button okButton;
        private Button cancelButton;
        private NumericUpDown quantityInput;
        private Label label5;
        private Label errorClientLabel;
        private Label errorProductLabel;
        private Label errorQuantityLabel;
    }
}