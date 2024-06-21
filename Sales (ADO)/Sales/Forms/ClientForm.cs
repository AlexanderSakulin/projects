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

namespace Sales.Forms
{
    public partial class ClientForm : Form
    {
        public Client Client { get; set; }
        public ClientForm(Client client)
        {
            InitializeComponent();
            birthdayInput.MaxDate = DateTime.Now;
            Client = client;
            FillField();
        }
        private void FillModel()
        {
            Client.Name = nameInput.Text;
            Client.CardNo = cardNoInput.Text;
            Client.Birthday = birthdayInput.Value;
        }
        private void FillField()
        {
            nameInput.Text = Client.Name;
            cardNoInput.Text = Client.CardNo;
            try // зачем "try"? почему "catch" пустой?
            {
                birthdayInput.Value = Client.Birthday; 
            }
            catch { }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text) ||
                string.IsNullOrWhiteSpace(cardNoInput.Text))
            {
                errorLabel.Text = "Заполните все поля!";
                errorLabel.Visible = true;
            }
            else
            {
                DialogResult = DialogResult.OK;
                FillModel();
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
