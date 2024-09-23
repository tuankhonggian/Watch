using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


namespace DongHo
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            string query = "SELECT * FROM NhaCungCap";
            DataSet ds = kn.Laydulieu(query);
            dataGridView_DanhSachNhaCungCap.DataSource = ds.Tables[0];
        }
        private void Clear()
        {
            textBox_MaNCC.Enabled = true;
            button_Them.Enabled = true;
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
            textBox_MaNCC.Text = "";
            textBox_TenNCC.Text = "";
            textBox_SDT.Text = "";
            textBox_Email.Text = "";

        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
            GetData();
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            // Thu thập thông tin từ các TextBox
            string maNCC = textBox_MaNCC.Text.Trim();
            string tenNCC = textBox_TenNCC.Text.Trim();
            string sdt = textBox_SDT.Text.Trim();
            string email = textBox_Email.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maNCC) || string.IsNullOrEmpty(tenNCC) ||
                string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhà cung cấp.");
                return;
            }

            // Kiểm tra MaNCC, SDT và Email không trùng với dữ liệu đã tồn tại
            string checkQuery = $"SELECT COUNT(*) FROM NhaCungCap WHERE MaNCC = '{maNCC}' OR SDT = '{sdt}' OR Email = '{email}'";
            int existingCount = Convert.ToInt32(kn.Laydulieu(checkQuery).Tables[0].Rows[0][0]);

            if (existingCount > 0)
            {
                MessageBox.Show("Mã NCC, SDT hoặc Email đã tồn tại. Vui lòng kiểm tra lại.");
                return;
            }

            // Kiểm tra định dạng SDT (số điện thoại)
            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("SDT phải có đúng 10 chữ số.");
                return;
            }

            // Kiểm tra định dạng Email
            if (!email.EndsWith("@gmail.com") && !email.EndsWith("@gmail.com.vn"))
            {
                MessageBox.Show("Email phải kết thúc bằng '@gmail.com' hoặc '@gmail.com.vn'.");
                return;
            }

            // Xây dựng câu lệnh SQL INSERT
            string insertQuery = $"INSERT INTO NhaCungCap (MaNCC, TenNCC, SDT, Email) " +
                                 $"VALUES ('{maNCC}', '{tenNCC}', '{sdt}', '{email}')";

            // Thực hiện câu lệnh SQL INSERT
            if (kn.Thucthi(insertQuery))
            {
                MessageBox.Show("Thêm nhà cung cấp thành công.");
                Clear(); // Xóa dữ liệu trên các TextBox
                GetData(); // Cập nhật DataGridView với dữ liệu mới
            }
            else
            {
                MessageBox.Show("Thêm nhà cung cấp không thành công. Hãy kiểm tra lại dữ liệu.");
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string maNCC = textBox_MaNCC.Text.Trim();
            string tenNCC = textBox_TenNCC.Text.Trim();
            string sdt = textBox_SDT.Text.Trim();
            string email = textBox_Email.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maNCC) || string.IsNullOrEmpty(tenNCC) ||
                string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhà cung cấp.");
                return;
            }

            // Kiểm tra SDT và Email không trùng với dữ liệu đã tồn tại (trừ bản ghi của nhà cung cấp đang được chỉnh sửa)
            string checkQuery = $"SELECT COUNT(*) FROM NhaCungCap WHERE (SDT = '{sdt}' OR Email = '{email}') AND MaNCC != '{maNCC}'";
            int existingCount = Convert.ToInt32(kn.Laydulieu(checkQuery).Tables[0].Rows[0][0]);

            if (existingCount > 0)
            {
                MessageBox.Show("SDT hoặc Email đã tồn tại cho một nhà cung cấp khác. Vui lòng kiểm tra lại.");
                return;
            }

            // Kiểm tra định dạng SDT (số điện thoại)
            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("SDT phải có đúng 10 chữ số.");
                return;
            }

            // Kiểm tra định dạng Email
            if (!email.EndsWith("@gmail.com") && !email.EndsWith("@gmail.com.vn"))
            {
                MessageBox.Show("Email phải kết thúc bằng '@gmail.com' hoặc '@gmail.com.vn'.");
                return;
            }

            // Xây dựng câu lệnh SQL UPDATE
            string updateQuery = $"UPDATE NhaCungCap SET TenNCC = '{tenNCC}', SDT = '{sdt}', Email = '{email}' WHERE MaNCC = '{maNCC}'";

            // Thực hiện câu lệnh SQL UPDATE
            if (kn.Thucthi(updateQuery))
            {
                MessageBox.Show("Sửa thông tin nhà cung cấp thành công.");
                Clear(); // Xóa dữ liệu trên các TextBox
                GetData(); // Cập nhật DataGridView với dữ liệu mới
            }
            else
            {
                MessageBox.Show("Sửa thông tin nhà cung cấp không thành công. Hãy kiểm tra lại dữ liệu.");
            }
        }


        private void button_Xoa_Click(object sender, EventArgs e)
        {
            // Lấy mã nhà cung cấp cần xóa từ TextBox
            string maNCC = textBox_MaNCC.Text.Trim();

            // Kiểm tra xem mã nhà cung cấp có được nhập vào không
            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show("Vui lòng nhập mã nhà cung cấp cần xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận xóa",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Xây dựng câu lệnh SQL DELETE
                string deleteQuery = $"DELETE FROM NhaCungCap WHERE MaNCC = '{maNCC}'";

                // Thực hiện câu lệnh SQL DELETE
                if (kn.Thucthi(deleteQuery))
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công.");
                    Clear(); // Xóa dữ liệu trên các TextBox
                    GetData(); // Cập nhật DataGridView với dữ liệu mới
                }
                else
                {
                    MessageBox.Show("Xóa nhà cung cấp không thành công. Hãy kiểm tra lại dữ liệu.");
                }
            }
            else
            {
                // Người dùng đã chọn "No", không thực hiện xóa
                MessageBox.Show("Xóa nhà cung cấp đã bị hủy.");
            }
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            // Lấy MaNCC từ TextBox Tìm kiếm
            string maNCC = textBox_TimKiem.Text.Trim();

            // Kiểm tra xem MaNCC có được nhập vào không
            if (string.IsNullOrEmpty(maNCC))
            {
                MessageBox.Show("Vui lòng nhập MaNCC để tìm kiếm.");
                return;
            }

            // Xây dựng câu lệnh SQL SELECT để tìm kiếm theo MaNCC
            string searchQuery = $"SELECT * FROM NhaCungCap WHERE MaNCC = '{maNCC}'";

            // Thực hiện truy vấn SQL SELECT
            DataSet ds = kn.Laydulieu(searchQuery);

            // Kiểm tra xem có dữ liệu tìm thấy không
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Có dữ liệu được tìm thấy, hiển thị nó trong DataGridView
                dataGridView_DanhSachNhaCungCap.DataSource = ds.Tables[0];
            }
            else
            {
                // Không tìm thấy dữ liệu, hiển thị thông báo
                MessageBox.Show("Không tìm thấy nhà cung cấp với MaNCC này.");
            }
        }

        private void dataGridView_DanhSachNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                textBox_MaNCC.Enabled = false;
                button_Them.Enabled = false;
                button_Sua.Enabled = true;
                button_Xoa.Enabled = true;
                textBox_MaNCC.Text = dataGridView_DanhSachNhaCungCap.Rows[r].Cells["MaNCC"].Value.ToString();
                textBox_TenNCC.Text = dataGridView_DanhSachNhaCungCap.Rows[r].Cells["TenNCC"].Value.ToString();
                textBox_SDT.Text = dataGridView_DanhSachNhaCungCap.Rows[r].Cells["SDT"].Value.ToString();
                textBox_Email.Text = dataGridView_DanhSachNhaCungCap.Rows[r].Cells["Email"].Value.ToString();

            }
        }

        
        private void button_XuatExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Tạo tiêu đề cho các cột trong Excel
            for (int i = 0; i < dataGridView_DanhSachNhaCungCap.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView_DanhSachNhaCungCap.Columns[i].HeaderText;
            }

            // Đổ dữ liệu từ DataGridView vào Excel
            for (int i = 0; i < dataGridView_DanhSachNhaCungCap.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_DanhSachNhaCungCap.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView_DanhSachNhaCungCap.Rows[i].Cells[j].Value;
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

    }
}
