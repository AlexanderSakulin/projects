namespace SupplyGoods.Forms
{
    partial class ShipmentForm
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
            ordersListBox = new ListBox();
            label1 = new Label();
            ordersSearch = new TextBox();
            label2 = new Label();
            quantityInput = new NumericUpDown();
            label3 = new Label();
            okButton = new Button();
            cancelButton = new Button();
            ((System.ComponentModel.ISupportInitialize)quantityInput).BeginInit();
            SuspendLayout();
            // 
            // ordersListBox
            // 
            ordersListBox.FormattingEnabled = true;
            ordersListBox.Location = new Point(12, 39);
            ordersListBox.Name = "ordersListBox";
            ordersListBox.Size = new Size(776, 199);
            ordersListBox.TabIndex = 0;
            ordersListBox.SelectedIndexChanged += ordersListBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(44, 13);
            label1.TabIndex = 1;
            label1.Text = "Заказы";
            // 
            // ordersSearch
            // 
            ordersSearch.Location = new Point(389, 12);
            ordersSearch.Name = "ordersSearch";
            ordersSearch.Size = new Size(399, 21);
            ordersSearch.TabIndex = 2;
            ordersSearch.TextChanged += ordersSearch_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(348, 15);
            label2.Name = "label2";
            label2.Size = new Size(37, 13);
            label2.TabIndex = 3;
            label2.Text = "Поиск";
            // 
            // quantityInput
            // 
            quantityInput.Location = new Point(195, 244);
            quantityInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(120, 21);
            quantityInput.TabIndex = 4;
            quantityInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 246);
            label3.Name = "label3";
            label3.Size = new Size(177, 13);
            label3.TabIndex = 5;
            label3.Text = "Отгружаемое количество товара";
            // 
            // okButton
            // 
            okButton.Location = new Point(632, 268);
            okButton.Name = "okButton";
            okButton.Size = new Size(75, 23);
            okButton.TabIndex = 6;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(713, 268);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // ShipmentForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 302);
            Controls.Add(cancelButton);
            Controls.Add(okButton);
            Controls.Add(label3);
            Controls.Add(quantityInput);
            Controls.Add(label2);
            Controls.Add(ordersSearch);
            Controls.Add(label1);
            Controls.Add(ordersListBox);
            Name = "ShipmentForm";
            Text = "ShipmentForm";
            ((System.ComponentModel.ISupportInitialize)quantityInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ordersListBox;
        private Label label1;
        private TextBox ordersSearch;
        private Label label2;
        private NumericUpDown quantityInput;
        private Label label3;
        private Button okButton;
        private Button cancelButton;
    }
}