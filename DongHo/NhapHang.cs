using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHo
{
    public partial class NhapHang : Form
    {
        public NhapHang()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        
        private void NhapHang_Load(object sender, EventArgs e)
        {
            GetData();
        }
        private void GetData()
        {
            string query = "SELECT * FROM DanhSachSanPhamNhap";
            DataSet ds = kn.Laydulieu(query);
            dataGridView_danhsachsanphamnhap.DataSource = ds.Tables[0];
        }

        private void button_Nhap_Click(object sender, EventArgs e)
        {
            // Get the selected row in the DataGridView
            int selectedRowIndex = dataGridView_danhsachsanphamnhap.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView_danhsachsanphamnhap.Rows[selectedRowIndex];

            // Get the product ID (masp) from the selected row
            string masp = selectedRow.Cells["masp"].Value.ToString();

            // Get the quantity to be added from the textbox
            int soluongNhap;
            if (!int.TryParse(textBox_SoLuong.Text, out soluongNhap))
            {
                MessageBox.Show("Vui lòng nhập số lượng hợp lệ.");
                return;
            }

            // Update the stock quantity in the database (assuming you have a table named "khohang" with columns "soluongtonkho" and "masp")
            string updateQuery = $"UPDATE khohang SET soluongtonkho = soluongtonkho + {soluongNhap}, NgayNhap = GETDATE() WHERE masp = '{masp}'";
            if (kn.Thucthi(updateQuery))
            {
                MessageBox.Show("Cập nhật số lượng hàng tồn kho thành công.");
                GetData(); // Refresh the DataGridView
                this.Close();
            }
            else
            {
                MessageBox.Show("Lỗi cập nhật số lượng hàng tồn.");
            }
        }

        private void dataGridView_danhsachsanphamnhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
