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
using Sales.Models;

namespace Sales.Forms
{
    public partial class CategoriesForm : Form
    {
        public CategoriesForm()
        {
            InitializeComponent();
            ReadFromDb(); // Вызываем метод в конструкторе
        }
        private void ReadFromDb()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = "SELECT id, name FROM category";
            SqliteCommand command = new SqliteCommand(selectCommand, connection);
            try
            {
                connection.Open();
                using SqliteDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataTable.Columns[0].ColumnName = "id";
                dataTable.Columns[1].ColumnName = "Название";
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["id"].Visible = false;
            }
            catch(SqliteException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            CategoryForm categoryForm = new CategoryForm(category);
            categoryForm.Text = "Добавление новой категории";
            if(categoryForm.ShowDialog() == DialogResult.OK)
            {
                if (category.IsValid)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"INSERT INTO category (name) VALUES ('{category.Name}')";
                    SqliteCommand command = new SqliteCommand(selectCommand, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ReadFromDb();
                    }
                    catch (SqliteException ex)
                    {
                        if (ex.Message.Contains("UNIQUE"))
                        {
                            MessageBox.Show("Такая категория уже существует!");
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);
                        }
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
                string name = dataGridView1.SelectedRows[0].Cells["Название"].Value.ToString() ?? "";
                Category category = new Category();
                category.ID = id;
                category.Name = name;
                CategoryForm categoryForm = new CategoryForm(category);
                categoryForm.Text = "Изменение категории";
                if (categoryForm.ShowDialog() == DialogResult.OK)
                {
                    if (category.IsValid)
                    {
                        using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                        string selectCommand = $"UPDATE category SET name = '{category.Name}' WHERE id = '{category.ID}'";
                        SqliteCommand command = new SqliteCommand(selectCommand, connection);
                        try
                        {
                            connection.Open();
                            command.ExecuteNonQuery();
                            ReadFromDb();
                        }
                        catch (SqliteException ex)
                        {
                            if (ex.Message.Contains("UNIQUE"))
                            {
                                MessageBox.Show("Такая категория уже существует!");
                            }
                            else
                            {
                                MessageBox.Show(ex.Message);
                            }
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
                if (MessageBox.Show("Удалить выбранную категорию", "Подтвердите удаление", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string sqliteCommand = $"DELETE FROM category WHERE id = {id}";
                    SqliteCommand command = new SqliteCommand(sqliteCommand, connection);
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
