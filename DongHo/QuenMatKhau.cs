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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
       
        private void button_llmk_Click(object sender, EventArgs e)
        {
            string email = textBox_EmailDK.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string query = "SELECT * FROM TaiKhoan WHERE Email = '" + email + "'";
                var taiKhoans = kn.Laydulieu(query);

                if (taiKhoans.Tables.Count > 0 && taiKhoans.Tables[0].Rows.Count > 0)
                {
                    string matKhau = taiKhoans.Tables[0].Rows[0]["MatKhau"].ToString();
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật Khẩu:   " + matKhau;
                    
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng ký!";
                }
            }
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn muốn dừng việc lấy mật khẩu?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (tb == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
