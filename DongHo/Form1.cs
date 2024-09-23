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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();

        private void button_DangNhap_Click(object sender, EventArgs e)
        {
            string tenTK = textBox_TaiKhoan.Text;
            string MK = textBox_MatKhau.Text;
            if (tenTK.Trim() == "")
            {
                MessageBox.Show("Vui Long Nhap Ten Tai Khoan!!");
            }
            else if (MK.Trim() == "")
            {
                MessageBox.Show("Vui long nhap mat khau!!");
            }
            else if (comboBox_ChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon chuc vu!!");
            }
            else
            {
                string query = string.Format(
                    "SELECT * FROM TaiKhoan WHERE TaiKhoan = '{0}' AND MatKhau = '{1}'", tenTK, MK
                    );
                DataSet ds = kn.Laydulieu(query);

                if (ds.Tables[0].Rows.Count ==1 )
                {
                    string chucVuTrongDB = ds.Tables[0].Rows[0]["ChucVu"].ToString().ToLower();
            string chucVuDuocChon = comboBox_ChucVu.SelectedItem.ToString().ToLower();

            if (chucVuDuocChon == chucVuTrongDB)
            {
                MessageBox.Show("Đăng Nhập Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                if (chucVuTrongDB == "admin")
                {
                    GiaoDienAD home1 = new GiaoDienAD();
                    home1.ShowDialog();
                }
                else if (chucVuTrongDB == "user")
                {
                    GiaoDienUSER home1 = new GiaoDienUSER();
                    home1.ShowDialog();
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Chức Vụ Không Phù Hợp!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        else
        {
            MessageBox.Show("Đăng Nhập Thất Bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
            }
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy frm = new DangKy();
            frm.ShowDialog();
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau frm = new QuenMatKhau();
            frm.ShowDialog();
        }
    }
}
