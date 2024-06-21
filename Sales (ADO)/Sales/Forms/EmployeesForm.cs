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
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
            ReadFromDb();
        }
        private void ReadFromDb()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = @"SELECT e.id, e.surname || ' ' || e.name || ' ' || e.patronymic AS empName, p.name AS posName
                                       FROM employee e
                                       JOIN position p ON p.id = e.id_position
                                       ORDER BY empName";
            SqliteCommand command = new SqliteCommand(selectCommand, connection);
            try
            {
                connection.Open();
                using SqliteDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id");
                dataTable.Columns.Add("ФИО сотрудника");
                dataTable.Columns.Add("Должность");
                while (reader.Read())
                {
                    dataTable.Rows.Add(reader["id"], reader["empName"], reader["posName"]);
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
            Employee employee = new Employee();
            EmployeeForm employeeForm = new EmployeeForm(employee);
            employeeForm.Text = "Добавление нового сотрудника";
            if (employeeForm.ShowDialog() == DialogResult.OK)
            {
                if (employee.IsValid)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"INSERT INTO employee (name, surname, patronymic, id_position) VALUES ('{employee.Name}', '{employee.Surname}', '{employee.Patronymic}', {employee.IdPosition})";
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
                Employee employee = new Employee();
                using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                string selectCommand = $"SELECT id, name, surname, patronymic, id_position FROM employee WHERE id = {id}";
                SqliteCommand command = new SqliteCommand(selectCommand, connection);
                try
                {
                    connection.Open();
                    using SqliteDataReader reader = command.ExecuteReader();
                    if (reader.HasRows) // спросить зачем нузна проверка???
                    {
                        reader.Read();
                        employee.Id = id;
                        employee.Name = reader["name"].ToString() ?? "<NULL>";
                        employee.Surname = reader["surname"].ToString() ?? "<NULL>";
                        employee.Patronymic = reader["patronymic"].ToString() ?? "<NULL>";
                        employee.IdPosition = Convert.ToInt32(reader["id_position"]);
                    }
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                EmployeeForm employeeForm = new EmployeeForm(employee);
                employeeForm.Text = "Изменение данных сотрудника";
                if (employeeForm.ShowDialog() == DialogResult.OK)
                {
                    if (employee.IsValid)
                    {
                        string selectUpdate = $"UPDATE employee SET name = '{employee.Name}', surname = '{employee.Surname}', patronymic = '{employee.Patronymic}', id_position = {employee.IdPosition} WHERE id = {employee.Id}";
                        SqliteCommand update = new SqliteCommand(selectUpdate, connection);
                        try
                        {
                            connection.Open();
                            update.ExecuteNonQuery();
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
                if (MessageBox.Show("Удалить выбранную запись?", "Подтвердите удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                    string selectCommand = $"DELETE FROM employee WHERE id = {id}";
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
