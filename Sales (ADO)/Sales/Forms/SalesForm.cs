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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
            ReadFromDb();
        }
        private void ReadFromDb()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = @"SELECT s.id, s.date, s.time, p.name AS prod, s.product_price, s.quantity, s.product_price * s.quantity AS sum, e.surname AS emp, c.name AS cl
                                       FROM sale s
                                       JOIN product p ON p.id = s.id_product
                                       JOIN employee e ON e.id = s.id_employee
                                       LEFT JOIN client c ON c.id = s.id_client
                                       ORDER BY s.date DESC, s.time DESC";
            SqliteCommand command = new SqliteCommand(selectCommand, connection);
            try
            {
                connection.Open();
                using SqliteDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id");
                dataTable.Columns.Add("Дата");
                dataTable.Columns.Add("Время");
                dataTable.Columns.Add("Товар");
                dataTable.Columns.Add("Цена");
                dataTable.Columns.Add("Количество");
                dataTable.Columns.Add("Стоимость");
                dataTable.Columns.Add("Продавец");
                dataTable.Columns.Add("Клиент");
                while (reader.Read())
                {
                    dataTable.Rows.Add(
                        reader["id"],
                        reader["date"],
                        reader["time"],
                        reader["prod"],
                        reader["product_price"],
                        reader["quantity"],
                        reader["sum"],
                        reader["emp"],
                        reader["cl"]
                        );
                }
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
            SaleForm saleForm = new SaleForm();
            saleForm.ShowDialog();
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
                if (MessageBox.Show("Удалить выбранную запись?", "Подтвердите удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"DELETE FROM sale WHERE id = {id}";
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
