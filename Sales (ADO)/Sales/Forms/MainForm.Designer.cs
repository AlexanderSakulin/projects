namespace Sales.Forms
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
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииТоваровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.производителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.реестрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.продажиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.категорииТоваровToolStripMenuItem,
            this.производителиToolStripMenuItem,
            this.должностиToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(160, 34);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // категорииТоваровToolStripMenuItem
            // 
            this.категорииТоваровToolStripMenuItem.Name = "категорииТоваровToolStripMenuItem";
            this.категорииТоваровToolStripMenuItem.Size = new System.Drawing.Size(314, 40);
            this.категорииТоваровToolStripMenuItem.Text = "Категории товаров";
            this.категорииТоваровToolStripMenuItem.Click += new System.EventHandler(this.категорииТоваровToolStripMenuItem_Click);
            // 
            // производителиToolStripMenuItem
            // 
            this.производителиToolStripMenuItem.Name = "производителиToolStripMenuItem";
            this.производителиToolStripMenuItem.Size = new System.Drawing.Size(314, 40);
            this.производителиToolStripMenuItem.Text = "Производители";
            this.производителиToolStripMenuItem.Click += new System.EventHandler(this.производителиToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(314, 40);
            this.должностиToolStripMenuItem.Text = "Должности";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // реестрToolStripMenuItem
            // 
            this.реестрToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сотрудникиtoolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.товарыToolStripMenuItem,
            this.продажиToolStripMenuItem});
            this.реестрToolStripMenuItem.Name = "реестрToolStripMenuItem";
            this.реестрToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.реестрToolStripMenuItem.Text = "Реестр";
            // 
            // сотрудникиtoolStripMenuItem
            // 
            this.сотрудникиtoolStripMenuItem.Name = "сотрудникиtoolStripMenuItem";
            this.сотрудникиtoolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.сотрудникиtoolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиtoolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            this.клиентыToolStripMenuItem.Click += new System.EventHandler(this.клиентыToolStripMenuItem_Click);
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.товарыToolStripMenuItem.Text = "Товары";
            this.товарыToolStripMenuItem.Click += new System.EventHandler(this.товарыToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.реестрToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1371, 42);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // продажиToolStripMenuItem
            // 
            this.продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            this.продажиToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.продажиToolStripMenuItem.Text = "Продажи";
            this.продажиToolStripMenuItem.Click += new System.EventHandler(this.продажиToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 900);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "MainForm";
            this.Text = "Продажи";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStripMenuItem справочникиToolStripMenuItem;
        private ToolStripMenuItem категорииТоваровToolStripMenuItem;
        private ToolStripMenuItem производителиToolStripMenuItem;
        private ToolStripMenuItem должностиToolStripMenuItem;
        private ToolStripMenuItem реестрToolStripMenuItem;
        private ToolStripMenuItem сотрудникиtoolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem товарыToolStripMenuItem;
        private ToolStripMenuItem продажиToolStripMenuItem;
    }
}