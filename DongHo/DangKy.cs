using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DongHo
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)// check mat khau va tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        ketnoi kn = new ketnoi();
        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void button_DangKy_Click(object sender, EventArgs e)
        {
            string tenTk = textBox_TK.Text;
            string MK = textBox_MK.Text;
            string XNMK = textBox_XNMK.Text;
            string email = textBox_Email.Text;

            // Validate username
            if (!checkAccount(tenTk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validate password
            if (!checkAccount(MK))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6-24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Check if password matches
            if (XNMK != MK)
            {
                MessageBox.Show("Vui lòng nhập nhập khẩu chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Validate email
            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Check if the email is already registered
            if (kn.ExecuteScalarCount("SELECT COUNT(*) FROM TaiKhoan WHERE Email = '" + email + "'") > 0)
            {
                MessageBox.Show("Email này đã được đăng ký vui lòng đăng ký email khác !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Attempt to insert the user into the database
            try
            {
                string query = "INSERT INTO TaiKhoan (TaiKhoan, MatKhau, Email) VALUES ('" + tenTk + "', '" + MK + "', '" + email + "')";
                if (kn.Thucthi(query))
                {
                    if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Close(); // Close the registration form or perform further actions.
                    }
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại! Vui lòng thử lại sau.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn dừng việc đăng ký?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
