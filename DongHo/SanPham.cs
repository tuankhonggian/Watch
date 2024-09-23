using System;
using System.Data;
using System.Windows.Forms;

namespace DongHo
{
    public partial class SanPham : Form
    {
        ketnoi kn = new ketnoi();

        public SanPham()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            FillComboBoxes();
            GetData();
        }

        private void GetData()
        {
            string query = "SELECT * FROM SanPham";
            DataSet ds = kn.Laydulieu(query);
            dataGridView_DanhSachSP.DataSource = ds.Tables[0];
        }

        


        private void Clear()
        {
            textBox_MaSP.Enabled = true;
            button_Them.Enabled = true;
            button_Sua.Enabled = false;
            button_Xoa.Enabled = false;
            textBox_MaSP.Text = "";
            textBox_TenSP.Text = "";
            textBox_GiaTien.Text = "";
            comboBox_HangSanXuat.Text = "Chon HSX";
            comboBox_XuatXu.Text = "Chon XX";
            comboBox_NhaCungCap.Text = "Chon NCC";
        }

        private void button_LamMoi_Click(object sender, EventArgs e)
        {
            Clear();
            GetData();
        }
        private void FillComboBoxes()
        {
            // Lấy dữ liệu cho ComboBox Hãng sản xuất từ bảng KhoHang
            string queryHangSanXuat = "SELECT DISTINCT HangSanXuat FROM DanhSachSanPhamNhap";
            DataSet dsHangSanXuat = kn.Laydulieu(queryHangSanXuat);
            comboBox_HangSanXuat.DataSource = dsHangSanXuat.Tables[0];
            comboBox_HangSanXuat.DisplayMember = "HangSanXuat";
            comboBox_HangSanXuat.ValueMember = "HangSanXuat";
            comboBox_HangSanXuat.Text = "Chon HSX";

            // Lấy dữ liệu cho ComboBox Xuất xứ từ bảng KhoHang
            string queryXuatXu = "SELECT DISTINCT XuatXu FROM DanhSachSanPhamNhap";
            DataSet dsXuatXu = kn.Laydulieu(queryXuatXu);
            comboBox_XuatXu.DataSource = dsXuatXu.Tables[0];
            comboBox_XuatXu.DisplayMember = "XuatXu";
            comboBox_XuatXu.ValueMember = "XuatXu";
            comboBox_XuatXu.Text = "Chon XX";

            // Lấy dữ liệu cho ComboBox Nhà cung cấp (MaNCC) từ bảng NhaCungCap
            string queryNhaCungCap = "SELECT MaNCC FROM NhaCungCap";
            DataSet dsNhaCungCap = kn.Laydulieu(queryNhaCungCap);
            comboBox_NhaCungCap.DataSource = dsNhaCungCap.Tables[0];
            comboBox_NhaCungCap.DisplayMember = "MaNCC";
            comboBox_NhaCungCap.ValueMember = "MaNCC";
            comboBox_NhaCungCap.Text = "Chon NCC";
        }


