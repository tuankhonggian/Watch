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
    public partial class ChiTietHD : Form
    {
        public ChiTietHD()
        {
            InitializeComponent();
        }
        ketnoi kn = new ketnoi();
        private void ChiTietHD_Load(object sender, EventArgs e)
        {
            GetData1();
            GetData2();
        }

        private void GetData1()
        {
            string query1 = "SELECT * FROM ChiTietHD";
            DataSet ds1 = kn.Laydulieu(query1);
            dataGridView_ttkh.DataSource = ds1.Tables[0];
        }
        private void GetData2()
        {
            string query2 = "SELECT * FROM DanhSachSanPham";
            DataSet ds2 = kn.Laydulieu(query2);
            dataGridView_dssp.DataSource = ds2.Tables[0];
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_HuyDH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn hủy đơn hàng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Xóa dữ liệu từ bảng ChiTietHD
                string deleteQuery1 = "DELETE FROM ChiTietHD";
                kn.Thucthi(deleteQuery1);

                // Xóa dữ liệu từ bảng DanhSachSanPham
                string deleteQuery2 = "DELETE FROM DanhSachSanPham";
                kn.Thucthi(deleteQuery2);

                // Đặt lại DataSource của dataGridView_ttkh và dataGridView_dssp thành null để xóa dữ liệu trên giao diện
                dataGridView_ttkh.DataSource = null;
                dataGridView_dssp.DataSource = null;

                // Trở về form hoadon
                HoaDon formHoadon = new HoaDon();
                formHoadon.Show();
                this.Close();
            }
        }

        private void button_Lưu_Click(object sender, EventArgs e)
        {
            HoaDon formHoadon = new HoaDon();
            formHoadon.Show();
            this.Close();
        }

        private void button_in_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];

            // Tạo tiêu đề cho các cột trong Excel
            for (int i = 0; i < dataGridView_ttkh.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dataGridView_ttkh.Columns[i].HeaderText;
            }

            // Đổ dữ liệu từ DataGridView vào Excel
            for (int i = 0; i < dataGridView_ttkh.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView_ttkh.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView_ttkh.Rows[i].Cells[j].Value;
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
