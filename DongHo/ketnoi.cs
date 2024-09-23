using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongHo
{
    internal class ketnoi
    {
        string conStr = @"Data Source=ANHTUAN\SQLEXPRESS;Initial Catalog=DongHo;Integrated Security=True";
        SqlConnection conn;
        public ketnoi()
        {
            conn = new SqlConnection(conStr);
        }
        public DataSet Laydulieu(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch
            {
                return null;
            }
        }
        public bool Thucthi(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return r > 0;
            }
            catch
            {
                return false;
            }
        }
        public int ExecuteScalarCount(string truyvan)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(truyvan, conn);
                int count = (int)cmd.ExecuteScalar();
                conn.Close();
                return count;
            }
            catch
            {
                return -1; // Return -1 on error or no results
            }
        }
        public bool InsertInvoice(string madh, string manv, string hotenkh, string sdtkh, string diachi, DateTime ngaymua)
        {
            try
            {
                conn.Open();
                string insertQuery = "INSERT INTO ChiTietHD (MaHD, MaNV, HoTenKH, SDTKH, DiaChi, NgayMua) " +
                                     "VALUES (@madh, @manv, @hotenkh, @sdtkh, @diachi, @ngaymua)";

                SqlCommand cmd = new SqlCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@madh", madh);
                cmd.Parameters.AddWithValue("@manv", manv);
                cmd.Parameters.AddWithValue("@hotenkh", hotenkh);
                cmd.Parameters.AddWithValue("@sdtkh", sdtkh);
                cmd.Parameters.AddWithValue("@diachi", diachi);
                cmd.Parameters.AddWithValue("@ngaymua", ngaymua);

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                return rowsAffected > 0;
            }
            catch
            {
                return false;
            }
        }
        public object ExecuteScalar(string query)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                conn.Close();
                return result;
            }
            catch
            {
                return null; // Hoặc giá trị mặc định tùy vào yêu cầu của bạn
            }
        }
    }
}
