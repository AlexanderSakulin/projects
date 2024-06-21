using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupplyGoods.Models;

namespace SupplyGoods.Forms
{
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public ProductForm(Product product)
        {
            InitializeComponent();
            Product = product;
            FillField();
        }
        private void FillModel()
        {
            Product.Name = nameInput.Text;
            Product.Price = Convert.ToDouble(priceInput.Value);
        }
        private void FillField()
        {
            nameInput.Text = Product.Name;
            priceInput.Value = Convert.ToDecimal(Product.Price);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                errorLabel.Text = "Введите наименование товара!";
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
    }
}
