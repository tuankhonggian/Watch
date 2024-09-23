using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace DongHo
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void ThongKe_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            string query1 = "SELECT * FROM ChiTietHD";
            DataSet ds1 = kn.Laydulieu(query1);
            dataGridView_dsdh.DataSource = ds1.Tables[0];
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string maHDToSearch = textBox_TimKiem.Text.Trim();

            if (string.IsNullOrEmpty(maHDToSearch))
            {
                MessageBox.Show("Vui lòng nhập Mã đơn hàng để tìm kiếm.");
                return;
            }

            // Query to search for products by MaSP
            string searchQuery = $"SELECT * FROM ChiTietHD WHERE MaHD = '{maHDToSearch}'";

            DataSet ds = kn.Laydulieu(searchQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Display the search results in the DataGridView
                dataGridView_dsdh.DataSource = ds.Tables[0];
            }
            else
            {
                // No matching records found
                MessageBox.Show("Không tìm thấy sản phẩm với Mã Sản Phẩm này.");
                dataGridView_dsdh.DataSource = null; // Clear the DataGridView
            }
        }

        private void button_XuatExcel_Click(object sender, EventArgs e)
        {
            
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Tạo tiêu đề cho các cột trong Excel
            for (int i = 0; i < dataGridView_dsdh.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView_dsdh.Columns[i].HeaderText;
            }

            // Đổ dữ liệu từ DataGridView vào Excel
            for (int i = 0; i < dataGridView_dsdh.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_dsdh.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView_dsdh.Rows[i].Cells[j].Value;
                }
            }

            // Lưu tệp Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Lưu dữ liệu Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Close();
                excelApp.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);

                MessageBox.Show("Xuất Excel thành công!");
            }
            else
            {
                workbook.Close();
                excelApp.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }

        private void button_XemChiTietDonHang_Click(object sender, EventArgs e)
        {
            ChiTietHD frm = new ChiTietHD();
            frm.ShowDialog();
        }
    }
}
