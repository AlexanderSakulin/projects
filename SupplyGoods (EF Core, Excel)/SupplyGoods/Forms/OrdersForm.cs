using Microsoft.EntityFrameworkCore;
using SupplyGoods.DataBase;
using SupplyGoods.Models;
using System.Data;

namespace SupplyGoods.Forms
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (Context db = new())
                {
                    List<Order> orders = db.Orders.Include(o => o.Product).Include(o => o.Client).OrderBy(o => o.DateTime).ToList();
                    DataTable dataTable = new();
                    dataTable.Columns.Add("Номер заказа");
                    dataTable.Columns.Add("Дата");
                    dataTable.Columns.Add("Заказчик");
                    dataTable.Columns.Add("Товар");
                    dataTable.Columns.Add("Количество");
                    foreach (Order order in orders)
                    {
                        dataTable.Rows.Add(order.Id, order.DateTime, order.Client.Name, order.Product.Name, order.Quantity);
                    }
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            Order order = new();
            OrderForm orderForm = new(order);
            orderForm.Text = "Добавить заказ!";
            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Context db = new())
                    {
                        db.Orders.Add(order);
                        db.SaveChanges();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Номер заказа"].Value);
                try
                {
                    using (Context db = new())
                    {
                        Order order = db.Orders.Single(o => o.Id == id);
                        OrderForm orderForm = new(order);
                        if (orderForm.ShowDialog() == DialogResult.OK)
                        {
                            db.SaveChanges();
                            LoadData();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Номер заказа"].Value);
                if (MessageBox.Show("Удалить выбранную запись?", "Подтвердите удаление!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using(Context db = new())
                        {
                            Order order = db.Orders.Single(o => o.Id == id);
                            db.Orders.Remove(order);
                            db.SaveChanges();
                            LoadData();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
    }
}
