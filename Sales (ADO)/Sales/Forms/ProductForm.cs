using Sales.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace Sales.Forms
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm(Product product)
        {
            InitializeComponent();
            Product = product;
            LoadComboBox();
            FillField();
        }
        private void LoadComboBox()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = "SELECT id, name FROM category ORDER BY name";
            SqliteCommand command = new SqliteCommand(selectCommand, connection);
            try
            {
                connection.Open();
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    List<Category> categories = new List<Category>();
                    while (reader.Read())
                    {
                        Category category = new Category();
                        category.ID = Convert.ToInt32(reader["id"]);
                        category.Name = reader["name"].ToString() ?? "";
                        categories.Add(category);
                    }
                    categoryInput.DataSource = categories;
                    categoryInput.ValueMember = "id";
                    categoryInput.DisplayMember = "name";
                }
                
                selectCommand = "SELECT id, name FROM manufacturer ORDER BY name";
                command.CommandText = selectCommand;
                using (SqliteDataReader reader = command.ExecuteReader())
                {
                    List<Manufacturer> manufacturers = new List<Manufacturer>();
                    while (reader.Read())
                    {
                        Manufacturer manufacturer = new Manufacturer();
                        manufacturer.ID = Convert.ToInt32(reader["id"]);
                        manufacturer.Name = reader["name"].ToString() ?? "";
                        manufacturers.Add(manufacturer);
                    }
                    manufacturerInput.DataSource = manufacturers;
                    manufacturerInput.ValueMember = "id";
                    manufacturerInput.DisplayMember = "name";
                }
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void FillModel()
        {
            Product.Name = nameInput.Text;
            Product.VendorCode = vendorСodeInput.Text;
            Product.Price = priceInput.Text;
            Product.IdCategory = Convert.ToInt32(categoryInput.SelectedValue);
            Product.IdManufacturer = Convert.ToInt32(manufacturerInput.SelectedValue);
        }
        private void FillField()
        {
            nameInput.Text = Product.Name;
            vendorСodeInput.Text = Product.VendorCode;
            priceInput.Text = Product.Price;
            categoryInput.SelectedValue = Product.IdCategory;
            manufacturerInput.SelectedValue = Product.IdManufacturer;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text) ||
                string.IsNullOrWhiteSpace(vendorСodeInput.Text) ||
                string.IsNullOrWhiteSpace(priceInput.Text) ||
                categoryInput.SelectedValue == null ||
                manufacturerInput.SelectedValue == null)
            {
                errorLabel.Text = "Заполните все поля!";
                errorLabel.Visible = true;
            }
            else
            {
                FillModel();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
