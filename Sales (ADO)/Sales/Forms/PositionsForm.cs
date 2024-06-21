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
    public partial class PositionsForm : Form
    {
        public PositionsForm()
        {
            InitializeComponent();
            ReadFromDb();
        }
        private void ReadFromDb()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = "SELECT id, name FROM position";
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
            Position position = new Position();
            PositionForm positionForm = new PositionForm(position);
            positionForm.Text = "Добавление новой должности";
            if (positionForm.ShowDialog() == DialogResult.OK)
            {
                if (position.IsValid)
                {
                    SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"INSERT INTO position (name) VALUES ('{position.Name}')";
                    SqliteCommand command = new SqliteCommand(selectCommand, connection);
                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        ReadFromDb();
                    }
                    catch(SqliteException ex)
                    {
                        if (ex.Message.Contains("UNIQUE"))
                        {
                            MessageBox.Show("Такая должность уже существует!");
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
                Position position = new Position();
                position.Id = id;
                position.Name = name;
                PositionForm positionForm = new PositionForm(position);
                positionForm.Text = "Изменение должности";
                if (positionForm.ShowDialog() == DialogResult.OK)
                {
                    if (position.IsValid)
                    {
                        using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                        string selectCommand = $"UPDATE position SET name = '{position.Name}' WHERE id = '{position.Id}'";
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
                                MessageBox.Show("Такая должность уже существует!");
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
                if (MessageBox.Show("Удалить выбранную запись", "Подтвердите удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"DELETE FROM position WHERE id = {id}";
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
