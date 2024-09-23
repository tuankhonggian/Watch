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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
         ketnoi kn = new ketnoi();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            string query = "SELECT * FROM NhanVien";
            DataSet ds = kn.Laydulieu(query);
            dataGridView_DSNhanVien.DataSource = ds.Tables[0];
        }
        private void Clear()
        {
            textBox_MaNV.Enabled = true;
            button_Them.Enabled = true;
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
            textBox_MaNV.Text = "";
            textBox_HoTen.Text = "";
            textBox_SDT.Text = "";
            textBox_Email.Text = "";
            textBox_TaiKhoan.Text = "";
            textBox_MatKhau.Text = "";
            textBox_DiaChi.Text = "";

        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
            GetData();
        }
        /*private void dataGridView_DSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                textBox_MaNV.Enabled = false;
                button_Them.Enabled = false;
                button_Sua.Enabled = true;
                button_Xoa.Enabled = true;
                textBox_MaNV.Text = dataGridView_DSNhanVien.Rows[r].Cells["MaNV"].Value.ToString();
                textBox_HoTen.Text = dataGridView_DSNhanVien.Rows[r].Cells["HoTen"].Value.ToString();
                textBox_SDT.Text = dataGridView_DSNhanVien.Rows[r].Cells["SDT"].Value.ToString();
                textBox_Email.Text = dataGridView_DSNhanVien.Rows[r].Cells["Email"].Value.ToString();
                textBox_TaiKhoan.Text = dataGridView_DSNhanVien.Rows[r].Cells["TaiKhoan"].Value.ToString();
                textBox_MatKhau.Text = dataGridView_DSNhanVien.Rows[r].Cells["MatKhau"].Value.ToString();
                textBox_DiaChi.Text = dataGridView_DSNhanVien.Rows[r].Cells["DiaChi"].Value.ToString();

            }
        }*/

        private void button_Them_Click(object sender, EventArgs e)
        {
            // Thu thập thông tin từ các TextBox
            string maNV = textBox_MaNV.Text.Trim();
            string hoten = textBox_HoTen.Text.Trim();
            string sdt = textBox_SDT.Text.Trim();
            string email = textBox_Email.Text.Trim();
            string TK = textBox_TaiKhoan.Text.Trim();
            string MK = textBox_MatKhau.Text.Trim();
            string diachi = textBox_DiaChi.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoten) ||
                string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(TK) || string.IsNullOrEmpty(MK)
                || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
                return;
            }

            // Kiểm tra MaNV, SDT, Email và TaiKhoan không trùng với dữ liệu đã tồn tại
            string checkQuery = $"SELECT COUNT(*) FROM NhanVien WHERE MaNV = '{maNV}' OR SDT = '{sdt}' OR Email = '{email}' OR TaiKhoan = '{TK}' ";
            int existingCount = Convert.ToInt32(kn.Laydulieu(checkQuery).Tables[0].Rows[0][0]);

            if (existingCount > 0)
            {
                MessageBox.Show("Mã NV, SDT, Email hoặc Tai Khoản đã tồn tại. Vui lòng kiểm tra lại.");
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
            string insertQuery = $"INSERT INTO NhanVien (MaNV, HoTen, SDT, Email, DiaChi, TaiKhoan, MatKhau) " +
                                 $"VALUES ('{maNV}', '{hoten}', '{sdt}', '{email}', '{diachi}', '{TK}', '{MK}')";

            // Thực hiện câu lệnh SQL INSERT
            if (kn.Thucthi(insertQuery))
            {
                MessageBox.Show("Thêm NHAN VIEN thành công.");
                Clear(); // Xóa dữ liệu trên các TextBox
                GetData(); // Cập nhật DataGridView với dữ liệu mới
            }
            else
            {
                MessageBox.Show("Thêm NHAN VIEN không thành công. Hãy kiểm tra lại dữ liệu.");
            }
        }


        private void dataGridView_DSNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                textBox_MaNV.Enabled = false;
                button_Them.Enabled = false;
                button_Sua.Enabled = true;
                button_Xoa.Enabled = true;
                textBox_MaNV.Text = dataGridView_DSNhanVien.Rows[r].Cells["MaNV"].Value.ToString();
                textBox_HoTen.Text = dataGridView_DSNhanVien.Rows[r].Cells["HoTen"].Value.ToString();
                textBox_SDT.Text = dataGridView_DSNhanVien.Rows[r].Cells["SDT"].Value.ToString();
                textBox_Email.Text = dataGridView_DSNhanVien.Rows[r].Cells["Email"].Value.ToString();
                textBox_TaiKhoan.Text = dataGridView_DSNhanVien.Rows[r].Cells["TaiKhoan"].Value.ToString();
                textBox_MatKhau.Text = dataGridView_DSNhanVien.Rows[r].Cells["MatKhau"].Value.ToString();
                textBox_DiaChi.Text = dataGridView_DSNhanVien.Rows[r].Cells["DiaChi"].Value.ToString();

            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            // Thu thập thông tin từ các TextBox
            string maNV = textBox_MaNV.Text.Trim();
            string hoten = textBox_HoTen.Text.Trim();
            string sdt = textBox_SDT.Text.Trim();
            string email = textBox_Email.Text.Trim();
            string TK = textBox_TaiKhoan.Text.Trim();
            string MK = textBox_MatKhau.Text.Trim();
            string diachi = textBox_DiaChi.Text.Trim();

            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(hoten) ||
                string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(TK) || string.IsNullOrEmpty(MK)
                || string.IsNullOrEmpty(diachi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin nhân viên.");
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
            string updateQuery = $"UPDATE NhanVien " +
                                 $"SET HoTen = '{hoten}', SDT = '{sdt}', Email = '{email}', DiaChi = '{diachi}', TaiKhoan = '{TK}', MatKhau = '{MK}' " +
                                 $"WHERE MaNV = '{maNV}'";

            // Thực hiện câu lệnh SQL UPDATE
            if (kn.Thucthi(updateQuery))
            {
                MessageBox.Show("Sửa NHAN VIEN thành công.");
                Clear(); // Xóa dữ liệu trên các TextBox
                GetData(); // Cập nhật DataGridView với dữ liệu mới
            }
            else
            {
                MessageBox.Show("Sửa NHAN VIEN không thành công. Hãy kiểm tra lại dữ liệu.");
            }
        }


        private void button_Xoa_Click(object sender, EventArgs e)
        {
            // Lấy mã nhân viên cần xóa từ textbox
            string maNV = textBox_MaNV.Text.Trim();

            // Kiểm tra xem mã nhân viên đã được nhập hay chưa
            if (string.IsNullOrEmpty(maNV))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Xây dựng câu lệnh SQL DELETE
                string deleteQuery = $"DELETE FROM NhanVien WHERE MaNV = '{maNV}'";

                // Thực hiện câu lệnh SQL DELETE
                if (kn.Thucthi(deleteQuery))
                {
                    MessageBox.Show("Xóa NHAN VIEN thành công.");
                    Clear(); // Xóa dữ liệu trên các TextBox
                    GetData(); // Cập nhật DataGridView với dữ liệu mới
                }
                else
                {
                    MessageBox.Show("Xóa NHAN VIEN không thành công. Hãy kiểm tra lại dữ liệu.");
                }
            }
            else if (result == DialogResult.No)
            {
                // Người dùng đã hủy xóa
                // Có thể thêm mã ngăn chặn các thao tác không mong muốn ở đây
            }
        }



        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            // Get the search criteria (employee code) from the TextBox
            string searchCriteria = textBox_TimKiem.Text.Trim();

            // Check if the search criteria is empty
            if (string.IsNullOrEmpty(searchCriteria))
            {
                MessageBox.Show("Vui lòng nhập Mã nhân viên cần tìm.");
                return;
            }

            try
            {
                // Construct the SQL query for searching employees by MaNV
                string searchQuery = $"SELECT * FROM NhanVien WHERE MaNV = '{searchCriteria}'";

                // Retrieve the search results from the database
                DataSet searchResults = kn.Laydulieu(searchQuery);

                // Check if any results were found
                if (searchResults.Tables[0].Rows.Count > 0)
                {
                    // Display the search results in the DataGridView
                    dataGridView_DSNhanVien.DataSource = searchResults.Tables[0];
                }
                else
                {
                    // No matching results found
                    MessageBox.Show($"Không tìm thấy nhân viên có Mã nhân viên '{searchCriteria}'.");
                }
            }
            catch (Exception ex)
            {
                // Handle any database or query errors here
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}");
            }
        }

        private void button_XuatExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Tạo tiêu đề cho các cột trong Excel
            for (int i = 0; i < dataGridView_DSNhanVien.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView_DSNhanVien.Columns[i].HeaderText;
            }

            // Đổ dữ liệu từ DataGridView vào Excel
            for (int i = 0; i < dataGridView_DSNhanVien.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_DSNhanVien.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView_DSNhanVien.Rows[i].Cells[j].Value;
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
