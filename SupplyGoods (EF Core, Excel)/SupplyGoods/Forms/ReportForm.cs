using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using SupplyGoods.DataBase;
using SupplyGoods.Models;
using System.Data;

namespace SupplyGoods.Forms
{
    public partial class ReportForm : Form
    {
        List<Shipment> shipments = new();
        DataTable dataTable = new();
        public Client? Client { get; set; }
        public Product? Product { get; set; }
        public ReportForm(Client? client = null, Product? product = null)
        {
            InitializeComponent();
            Client = client;
            Product = product;
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                using (Context db = new())
                {
                    shipments = Client != null
                        ? db.Shipments.Include(s => s.Order.Product).Where(s => s.Order.ClientId == Client.Id).ToList()
                        : db.Shipments.Include(s => s.Order.Client).Where(s => s.Order.ProductId == Product!.Id).ToList();
                    dataTable.Columns.Add("Наименование");
                    dataTable.Columns.Add("Заказанное количество товара");
                    dataTable.Columns.Add("Фактически отгружено товара");
                    dataTable.Columns.Add("Отклонение");
                    foreach (Shipment shipment in shipments)
                    {
                        var property = Client != null ? shipment.Order.Product.Print : shipment.Order.Client.Print;
                        dataTable.Rows.Add(property,
                            shipment.Order.Quantity,
                            shipment.Quantity,
                            shipment.Order.Quantity - shipment.Quantity);
                    }
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Лист1");
                    worksheet.Cells[2, 2, 2, 5].Merge = true;
                    worksheet.SetValue(2, 2, this.Text);
                    worksheet.Cells[4, 2].LoadFromDataTable(dataTable, true);
                    worksheet.Cells[4, 2, dataTable.Rows.Count + 4, 5].AutoFitColumns();
                    worksheet.Cells[4, 2, dataTable.Rows.Count + 4, 5].Style.Border.Top.Style = ExcelBorderStyle.Thick;
                    worksheet.Cells[4, 2, dataTable.Rows.Count + 4, 5].Style.Border.Right.Style = ExcelBorderStyle.Thick;
                    worksheet.Cells[4, 2, dataTable.Rows.Count + 4, 5].Style.Border.Bottom.Style = ExcelBorderStyle.Thick;
                    worksheet.Cells[4, 2, dataTable.Rows.Count + 4, 5].Style.Border.Left.Style = ExcelBorderStyle.Thick;
                    worksheet.Cells[4, 3, dataTable.Rows.Count + 4, 5].Style.Numberformat.Format = "0.00";
                    worksheet.Cells[4, 3, dataTable.Rows.Count + 4, 5].Style.HorizontalAlignment = ExcelHorizontalAlignment.Right;
                    worksheet.Cells[4, 2, 4, 5].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    worksheet.Cells[4, 2, 4, 5].Style.Fill.BackgroundColor.SetColor(Color.Yellow);
                    saveFileDialog1.Filter = "Файл Excel|*.xlsx";
                    saveFileDialog1.FileName = "Отчёт.xlsx";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        package.SaveAs(new FileInfo(saveFileDialog1.FileName));
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
}
