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
    public partial class Đổi_Mật_Khẩu : Form
    {
        public Đổi_Mật_Khẩu()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void Đổi_Mật_Khẩu_Load(object sender, EventArgs e)
        {
            
        }

        private void button_DMK_Click(object sender, EventArgs e)
        {
            string taiKhoan = textBox_TaiKhoan.Text;
            string matKhauCu = textBox_MatKhauCu.Text;
            string matKhauMoi = textBox_MatKhauMoi.Text;
            string xacNhanMatKhauMoi = textBox_XNMKM.Text;
            string email = textBox_Email.Text;

            // Kiểm tra xác nhận mật khẩu mới
            if (matKhauMoi != xacNhanMatKhauMoi)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp.");
                return;
            }

            // Kiểm tra mật khẩu cũ
            string query = $"SELECT MatKhau FROM TaiKhoan WHERE TaiKhoan = '{taiKhoan}'";
            string matKhauHienTai = kn.ExecuteScalar(query) as string;

            if (matKhauHienTai == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.");
                return;
            }

            if (matKhauCu != matKhauHienTai)
            {
                MessageBox.Show("Mật khẩu cũ không đúng.");
                return;
            }

            // Cập nhật mật khẩu mới
            query = $"UPDATE TaiKhoan SET MatKhau = '{matKhauMoi}' WHERE TaiKhoan = '{taiKhoan}'";
            bool capNhatThanhCong = kn.Thucthi(query);

            if (capNhatThanhCong)
            {
                MessageBox.Show("Đổi mật khẩu thành công.");
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại.");
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn dừng việc đổi mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
  }

