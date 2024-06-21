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
    public partial class EmployeeForm : Form
    {
        public Employee Employee { get; set; }
        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            Employee = employee;
            LoadComboBox();
            FillField();
        }
        private void LoadComboBox()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectCommand = "SELECT id, name FROM position ORDER BY name";
            SqliteCommand command = new SqliteCommand(selectCommand, connection);
            try
            {
                connection.Open();
                SqliteDataReader reader = command.ExecuteReader();
                List<Position> positions = new List<Position>();
                while (reader.Read())
                {
                    Position position = new Position();
                    position.Id = Convert.ToInt32(reader["id"]);
                    position.Name = reader["name"].ToString() ?? "<NULL>";
                    positions.Add(position);
                }
                positionsInput.DataSource = positions;
                positionsInput.ValueMember = "id"; // является значением свойство position.Id , именно само свойство, а не значение этого свойства
                positionsInput.DisplayMember = "name"; // что отображается пользователю в форме
            }
            catch (SqliteException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        private void FillModel()
        {
            Employee.Surname = surnameInput.Text;
            Employee.Name = nameInput.Text;
            Employee.Patronymic = patronymicInput.Text;
            Employee.IdPosition = Convert.ToInt32(positionsInput.SelectedValue);
        }
        private void FillField()
        {
            surnameInput.Text = Employee.Surname;
            nameInput.Text = Employee.Name;
            patronymicInput.Text = Employee.Patronymic;
            positionsInput.SelectedValue = Employee.IdPosition;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(surnameInput.Text) ||
                string.IsNullOrWhiteSpace(nameInput.Text) ||
                string.IsNullOrWhiteSpace(patronymicInput.Text) ||
                positionsInput.SelectedValue == null)
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
