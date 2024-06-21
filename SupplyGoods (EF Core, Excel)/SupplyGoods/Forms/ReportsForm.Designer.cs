namespace SupplyGoods.Forms
{
    partial class ReportsForm
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
            radioButtonClients = new RadioButton();
            radioButtonProducts = new RadioButton();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            label1 = new Label();
            inputSearch = new TextBox();
            okButton = new Button();
            cancelButton = new Button();
            listName = new Label();
            errorLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonClients
            // 
            radioButtonClients.AutoSize = true;
            radioButtonClients.Location = new Point(6, 20);
            radioButtonClients.Name = "radioButtonClients";
            radioButtonClients.Size = new Size(84, 17);
            radioButtonClients.TabIndex = 3;
            radioButtonClients.Text = "Заказчикам";
            radioButtonClients.UseVisualStyleBackColor = true;
            radioButtonClients.CheckedChanged += radioButtonClients_CheckedChanged;
            // 
            // radioButtonProducts
            // 
            radioButtonProducts.AutoSize = true;
            radioButtonProducts.Location = new Point(96, 20);
            radioButtonProducts.Name = "radioButtonProducts";
            radioButtonProducts.Size = new Size(67, 17);
            radioButtonProducts.TabIndex = 4;
            radioButtonProducts.Text = "Товарам";
            radioButtonProducts.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonProducts);
            groupBox1.Controls.Add(radioButtonClients);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 52);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сформировать по:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 103);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(510, 199);
            listBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 73);
            label1.Name = "label1";
            label1.Size = new Size(37, 13);
            label1.TabIndex = 7;
            label1.Text = "Поиск";
            // 
            // inputSearch
            // 
            inputSearch.Location = new Point(151, 70);
            inputSearch.Name = "inputSearch";
            inputSearch.Size = new Size(371, 21);
            inputSearch.TabIndex = 8;
            inputSearch.TextChanged += inputSearch_TextChanged;
            // 
            // okButton
            // 
            okButton.AutoSize = true;
            okButton.Location = new Point(349, 308);
            okButton.Name = "okButton";
            okButton.Size = new Size(92, 23);
            okButton.TabIndex = 9;
            okButton.Text = "Сформировать";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(447, 308);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // listName
            // 
            listName.AutoSize = true;
            listName.Location = new Point(12, 73);
            listName.Name = "listName";
            listName.Size = new Size(35, 13);
            listName.TabIndex = 11;
            listName.Text = "label2";
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.ForeColor = Color.Red;
            errorLabel.Location = new Point(12, 313);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(47, 13);
            errorLabel.TabIndex = 12;
            errorLabel.Text = "Ошибка";
            errorLabel.Visible = false;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 339);
            Controls.Add(errorLabel);
            Controls.Add(listName);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(inputSearch);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "ReportsForm";
            Text = "Статистика выполнения заказов";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButtonClients;
        private RadioButton radioButtonProducts;
        private GroupBox groupBox1;
        private ListBox listBox1;
        private Label label1;
        private TextBox inputSearch;
        private Button okButton;
        private Button cancelButton;
        private Label listName;
        private Label errorLabel;
    }
}