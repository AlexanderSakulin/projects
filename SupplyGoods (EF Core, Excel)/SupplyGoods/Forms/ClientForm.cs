using SupplyGoods.Models;

namespace SupplyGoods.Forms
{
    public partial class ClientForm : Form
    {
        Client Client { get; set; }
        public ClientForm(Client client)
        {
            InitializeComponent();
            Client = client;
            FillField();
        }
        private void FillModel()
        {
            Client.Name = nameInput.Text;
            Client.Address = addressInput.Text;
            Client.Phone = phoneInput.Text;
        }
        private void FillField()
        {
            nameInput.Text = Client.Name;
            addressInput.Text = Client.Address;
            phoneInput.Text = Client.Phone;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text) ||
                string.IsNullOrWhiteSpace(addressInput.Text) ||
                string.IsNullOrWhiteSpace(phoneInput.Text))
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

        private void nameInput_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void addressInput_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void phoneInput_TextChanged(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }
    }
}
