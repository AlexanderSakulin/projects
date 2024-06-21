namespace CarService
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientsForm form= new ClientsForm();
            form.Show();
        }
    }
}