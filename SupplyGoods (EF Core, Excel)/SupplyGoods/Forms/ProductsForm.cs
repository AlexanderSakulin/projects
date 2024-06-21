using SupplyGoods.DataBase;
using SupplyGoods.Models;
using System.Data;

namespace SupplyGoods.Forms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
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
                    //var product1 = db.Orders.Select(o => o.ProductId);
                    //var products = db.Products.Where(p => !product1.Contains(p.Id)).OrderBy(p => p.Name).ToList();
                    var products = db.Products.OrderBy(p => p.Name).ToList();
                    DataTable dataTable = new();
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Наименование");
                    dataTable.Columns.Add("Цена");
                    foreach (var product in products)
                    {
                        dataTable.Rows.Add(product.Id, product.Name, product.Price.ToString("0 руб. 00 коп"));
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
            Product product = new();
            ProductForm productForm = new(product);
            productForm.Text = "Добавить товар!";
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Context db = new())
                    {
                        db.Products.Add(product);
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
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                try
                {
                    using (Context db = new())
                    {
                        Product product = db.Products.Single(p => p.Id == id);
                        ProductForm productForm = new(product);
                        productForm.Text = "Изменить товар!";
                        if (productForm.ShowDialog() == DialogResult.OK)
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
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                if (MessageBox.Show("Удалить выбранную запись?", "Подтвердите удаление!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using (Context db = new())
                        {
                            Product product = db.Products.Single(p => p.Id == id);
                            db.Products.Remove(product);
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
        }

    }
}
