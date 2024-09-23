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
    public partial class GiaoDienAD : Form
    {
        public GiaoDienAD()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void GiaoDienAD_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel_TrangChu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new TrangChu());
            label1.Text = linkLabel_TrangChu.Text;
        }

        private void linkLabel_SanPham_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new SanPham());
            label1.Text = linkLabel_SanPham.Text;
        }

        private void linkLabel_NhanVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new NhanVien());
            label1.Text = linkLabel_NhanVien.Text;
        }

        private void linkLabel_NhaCungCap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new NhaCungCap());
            label1.Text = linkLabel_NhaCungCap.Text;
        }

        private void linkLabel_KhoHang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new KhoHang());
            label1.Text = linkLabel_KhoHang.Text;
        }

        private void linkLabel_HoaDon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new HoaDon());
            label1.Text = linkLabel_HoaDon.Text;
        }

        private void linkLabel_ThongKe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new ThongKe());
            label1.Text = linkLabel_ThongKe.Text;
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Xác nhận Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Đổi_Mật_Khẩu frm = new Đổi_Mật_Khẩu();
            frm.ShowDialog();
        }
    }
}
