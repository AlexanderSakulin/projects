using Microsoft.EntityFrameworkCore;
using SupplyGoods.DataBase;
using SupplyGoods.Models;
using System.Data;

namespace SupplyGoods.Forms
{
    public partial class ShipmentForm : Form
    {
        List<Order> orders = new();
        Shipment Shipment { get; set; }
        public ShipmentForm(Shipment shipment)
        {
            InitializeComponent();
            LoadDataList();
            Shipment = shipment;
        }
        private void LoadDataList()
        {
            try
            {
                using (Context db = new())
                {
                    var shippedOrderNumbers = db.Shipments.Select(s => s.OrderId);
                    orders = db.Orders.Where(o => !shippedOrderNumbers.Contains(o.Id))
                        .Include(o => o.Client)
                        .Include(o => o.Product)
                        .OrderBy(o => o.DateTime)
                        .ToList();
                    ordersListBox.ValueMember = "Id";
                    ordersListBox.DisplayMember = "Print";
                    ordersListBox.DataSource = orders;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ordersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ordersListBox.SelectedIndex >= 0)
            {
                int id = Convert.ToInt32(ordersListBox.SelectedValue);
                Order order = orders.Single(o => o.Id == id);
                quantityInput.Maximum = order.Quantity;
                quantityInput.Value = order.Quantity;
            }
        }
        private void FillModel()
        {
            Shipment.DateTime = DateTime.Now;
            Shipment.OrderId = Convert.ToInt32(ordersListBox.SelectedValue);
            Shipment.Quantity = Convert.ToInt32(quantityInput.Value);
        }

        private void ordersSearch_TextChanged(object sender, EventArgs e)
        {
            string line = ordersSearch.Text.ToLower();
            var filterOrders = orders.Where(o => o.Print.ToLower().Contains(line)).OrderBy(o => o.DateTime).ToList();
            ordersListBox.ValueMember = "Id";
            ordersListBox.DisplayMember = "Print";
            ordersListBox.DataSource = filterOrders;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(ordersListBox.SelectedValue);
            Order order = orders.Single(o => o.Id == id);
            if (quantityInput.Value == order.Quantity)
            {
                DialogResult = DialogResult.OK;
                FillModel();
                Close();
            }
            else
            {
                if (MessageBox.Show("Выбранное количество товара не соответствует заказу", "Оформить отгрузку?",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    FillModel();
                    Close();
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
