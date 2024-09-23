using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace DongHo
{
    public partial class KhoHang : Form
    {
        public KhoHang()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();
        private void KhoHang_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            string query = "SELECT * FROM KhoHang";
            DataSet ds = kn.Laydulieu(query);
            dataGridView_DanhSachSPtrongKho.DataSource = ds.Tables[0];
        }

        private void button_NhapHang_Click(object sender, EventArgs e)
        {
            NhapHang frm = new NhapHang();
            frm.ShowDialog();
            GetData();
        }

        private void button_Refesh_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void button_XuatExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Tạo tiêu đề cho các cột trong Excel
            for (int i = 0; i < dataGridView_DanhSachSPtrongKho.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView_DanhSachSPtrongKho.Columns[i].HeaderText;
            }

            // Đổ dữ liệu từ DataGridView vào Excel
            for (int i = 0; i < dataGridView_DanhSachSPtrongKho.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_DanhSachSPtrongKho.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView_DanhSachSPtrongKho.Rows[i].Cells[j].Value;
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

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một sản phẩm để xóa chưa
            if (dataGridView_DanhSachSPtrongKho.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa.");
                return;
            }

            // Lấy mã sản phẩm (masp) từ dòng đã chọn trong DataGridView
            string masp = dataGridView_DanhSachSPtrongKho.SelectedRows[0].Cells["masp"].Value.ToString();

            // Hiển thị hộp thoại xác nhận xóa sản phẩm
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận xóa sản phẩm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa sản phẩm khỏi cơ sở dữ liệu (bảng KhoHang)
                string deleteQuery = $"DELETE FROM KhoHang WHERE masp = '{masp}'";
                if (kn.Thucthi(deleteQuery))
                {
                    MessageBox.Show("Xóa sản phẩm thành công.");
                    GetData(); // Cập nhật lại danh sách sản phẩm sau khi xóa
                }
                else
                {
                    MessageBox.Show("Lỗi xóa sản phẩm.");
                }
            }
        }
    }
}
