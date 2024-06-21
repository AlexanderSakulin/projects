using SupplyGoods.DataBase;
using SupplyGoods.Models;
using System.Data;

namespace SupplyGoods.Forms
{
    public partial class ClientsForm : Form
    {
        public ClientsForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (Context db = new())
                {
                    var clients = db.Clients.OrderBy(c => c.Name).ToList();
                    DataTable dataTable = new();
                    dataTable.Columns.Add("Id");
                    dataTable.Columns.Add("Имя");
                    dataTable.Columns.Add("Адрес");
                    dataTable.Columns.Add("Телефон");
                    foreach (var client in clients)
                    {
                        dataTable.Rows.Add(client.Id, client.Name, client.Address, client.Phone);
                    }
                    dataGridView1.DataSource = dataTable;
                    dataGridView1.Columns["Id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Client client = new();
            ClientForm clientForm = new(client);
            clientForm.Text = "Добавить клиента!";
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (Context db = new())
                    {
                        db.Clients.Add(client);
                        db.SaveChanges();
                        LoadData();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                try
                {
                    using (Context db = new())
                    {
                        Client client = db.Clients.Single(c => c.Id == id);
                        ClientForm clientForm = new(client);
                        clientForm.Text = "Изменить клиента!";
                        if (clientForm.ShowDialog() == DialogResult.OK)
                        {
                            db.SaveChanges();
                            LoadData();
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);
                if (MessageBox.Show("Удалить выбранную запись?", "Подтвердить действие!",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        using(Context db = new())
                        {
                            Client client = db.Clients.Single(c => c.Id == id);
                            db.Clients.Remove(client);
                            db.SaveChanges();
                            LoadData();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
    }
}
