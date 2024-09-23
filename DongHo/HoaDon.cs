using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHo
{
    public partial class HoaDon : Form
    {
        public HoaDon()
        {
            InitializeComponent();
        }

        ketnoi kn = new ketnoi();
        private void HoaDon_Load(object sender, EventArgs e)
        {
            GetData();
            LoadComboBoxData();
            comboBox_MSP_TSP_SLT.Text = "......";
            comboBox_MaNV.Text = "......";
            //button_XuatHD.Visible = false;
            //button_XemCTHD.Visible = false;
            LoadEmployeeIDs();
        }
        private void GetData()
        {
            string query = "SELECT * FROM DanhSachSanPham";
            DataSet ds = kn.Laydulieu(query);
            dataGridView_DanhSachSanPham.DataSource = ds.Tables[0];
        }

        

        private void button_Refesh_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM DanhSachSanPham";
            bool success = kn.Thucthi(deleteQuery);

            if (success)
            {
                MessageBox.Show("Da lam moi.");
                GetData();
                // Refresh the data grid view
            }
            else
            {
                MessageBox.Show("Lam moi that bai.");
            }
        }

        private void button_Them_Click(object sender, EventArgs e)
        {
            // Get the selected product's MaSP and TenSP from the ComboBox
            string selectedProductInfo = comboBox_MSP_TSP_SLT.Text;
            string[] productInfoParts = selectedProductInfo.Split('-');
            string maSP = productInfoParts[0].Trim();
            string tenSP = productInfoParts[1].Trim();

            // Get the quantity to purchase from textBox_SoLuongMua
            if (!int.TryParse(textBox_SoLuongMua.Text, out int soLuongMua))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return;
            }

            // Retrieve the price (GiaTien) of the selected product from the database
            string queryPrice = $"SELECT GiaTien FROM SanPham WHERE MaSP = '{maSP}'";
            int giaTien = kn.ExecuteScalarCount(queryPrice);

            if (giaTien < 0)
            {
                MessageBox.Show("Không thể tìm thấy giá tiền của sản phẩm.");
                return;
            }

            // Check if the product already exists in the DanhSachSanPham table
            string checkProductQuery = $"SELECT COUNT(*) FROM DanhSachSanPham WHERE MaSP = '{maSP}'";
            int productCount = kn.ExecuteScalarCount(checkProductQuery);

            if (productCount > 0)
            {
                // Product already exists, update the quantity and total cost
                string updateQuery = $"UPDATE DanhSachSanPham SET SoLuongMua = SoLuongMua + {soLuongMua}, ThanhTien = (SoLuongMua + {soLuongMua}) * GiaTien WHERE MaSP = '{maSP}'";
                bool updateSuccess = kn.Thucthi(updateQuery);

                if (updateSuccess)
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công.");
                    int tongTien = TinhTongTien();
                }
                else
                {
                    MessageBox.Show("Cập nhật sản phẩm thất bại.");
                }
            }
            else
            {
                // Product doesn't exist, insert a new row
                int thanhTien = soLuongMua * giaTien;
                string insertQuery = $"INSERT INTO DanhSachSanPham (MaSP, TenSP, SoLuongMua, GiaTien, ThanhTien) VALUES ('{maSP}', '{tenSP}', {soLuongMua}, {giaTien}, {thanhTien})";
                bool insertSuccess = kn.Thucthi(insertQuery);

                if (insertSuccess)
                {
                    MessageBox.Show("Thêm sản phẩm thành công.");
                }
                else
                {
                    MessageBox.Show("Thêm sản phẩm thất bại.");
                }
            }

            // Refresh the DataGridView or perform any other necessary actions
            GetData();
        }

        private void button_XoaSP_Click(object sender, EventArgs e)
        {
            if (dataGridView_DanhSachSanPham.SelectedRows.Count > 0)
            {
                string maSP = dataGridView_DanhSachSanPham.SelectedRows[0].Cells["MaSP"].Value.ToString();
                string deleteQuery = $"DELETE FROM DanhSachSanPham WHERE MaSP = '{maSP}'";
                bool success = kn.Thucthi(deleteQuery);

                if (success)
                {
                    MessageBox.Show("Xóa sản phẩm thành công.");
                    GetData();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa.");
            }
        }

        private void LoadComboBoxData()
        {
            string query = "SELECT MaSP, TenSP, SoLuongTonKho FROM KhoHang";
            DataSet ds = kn.Laydulieu(query);

            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                comboBox_MSP_TSP_SLT.Items.Clear();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string maSP = row["MaSP"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    string soLuongTonKho = row["SoLuongTonKho"].ToString();
                    string displayValue = $"{maSP} - {tenSP} - {soLuongTonKho}";
                    comboBox_MSP_TSP_SLT.Items.Add(displayValue);
                }
                if (comboBox_MSP_TSP_SLT.Items.Count > 0)
                {
                    comboBox_MSP_TSP_SLT.SelectedIndex = 0;
                }
            }
            else
            {
                comboBox_MSP_TSP_SLT.Items.Clear();
            }
        }


        private void dataGridView_DanhSachSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_DanhSachSanPham.Rows[rowIndex];
                string soLuongMua = selectedRow.Cells["SoLuongMua"].Value.ToString();
                textBox_SoLuongMua.Text = soLuongMua;
                string maSP = selectedRow.Cells["MaSP"].Value.ToString();
                string tenSP = selectedRow.Cells["TenSP"].Value.ToString();
                string soLuongTonKho = selectedRow.Cells["SoLuongTonKho"].Value.ToString();
                string displayValue = $"{maSP} - {tenSP} - {soLuongTonKho}";
                comboBox_MSP_TSP_SLT.SelectedValue = maSP;
                comboBox_MSP_TSP_SLT.Text = displayValue;
            }
        }

        private void LoadEmployeeIDs()
        {
            string query = "SELECT MaNV FROM nhanvien";
            DataSet ds = kn.Laydulieu(query);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                comboBox_MaNV.Items.Clear();
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string maNV = row["MaNV"].ToString();
                    comboBox_MaNV.Items.Add(maNV);
                }
                if (comboBox_MaNV.Items.Count > 0)
                {
                    comboBox_MaNV.SelectedIndex = 0;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy dữ liệu nhân viên.");
            }
        }


        private void button_TaoDH_Click(object sender, EventArgs e)
        {
            string maHD = textBox_MaDH.Text;
            string maNV = comboBox_MaNV.Text;
            string tenKH = textBox_TenKH.Text;
            string sdtKH = textBox_SDTKH.Text;
            string diaChi = textBox_DiaChi.Text;
            DateTime ngayMua = dateTimePicker_ThoiGian.Value;

            // Check if required fields are filled
            if (string.IsNullOrWhiteSpace(maHD) || string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(tenKH))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Save customer information to the database
            bool success = kn.InsertInvoice(maHD, maNV, tenKH, sdtKH, diaChi, ngayMua);

            if (success)
            {
                // Cập nhật tổng tiền trong bảng ChiTietHD
                int tongTien = TinhTongTien();
                string updateTongTienQuery = $"UPDATE ChiTietHD SET TongTien = {tongTien} WHERE MaHD = '{maHD}'";
                bool updateTongTienSuccess = kn.Thucthi(updateTongTienQuery);

                if (updateTongTienSuccess)
                {
                    MessageBox.Show("Thêm hóa đơn thành công.");
                    ChiTietHD frm = new ChiTietHD();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Cập nhật tổng tiền thất bại.");
                }
            }
            else
            {
                MessageBox.Show("Thêm hóa đơn thất bại.");
            }
        }
        private int TinhTongTien()
        {
            int tongTien = 0;

            foreach (DataGridViewRow row in dataGridView_DanhSachSanPham.Rows)
            {
                int thanhTien = Convert.ToInt32(row.Cells["ThanhTien"].Value);
                tongTien += thanhTien;
            }

            return tongTien;
        }

    }
}