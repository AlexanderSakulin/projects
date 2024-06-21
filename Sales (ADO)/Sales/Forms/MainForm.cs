namespace Sales.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized; // Авторазворачивание формы при старте
        }

        private void категорииТоваровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriesForm categoriesForm = new CategoriesForm();
            categoriesForm.MdiParent = this; // Родитель - это (главная) форма
            categoriesForm.Show(); // Показывает форму пользователю
        }

        private void производителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManufacturersForm manufacturersForm = new ManufacturersForm();
            manufacturersForm.MdiParent = this;
            manufacturersForm.Show();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PositionsForm positionsForm = new PositionsForm();
            positionsForm.MdiParent = this;
            positionsForm.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeesForm employeesForm = new EmployeesForm();
            employeesForm.MdiParent= this;
            employeesForm.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new ClientsForm();
            clientsForm.MdiParent = this;
            clientsForm.Show();
        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new ProductsForm();
            productsForm.MdiParent = this;
            productsForm.Show();
        }

        private void продажиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.MdiParent = this;
            salesForm.Show();
        }
    }
}