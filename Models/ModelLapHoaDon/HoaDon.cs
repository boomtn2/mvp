using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QLHD.Model
{
    class HoaDon
    {
        public string maHD { get; set; }
        public int maNV { get; set; }
        public string date { get; set; }
        public float tongThanhTien { get; set; }
        public string maHD1 { get; set; }

        public string strCon = @"Data Source=DESKTOP-RIUA93F\HIEU;Initial Catalog=QLSieuThi;Integrated Security=True";

        SqlConnection sqlCon = null;
        public HoaDon(string maHD, int maNV, string date, float tongThanhTien)
        {
            this.maHD = maHD;
            this.maNV = maNV;
            this.date = date;
            this.tongThanhTien = tongThanhTien;
        }

        public HoaDon(string maHD1)
        {
            this.maHD1 = maHD1;
        }

        //update
        public void updateHD()
        {
            string query = "UPDATE HoaDon set MaNV=@maNV, NgayBan=@date, TongTien=@tongTien where SoHD=@maHD";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maHD", maHD);
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@tongTien", tongThanhTien);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        //tạo trước mới thêm được chi tiết HD do có ràng buộc với nhau
        public void taoHdTruocKhiLuu()
        {
            string query = "INSERT into HoaDon values(@maHD, @ngayLap,@maNV, @tongThanhTien)";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maHD", maHD);
                cmd.Parameters.AddWithValue("@maNV", maNV);
                cmd.Parameters.AddWithValue("@ngayLap", date);
                cmd.Parameters.AddWithValue("@tongThanhTien", tongThanhTien);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void xoaHD()
        {
            string query = "delete from HoaDon where SoHD=@maHD";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maHD", maHD1);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void searchHD()
        {
            string query = "Select from tbHoaDon where SoHD=@maHD";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maHD", maHD1);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
