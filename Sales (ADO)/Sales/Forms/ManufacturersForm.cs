using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;
using Sales.Models;

namespace Sales.Forms
{
    public partial class ManufacturersForm : Form
    {
        public ManufacturersForm()
        {
            InitializeComponent();
            ReadFromDb();
        }
        private void ReadFromDb()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = "SELECT id, name FROM manufacturer";
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
            catch (SqliteException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Manufacturer manufacturer = new Manufacturer();
            ManufacturerForm manufacturerForm = new ManufacturerForm(manufacturer);
            manufacturerForm.Text = "Добавление нового производителя";
            if (manufacturerForm.ShowDialog() == DialogResult.OK)
            {
                if (manufacturer.IsValid)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"INSERT INTO manufacturer (name) VALUES ('{manufacturer.Name}')";
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
                            MessageBox.Show("Такой производитель уже существует!");
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
                Manufacturer manufacturer = new Manufacturer();
                manufacturer.ID = id;
                manufacturer.Name = name;
                ManufacturerForm manufacturerForm = new ManufacturerForm(manufacturer);
                manufacturerForm.Text = "Изменение производителя";
                if (manufacturerForm.ShowDialog() == DialogResult.OK)
                {
                    if (manufacturer.IsValid)
                    {
                        using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                        string sqliteCommand = $"UPDATE manufacturer SET name = '{manufacturer.Name}' WHERE id = '{manufacturer.ID}'";
                        SqliteCommand command = new SqliteCommand(sqliteCommand, connection);
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
                                MessageBox.Show("Такой производитель уже существует!");
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
                if (MessageBox.Show("Удалить выбранного производителя", "Подтвердите удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"DELETE FROM manufacturer WHERE id = {id}";
                    SqliteCommand command = new SqliteCommand(selectCommand, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ReadFromDb();
                    }
                    catch(SqliteException ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
    }
}
