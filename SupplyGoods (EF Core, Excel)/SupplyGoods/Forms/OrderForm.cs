using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupplyGoods.DataBase;
using SupplyGoods.Models;

namespace SupplyGoods.Forms
{
    public partial class OrderForm : Form
    {
        List<Client> clients = new();
        List<Product> products = new();
        Order Order { get; set; }
        public OrderForm(Order order)
        {
            InitializeComponent();
            LoadDataLists();
            Order = order;
            FillField();
        }
        private void LoadDataLists()
        {
            try
            {
                using (Context db = new())
                {
                    clients = db.Clients.OrderBy(c => c.Name).ToList();
                    clientsListBox.DataSource = clients;
                    clientsListBox.ValueMember = "Id";
                    clientsListBox.DisplayMember = "Print";

                    products = db.Products.OrderBy(p => p.Name).ToList();
                    productsListBox.DataSource = products;
                    productsListBox.ValueMember = "Id";
                    productsListBox.DisplayMember = "Print";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void FillModel()
        {
            Order.DateTime = DateTime.Now;
            Order.ClientId = Convert.ToInt32(clientsListBox.SelectedValue);
            Order.ProductId = Convert.ToInt32(productsListBox.SelectedValue);
            Order.Quantity = (int)quantityInput.Value;
        }
        private void FillField()
        {
            clientsListBox.SelectedValue = Order.ClientId;
            productsListBox.SelectedValue = Order.ProductId;
            quantityInput.Value = Order.Quantity;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            errorClientLabel.Visible = clientsListBox.SelectedItem == null;
            errorProductLabel.Visible = productsListBox.SelectedItem == null;
            errorQuantityLabel.Visible = quantityInput.Value == 0;
            if (clientsListBox.SelectedItem != null && productsListBox.SelectedItem != null && quantityInput.Value > 0)
            {
                DialogResult = DialogResult.OK;
                FillModel();
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void clientsSearch_TextChanged(object sender, EventArgs e)
        {
            errorClientLabel.Visible = false;
            string line = clientsSearch.Text.ToLower();
            var filterClients = clients.Where(c => c.Print.ToLower().Contains(line)).OrderBy(c => c.Name).ToList();
            clientsListBox.DataSource = filterClients;
            clientsListBox.ValueMember = "Id";
            clientsListBox.DisplayMember = "Print";
        }

        private void productsSearch_TextChanged(object sender, EventArgs e)
        {
            errorProductLabel.Visible = false;
            string line = productsSearch.Text.ToLower();
            var filterProducts = products.Where(p => p.Print.ToLower().Contains(line)).OrderBy(p => p.Name).ToList();
            productsListBox.DataSource = filterProducts;
            productsListBox.ValueMember = "Id";
            productsListBox.DisplayMember = "Print";
        }
    }
}
