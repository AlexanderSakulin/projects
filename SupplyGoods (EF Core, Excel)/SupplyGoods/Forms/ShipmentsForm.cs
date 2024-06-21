using Microsoft.EntityFrameworkCore;
using SupplyGoods.DataBase;
using SupplyGoods.Models;
using System.Data;

namespace SupplyGoods.Forms
{
    public partial class ShipmentsForm : Form
    {
        public ShipmentsForm()
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
                    List<Shipment> shipments = db.Shipments
                        .Include(s => s.Order)
                        .Include(s => s.Order.Client)
                        .Include(s => s.Order.Product)
                        .OrderBy(s => s.DateTime)
                        .ToList();
                    DataTable dataTable = new();
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Дата отгрузки");
                    dataTable.Columns.Add("Номер заказа");
                    dataTable.Columns.Add("Заказчик");
                    dataTable.Columns.Add("Наименование товара");
                    dataTable.Columns.Add("Количество");
                    foreach (Shipment shipment in shipments)
                    {
                        dataTable.Rows.Add(
                            shipment.Id,
                            shipment.DateTime,
                            shipment.Order.Id,
                            shipment.Order.Client.Name,
                            shipment.Order.Product.Name,
                            shipment.Quantity);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["Id"].Visible = false;
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
            Shipment shipment = new();
            ShipmentForm shipmentForm = new(shipment);
            shipmentForm.Text = "Оформить отгрузку";
            if (shipmentForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Context db = new())
                    {
                        db.Shipments.Add(shipment);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                if(MessageBox.Show("Удалить выбранную запись?", "Подтвердите удаление!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using(Context db = new())
                        {
                            Shipment shipment = db.Shipments.Single(s => s.Id == id);
                            db.Shipments.Remove(shipment);
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
