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
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            ReadFromDb();
        }
        private void ReadFromDb()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = "SELECT id, name, loyalty, birthday FROM client";
            SqliteCommand command = new SqliteCommand(selectCommand, connection);
            try
            {
                connection.Open();
                using SqliteDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id");
                dataTable.Columns.Add("Имя клиента");
                dataTable.Columns.Add("Номер карты");
                dataTable.Columns.Add("Дата рождения");
                while (reader.Read())
                {
                    string bDate = DateTime.Parse(reader["birthday"].ToString() ?? "").ToShortDateString(); // Не понял строку?
                    dataTable.Rows.Add(reader["id"], reader["name"], reader["loyalty"], bDate);
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
            Client client = new Client();
            ClientForm clientForm = new ClientForm(client);
            clientForm.Text = "Добавление клиента";
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                if (client.IsValid)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"INSERT INTO client (name, loyalty, birthday) VALUES ('{client.Name}', '{client.CardNo}', '{client.Birthday.ToString("yyyy-MM-dd")}')"; // вопрос?
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

                Client client = new Client();
                client.Id = id;
                client.Name = dataGridView1.SelectedRows[0].Cells["Имя клиента"].Value.ToString() ?? "";
                client.CardNo = dataGridView1.SelectedRows[0].Cells["Номер карты"].Value.ToString() ?? "";
                client.Birthday = DateTime.Parse(dataGridView1.SelectedRows[0].Cells["Дата рождения"].Value.ToString() ?? "");

                ClientForm clientForm = new ClientForm(client);
                clientForm.Text = "Изменение клиента";
                if (clientForm.ShowDialog() == DialogResult.OK)
                {
                    if (client.IsValid)
                    {
                        using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                        string updateCommand = $"UPDATE client SET name = '{client.Name}', loyalty = '{client.CardNo}', birthday = '{client.Birthday.ToString("yyyy-MM-dd")}' WHERE id = {client.Id}";
                        SqliteCommand command = new SqliteCommand(updateCommand, connection);
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

                if (MessageBox.Show("Удалить выбранного клиента?", "Подтвердите удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string deleteCommand = $"DELETE FROM client WHERE id = {id}";
                    SqliteCommand command = new SqliteCommand(deleteCommand, connection);
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