        private void dataGridView_DanhSachSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                textBox_MaSP.Enabled = false;
                button_Them.Enabled = false;
                button_Sua.Enabled = true;
                button_Xoa.Enabled = true;
                textBox_MaSP.Text = dataGridView_DanhSachSP.Rows[r].Cells["MaSP"].Value.ToString();
                textBox_TenSP.Text = dataGridView_DanhSachSP.Rows[r].Cells["TenSP"].Value.ToString();
                textBox_GiaTien.Text = dataGridView_DanhSachSP.Rows[r].Cells["GiaTien"].Value.ToString();
                comboBox_HangSanXuat.Text = dataGridView_DanhSachSP.Rows[r].Cells["HangSanXuat"].Value.ToString();
                comboBox_XuatXu.Text = dataGridView_DanhSachSP.Rows[r].Cells["XuatXu"].Value.ToString();
                comboBox_NhaCungCap.Text = dataGridView_DanhSachSP.Rows[r].Cells["NhaCungCap"].Value.ToString();
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            // Collect data from input fields
            string maSP = textBox_MaSP.Text.Trim();
            string tenSP = textBox_TenSP.Text.Trim();
            decimal giaTien;

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) ||
                string.IsNullOrEmpty(textBox_GiaTien.Text) || comboBox_HangSanXuat.SelectedIndex == -1 ||
                comboBox_XuatXu.SelectedIndex == -1 || comboBox_NhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.");
                return;
            }

            if (!decimal.TryParse(textBox_GiaTien.Text, out giaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ.");
                return;
            }

            // Check for duplicate MaSP
            // Check for duplicate MaSP
            string checkDuplicateQuery = $"SELECT COUNT(*) FROM SanPham WHERE MaSP = '{maSP}'";
            int count = kn.ExecuteScalarCount(checkDuplicateQuery);

            if (count > 0)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại. Vui lòng chọn mã khác.");
                return;
            }


            // Insert data into the database
            string insertQuery = $"INSERT INTO SanPham (MaSP, TenSP, GiaTien, HangSanXuat, XuatXu, NhaCungCap) " +
                                 $"VALUES ('{maSP}', '{tenSP}', {giaTien}, '{comboBox_HangSanXuat.Text}', " +
                                 $"'{comboBox_XuatXu.Text}', '{comboBox_NhaCungCap.Text}')";

            if (kn.Thucthi(insertQuery))
            {
                MessageBox.Show("Thêm sản phẩm thành công.");
                Clear();
                GetData(); // Refresh the DataGridView with the updated data
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm không thành công. Hãy kiểm tra lại dữ liệu.");
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            // Collect data from input fields
            string maSP = textBox_MaSP.Text.Trim();
            string tenSP = textBox_TenSP.Text.Trim();
            decimal giaTien;

            if (string.IsNullOrEmpty(maSP) || string.IsNullOrEmpty(tenSP) ||
                string.IsNullOrEmpty(textBox_GiaTien.Text) || comboBox_HangSanXuat.SelectedIndex == -1 ||
                comboBox_XuatXu.SelectedIndex == -1 || comboBox_NhaCungCap.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin sản phẩm.");
                return;
            }

            if (!decimal.TryParse(textBox_GiaTien.Text, out giaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ.");
                return;
            }

            // Update data in the database
            string updateQuery = $"UPDATE SanPham " +
                                 $"SET TenSP = '{tenSP}', GiaTien = {giaTien}, HangSanXuat = '{comboBox_HangSanXuat.Text}', " +
                                 $"XuatXu = '{comboBox_XuatXu.Text}', NhaCungCap = '{comboBox_NhaCungCap.Text}' " +
                                 $"WHERE MaSP = '{maSP}'";

            if (kn.Thucthi(updateQuery))
            {
                MessageBox.Show("Sửa sản phẩm thành công.");
                Clear();
                GetData(); // Refresh the DataGridView with the updated data
            }
            else
            {
                MessageBox.Show("Sửa sản phẩm không thành công. Hãy kiểm tra lại dữ liệu.");
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            string maSP = textBox_MaSP.Text.Trim();

            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
                return;
            }

            // Confirm the deletion with the user
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận Xóa", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Perform the deletion in the database
                string deleteQuery = $"DELETE FROM SanPham WHERE MaSP = '{maSP}'";

                if (kn.Thucthi(deleteQuery))
                {
                    MessageBox.Show("Xóa sản phẩm thành công.");
                    Clear();
                    GetData(); // Refresh the DataGridView with the updated data
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm không thành công. Hãy kiểm tra lại dữ liệu.");
                }
            }
        }

        private void button_TimKiem_Click(object sender, EventArgs e)
        {
            string maSPToSearch = textBox_TimKiem.Text.Trim();

            if (string.IsNullOrEmpty(maSPToSearch))
            {
                MessageBox.Show("Vui lòng nhập Mã Sản Phẩm để tìm kiếm.");
                return;
            }

            // Query to search for products by MaSP
            string searchQuery = $"SELECT * FROM SanPham WHERE MaSP = '{maSPToSearch}'";

            DataSet ds = kn.Laydulieu(searchQuery);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                // Display the search results in the DataGridView
                dataGridView_DanhSachSP.DataSource = ds.Tables[0];
            }
            else
            {
                // No matching records found
                MessageBox.Show("Không tìm thấy sản phẩm với Mã Sản Phẩm này.");
                dataGridView_DanhSachSP.DataSource = null; // Clear the DataGridView
            }
        }

    }
}
