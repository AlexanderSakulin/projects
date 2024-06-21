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
    public partial class PositionForm : Form
    {
        public Position Position { get; set; }
        public PositionForm(Position position)
        {
            InitializeComponent();
            Position = position;
            FillField();
        }
        private void FillModel()
        {
            Position.Name = nameInput.Text; 
        }
        private void FillField()
        {
            nameInput.Text = Position.Name;
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
