using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLHD.Model
{
    class CTHD
    {
        public int maCTHD { get; set; }
        public string maHD { get; set; }
        public string maHang { get; set; }
        public string tenHang { get; set; }
        public int soLuong { get; set; }
        public float donGia { get; set; }
        public float thanhTien { get; set; }
        public string maHD1 { get; set; }
        //Data Source=DESKTOP-RIUA93F\HIEU;Initial Catalog=QLSieuThi;Integrated Security=True
        public string strCon = @"Data Source=DESKTOP-RIUA93F\HIEU;Initial Catalog=QLSieuThi;Integrated Security=True";

        public CTHD(string maHD, string maHang, string tenHang, int soLuong, float donGia, float thanhTien)
        {
            this.maHD = maHD;
            this.maHang = maHang;
            this.tenHang = tenHang;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;
        }

        public CTHD(string maHD1)
        {
            this.maHD1 = maHD1;
        }

       /* public CTHD(int ma)
        {
            this.maCTHD = ma;
        }*/

        public CTHD()
        {
        }

        public CTHD(int maCTHD)
        {
            this.maCTHD = maCTHD;
        }

        /*public CTHD(int ma, string maHD, string maHang, string tenHang, int soLuong, int donGia, int thanhTien) : this(ma)
        {
        }*/

        public string getTenHang()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            string sql = "SELECT TenHang FROM Hang WHERE MaHang = '"+maHang+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = sqlCon;
            return tenHang = (string)cmd.ExecuteScalar();
        }
        public float getDonGia()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            float g;
            /*if(maHang != null)
            {*/
                string sql = "SELECT Gia FROM Hang WHERE MaHang = '" + maHang + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = sqlCon;
                //g = (float)cmd.ExecuteScalar();
                return donGia = float.Parse(cmd.ExecuteScalar().ToString());
            /*}
            return donGia = g;*/
            
        }
        public DataSet getAll()
        {
            DataSet dt = new DataSet();
            string query = "Select ChiTietHoaDon.id, ChiTietHoaDon.MaHang,  Hang.TenHang, ChiTietHoaDon.DonGia,ChiTietHoaDon.SoLuong, ChiTietHoaDon.ThanhTien from ChiTietHoaDon, Hang where ChiTietHoaDon.MaHang = Hang.MaHang and SoHD = '" + maHD + "'";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dt);
                connection.Close();
            }
            return dt;
        }
        public void saveCTHD()
        {
            string query = "INSERT into ChiTietHoaDon values(@maHD,@maHang, @soLuong, @donGia, @thanhTien)";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maHD", maHD);
                cmd.Parameters.AddWithValue("@maHang", maHang);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.Parameters.AddWithValue("@donGia", donGia);
                cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                cmd.ExecuteNonQuery();
                connection.Close();
                //Form1_Load(sender, e);
            }
        }
        public void delHangInCTHD()
        {
            string query = "delete from ChiTietHoaDon where id=@id";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id",maCTHD);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void xoaHangTheoXoaHoaDon()
        {
            string query = "delete from ChiTietHoaDon where SoHD=@maHD";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maHD", maHD1);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void updateHangInCTHD(int id)
        {
            string query = "UPDATE ChiTietHoaDon set MaHang=@maHang, SoLuong=@soLuong, DonGia=@donGia, ThanhTien=@thanhTien where id=@maCTHD";
            using (SqlConnection connection = new SqlConnection(strCon))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@maHang", maHang);
                cmd.Parameters.AddWithValue("@soLuong", soLuong);
                cmd.Parameters.AddWithValue("@donGia", donGia);
                cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                cmd.Parameters.AddWithValue("@maCTHD", id);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public float tongTien()
        {
            SqlConnection sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            float g = 0;
            if (maHD != null)
            {
                string sql = "SELECT SUM(ThanhTien) from ChiTietHoaDon WHERE SoHD = '" + maHD + "'";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = sql;
                cmd.Connection = sqlCon;
                g = float.Parse(cmd.ExecuteScalar().ToString());
                //return donGia = (int)cmd.ExecuteScalar();
            }
            return g;
        }

    }
}
