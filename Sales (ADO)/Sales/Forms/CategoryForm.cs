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
    public partial class CategoryForm : Form
    {
        public Category Category { get; set; }
        public CategoryForm(Category category)
        {
            InitializeComponent();
            Category = category;
            FillField();
        }
        private void FillModel()
        {
            Category.Name = nameInput.Text;
        }
        private void FillField()
        {
            nameInput.Text = Category.Name;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameInput.Text))
            {
                errorLabel.Text = "Заполните это поле!";
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
