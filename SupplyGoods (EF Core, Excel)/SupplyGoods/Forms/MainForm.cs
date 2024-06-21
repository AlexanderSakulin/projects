namespace SupplyGoods.Forms

{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void productsButton_Click(object sender, EventArgs e)
        {
            ProductsForm productsForm = new();
            productsForm.Show();
        }

        private void clientsButton_Click(object sender, EventArgs e)
        {
            ClientsForm clientsForm = new();
            clientsForm.Show();
        }


        private void ordersButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new();
            ordersForm.WindowState = FormWindowState.Maximized;
            ordersForm.Show();
        }

        private void shipmentsButton_Click(object sender, EventArgs e)
        {
            ShipmentsForm shipmentsForm = new();
            shipmentsForm.WindowState = FormWindowState.Maximized;
            shipmentsForm.Show();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm reportsForm = new();
            reportsForm.Show();
        }
    }
}