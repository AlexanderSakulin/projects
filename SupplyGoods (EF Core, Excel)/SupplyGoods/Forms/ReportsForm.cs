using Microsoft.EntityFrameworkCore;
using SupplyGoods.DataBase;
using SupplyGoods.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SupplyGoods.Forms
{
    public partial class ReportsForm : Form
    {
        List<Client> clients = new();
        List<Product> products = new();
        public ReportsForm()
        {
            InitializeComponent();
            LoadData();
            radioButtonClients.Checked = true;
        }
        private void LoadData()
        {
            try
            {
                using (Context db = new())
                {
                    clients = db.Clients.OrderBy(c => c.Name).ToList();
                    products = db.Products.OrderBy(p => p.Name).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void radioButtonClients_CheckedChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            try
            {
                listBox1.ValueMember = "Id";
                listBox1.DisplayMember = "Print";
                listBox1.DataSource = radioButtonClients.Checked ? clients : products;
                listName.Text = radioButtonClients.Checked ? "Заказчики" : "Товары";
                inputSearch.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void inputSearch_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            string line = inputSearch.Text.ToLower();
            object filterList = radioButtonClients.Checked
                ? clients.Where(c => c.Print.ToLower().Contains(line)).OrderBy(c => c.Name).ToList()
                : products.Where(p => p.Print.ToLower().Contains(line)).OrderBy(p => p.Name).ToList();
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "Print";
            listBox1.DataSource = filterList;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                errorLabel.Text = radioButtonClients.Checked ? "Выберите заказчика из списка!" : "Выберите товар из списка!";
                errorLabel.Visible = true;
            }
            else
            {
                int id = Convert.ToInt32(listBox1.SelectedValue);
                try
                {
                    using (Context db = new())
                    {
                        if (radioButtonClients.Checked)
                        {
                            if (db.Shipments.Include(s => s.Order).Select(s => s.Order.ClientId).Contains(id))
                            {
                                Client client = new();
                                client = clients.Single(s => s.Id == id);
                                ReportForm reportForm = new(client, null);
                                reportForm.Text = $"Отчёт по заказчику {client.Print}";
                                reportForm.Show();
                            }
                            else
                            {
                                MessageBox.Show("Выбранному заказчику товар не отгружался");
                            }

                        }
                        else
                        {
                            if (db.Shipments.Include(s => s.Order).Select(s => s.Order.ProductId).Contains(id))
                            {
                                Product product = new();
                                product = products.Single(p => p.Id == id);
                                ReportForm reportForm = new(null, product);
                                reportForm.Text = $"Отчёт по товару {product.Print}";
                                reportForm.Show();

                            }
                            else
                            {
                                MessageBox.Show("Выбранный товар не отгружался");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
