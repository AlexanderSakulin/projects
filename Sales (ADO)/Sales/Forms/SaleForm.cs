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
    public partial class SaleForm : Form
    {
        private class IdValue
        {
            public int Id { get; set; }
            public string? Value { get; set; }
        }


        //public Sale Sale { get; set; }

        /*
        public SaleForm(Sale sale)
        {
            InitializeComponent();
            Sale = sale;
            LoadComboBox();
            FillField();
        }
        */

        public SaleForm()
        {
            InitializeComponent();
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
            string selectProductsCommand = "SELECT id, name FROM product ORDER BY name";
            string selectEmployeesCommand = "SELECT id, surname FROM employee ORDER BY surname";
            string selectClientsCommand = "SELECT id, name || \" \" || loyalty AS cl FROM client ORDER BY cl";
            try
            {
                connection.Open();
                using (SqliteCommand command = new SqliteCommand(selectProductsCommand, connection))
                {
                    SqliteDataReader reader = command.ExecuteReader();
                    List<IdValue> products = new List<IdValue>();
                    while (reader.Read())
                    {
                        IdValue idValue = new() { Id = Convert.ToInt32(reader["id"]), Value = reader["name"].ToString() ?? "<NULL>" };
                        products.Add(idValue);
                    }
                    productsList.DataSource = products;
                    productsList.ValueMember= "Id";
                    productsList.DisplayMember= "Value";
                }
                using (SqliteCommand command = new SqliteCommand(selectEmployeesCommand, connection))
                {
                    SqliteDataReader reader = command.ExecuteReader();
                    List<IdValue> enployees = new List<IdValue>();
                    while (reader.Read())
                    {
                        IdValue idValue = new() { Id = Convert.ToInt32(reader["id"]), Value = reader["surname"].ToString() ?? "<NULL>" };
                        enployees.Add(idValue);
                    }
                    employeesList.DataSource = enployees;
                    employeesList.ValueMember = "Id";
                    employeesList.DisplayMember = "Value";
                }
                using (SqliteCommand command = new SqliteCommand(selectClientsCommand, connection))
                {
                    SqliteDataReader reader = command.ExecuteReader();
                    List<IdValue> clients = new List<IdValue>();
                    clients.Add(new() { Id = 0, Value = "Гость" });
                    while (reader.Read())
                    {
                        IdValue idValue = new() { Id = Convert.ToInt32(reader["id"]), Value = reader["cl"].ToString() ?? "<NULL>" };
                        clients.Add(idValue);
                    }
                    clientsList.DataSource = clients;
                    clientsList.ValueMember = "Id";
                    clientsList.DisplayMember = "Value";
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

        }
        private void FillField()
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void productsList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (productsList.SelectedValue.GetType() == typeof(int)) 
            {
                int id = (int)productsList.SelectedValue;
                using SqliteConnection connection = new SqliteConnection(Settings.ConnectionString);
                string selectCommand = $"SELECT price FROM product WHERE id = {id}";
                try
                {
                    connection.Open();
                    using (SqliteCommand command = new SqliteCommand(selectCommand, connection))
                    {
                        string price = command.ExecuteScalar()?.ToString() ?? "";
                        priceInput.Text = price;
                        CalcSum();
                    }
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void CalcSum()
        {
            if (int.TryParse(priceInput.Text, out int price))
            {
                sumInput.Text = (price * countInput.Value).ToString();
            }
        }

        private void countInput_ValueChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
    }
}
