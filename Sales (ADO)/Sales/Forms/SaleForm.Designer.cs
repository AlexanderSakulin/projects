namespace Sales.Forms
{
    partial class SaleForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.productsList = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.employeesList = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clientsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sumInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceInput = new System.Windows.Forms.TextBox();
            this.countInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countInput)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(1184, 772);
            this.okButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(137, 54);
            this.okButton.TabIndex = 9;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1331, 772);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 54);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // productsList
            // 
            this.productsList.FormattingEnabled = true;
            this.productsList.ItemHeight = 30;
            this.productsList.Location = new System.Drawing.Point(6, 34);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(453, 514);
            this.productsList.TabIndex = 11;
            this.productsList.SelectedValueChanged += new System.EventHandler(this.productsList_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productsList);
            this.groupBox1.Location = new System.Drawing.Point(31, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 554);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Товар";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.employeesList);
            this.groupBox2.Location = new System.Drawing.Point(513, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(465, 554);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Продавец";
            // 
            // employeesList
            // 
            this.employeesList.FormattingEnabled = true;
            this.employeesList.ItemHeight = 30;
            this.employeesList.Location = new System.Drawing.Point(6, 34);
            this.employeesList.Name = "employeesList";
            this.employeesList.Size = new System.Drawing.Size(453, 514);
            this.employeesList.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.clientsList);
            this.groupBox3.Location = new System.Drawing.Point(995, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 554);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Клиент";
            // 
            // clientsList
            // 
            this.clientsList.FormattingEnabled = true;
            this.clientsList.ItemHeight = 30;
            this.clientsList.Location = new System.Drawing.Point(6, 34);
            this.clientsList.Name = "clientsList";
            this.clientsList.Size = new System.Drawing.Size(453, 514);
            this.clientsList.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 682);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 30);
            this.label1.TabIndex = 14;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 729);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 14;
            this.label2.Text = "Сумма";
            // 
            // sumInput
            // 
            this.sumInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sumInput.Location = new System.Drawing.Point(169, 724);
            this.sumInput.Name = "sumInput";
            this.sumInput.ReadOnly = true;
            this.sumInput.Size = new System.Drawing.Size(175, 35);
            this.sumInput.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 641);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Цена";
            // 
            // priceInput
            // 
            this.priceInput.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.priceInput.Location = new System.Drawing.Point(169, 638);
            this.priceInput.Name = "priceInput";
            this.priceInput.ReadOnly = true;
            this.priceInput.Size = new System.Drawing.Size(175, 35);
            this.priceInput.TabIndex = 15;
            // 
            // countInput
            // 
            this.countInput.DecimalPlaces = 3;
            this.countInput.Location = new System.Drawing.Point(169, 682);
            this.countInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countInput.Name = "countInput";
            this.countInput.Size = new System.Drawing.Size(175, 35);
            this.countInput.TabIndex = 16;
            this.countInput.ValueChanged += new System.EventHandler(this.countInput_ValueChanged);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 841);
            this.Controls.Add(this.countInput);
            this.Controls.Add(this.sumInput);
            this.Controls.Add(this.priceInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.countInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button okButton;
        private Button cancelButton;
        private ListBox productsList;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox employeesList;
        private GroupBox groupBox3;
        private ListBox clientsList;
        private Label label1;
        private Label label2;
        private TextBox sumInput;
        private Label label3;
        private TextBox priceInput;
        private NumericUpDown countInput;
    }
}