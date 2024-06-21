using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Sales.Models;

namespace Sales.Forms
{
    public partial class ProductsForm : Form
    {
        public ProductsForm()
        {
            InitializeComponent();
            ReadFromDb();
        }
        private void ReadFromDb()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = @"SELECT p.id, p.name AS prodName, p.vendor_code, p.price, c.name AS catName, m.name AS manName
                                     FROM product p
                                     JOIN category c ON c.id = p.id_category
                                     JOIN manufacturer m ON m.id = p.id_manufacturer
                                     ORDER BY p.name";
            SqliteCommand command = new SqliteCommand(selectCommand, connection);
            try
            {
                connection.Open();
                SqliteDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id");
                dataTable.Columns.Add("Наименование товара");
                dataTable.Columns.Add("Артикул");
                dataTable.Columns.Add("Цена");
                dataTable.Columns.Add("Категория");
                dataTable.Columns.Add("Производитель");
                while (reader.Read())
                {
                    dataTable.Rows.Add(reader["id"], reader["prodName"], reader["vendor_code"], reader["price"], reader["catName"], reader["manName"]);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            ProductForm productForm = new ProductForm(product);
            productForm.Text = "Добавление товара";
            if (productForm.ShowDialog() == DialogResult.OK)
            {
                if (product.IsValid)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"INSERT INTO product (name, vendor_code, price, id_category, id_manufacturer) VALUES ('{product.Name}', '{product.VendorCode}', '{product.Price}', {product.IdCategory}, {product.IdManufacturer})";
                    SqliteCommand command = new SqliteCommand(selectCommand, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ReadFromDb();
                    }
                    catch (SqliteException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                Product product = new Product();
                using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                string selectCommand = $"SELECT name, vendor_code, price, id_category, id_manufacturer FROM product WHERE id = {id}";
                SqliteCommand command = new SqliteCommand(selectCommand, connection);
                try
                {
                    connection.Open();
                    using SqliteDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        product.Id = id;
                        product.Name = reader["name"].ToString() ?? "";
                        product.VendorCode = reader["vendor_code"].ToString() ?? "";
                        product.Price = reader["price"].ToString() ?? "";
                        product.IdCategory = Convert.ToInt32(reader["id_category"]);
                        product.IdManufacturer = Convert.ToInt32(reader["id_manufacturer"]);

                    }
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                ProductForm productForm = new ProductForm(product);
                productForm.Text = "Изменние товара";
                if (productForm.ShowDialog() == DialogResult.OK)
                {
                    if (product.IsValid)
                    {
                        selectCommand = $"UPDATE product SET name = '{product.Name}', vendor_code = '{product.VendorCode}', price = '{product.Price}', id_category = {product.IdCategory}, id_manufacturer = {product.IdManufacturer} WHERE id = {product.Id}";
                        command.CommandText = selectCommand;
                        try
                        {
                            //connection.Open();
                            command.ExecuteNonQuery();
                            ReadFromDb();
                        }
                        catch (SqliteException ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }

                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                if (MessageBox.Show("Удалить выбранную запись", "Подтвердите удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"DELETE FROM product WHERE id = {id}";
                    SqliteCommand command = new SqliteCommand(selectCommand, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ReadFromDb();
                    }
                    catch (SqliteException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
    }
}
