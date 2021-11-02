using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace QLMatHang.Model
{
    class MatHangModel
    {
        //Data Source=DESKTOP-RIUA93F\HIEU;Initial Catalog=Hang;Integrated Security=True
        string connectionString = @"Data Source=DESKTOP-RIUA93F\HIEU;Initial Catalog = QLSieuThi; Integrated Security = True";//"Data Source=DESKTOP-RIUA93F\\HIEU;Initial Catalog = Hang; Integrated Security = True";
        private SqlConnection connection;
        private SqlDataAdapter da;

        public int ExecuteNonQuery(String queryString)
        {
            using (SqlConnection connection = new SqlConnection(
                       connectionString))
            {

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                int row;
                try
                {
                    row = command.ExecuteNonQuery();
                }
                catch
                {
                    row = -1;
                }


                command.Connection.Close();

                return row;
            }
        }

        public DataTable dsMatHang()
        {
            using (SqlConnection connection = new SqlConnection(
                      connectionString))
            {
                String query = "Select * from Hang";
                da = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                da.Dispose();

                return dt;
            }
        }

        public int themMatHang(String maHang, String tenMatHang, int SL, String NCC, String DVT, float Gia)
        {
            String qurey = "INSERT INTO Hang(MaHang,TenHang, SoLuong,NCC,DVT, Gia) VALUES('" + maHang + "', '" + tenMatHang +
                "'," + SL + ", '" + NCC + "','" + DVT + "',"+Gia+")";

            return ExecuteNonQuery(qurey);
        }

        public int xoaMatHang(String maHang)
        {
            try
            {
                String query = "Delete from ChiTietPhieuXuat where MaHang = '" + maHang + "'";
                ExecuteNonQuery(query);
                query = "Delete from ChiTietPhieuNhap where MaHang = '" + maHang + "'";
                ExecuteNonQuery(query);
                query = "Delete from ChiTietHoaDon where MaHang = '" + maHang + "'";
                ExecuteNonQuery(query);
                query = "Delete from Hang where MaHang = '" + maHang + "'";
                return ExecuteNonQuery(query);
            }catch
            {
                return -1;
            }
       
        }

        public int suaMatHang(String oldMaHang, String maHang, String tenMatHang, int SL, String NCC, String DVT, float Gia)
        {
            try
            {
                String query = "Delete from ChiTietPhieuXuat where MaHang = '" + maHang + "'";
                ExecuteNonQuery(query);
                query = "Delete from ChiTietPhieuNhap where MaHang = '" + maHang + "'";
                ExecuteNonQuery(query);
                query = "Delete from ChiTietHoaDon where MaHang = '" + maHang + "'";
                ExecuteNonQuery(query);
                query = "UPDATE Hang SET MaHang = '" + maHang + "', TenHang = '" + tenMatHang + "', DVT = '" + DVT + "',SoLuong = " + SL + ", NCC = '" + NCC + ",Gia = " + Gia + "' WHERE MaHang = '" + oldMaHang + "'";
                return ExecuteNonQuery(query);
            }catch
            {
                return -1;
            }
            
        }
    }
}

