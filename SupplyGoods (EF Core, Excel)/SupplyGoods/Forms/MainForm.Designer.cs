namespace SupplyGoods.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            productsButton = new Button();
            clientsButton = new Button();
            ordersButton = new Button();
            shipmentsButton = new Button();
            reportsButton = new Button();
            SuspendLayout();
            // 
            // productsButton
            // 
            productsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            productsButton.Location = new Point(12, 12);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(97, 30);
            productsButton.TabIndex = 0;
            productsButton.Text = "Товары";
            productsButton.UseVisualStyleBackColor = true;
            productsButton.Click += productsButton_Click;
            // 
            // clientsButton
            // 
            clientsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            clientsButton.Location = new Point(115, 12);
            clientsButton.Name = "clientsButton";
            clientsButton.Size = new Size(97, 30);
            clientsButton.TabIndex = 1;
            clientsButton.Text = "Заказчики";
            clientsButton.UseVisualStyleBackColor = true;
            clientsButton.Click += clientsButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ordersButton.Location = new Point(218, 12);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(97, 30);
            ordersButton.TabIndex = 2;
            ordersButton.Text = "Заказы";
            ordersButton.UseVisualStyleBackColor = true;
            ordersButton.Click += ordersButton_Click;
            // 
            // shipmentsButton
            // 
            shipmentsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            shipmentsButton.Location = new Point(321, 12);
            shipmentsButton.Name = "shipmentsButton";
            shipmentsButton.Size = new Size(97, 30);
            shipmentsButton.TabIndex = 3;
            shipmentsButton.Text = "Отгрузки";
            shipmentsButton.UseVisualStyleBackColor = true;
            shipmentsButton.Click += shipmentsButton_Click;
            // 
            // reportsButton
            // 
            reportsButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            reportsButton.Location = new Point(424, 12);
            reportsButton.Name = "reportsButton";
            reportsButton.Size = new Size(97, 30);
            reportsButton.TabIndex = 4;
            reportsButton.Text = "Отчёты";
            reportsButton.UseVisualStyleBackColor = true;
            reportsButton.Click += reportsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 55);
            Controls.Add(reportsButton);
            Controls.Add(shipmentsButton);
            Controls.Add(ordersButton);
            Controls.Add(clientsButton);
            Controls.Add(productsButton);
            Name = "MainForm";
            Text = "Поставка товаров";
            ResumeLayout(false);
        }

        #endregion

        private Button productsButton;
        private Button clientsButton;
        private Button ordersButton;
        private Button shipmentsButton;
        private Button reportsButton;
    }
}