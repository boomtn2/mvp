using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVPNhanVien.Models
{
    class NhanVienModel
    {
        public string connectionString = "Data Source=DESKTOP-RIUA93F\\HIEU;Initial Catalog=QLSieuThi;Integrated Security=True";
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

        public DataTable dsNhanVien()
        {
            using (SqlConnection connection = new SqlConnection(
                      connectionString))
            {
                String query = "Select * from NhanVien";
                da = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                da.Dispose();

                return dt;
            }
        }

        public int themNhanVien(String HoTen, String NgaySinh, String DiaChi, String SDT, String ChucVu)
        {
            String qurey = "INSERT INTO NhanVien(HoTen,NgaySinh,DiaChi,SDT,ChucVu) VALUES('" + HoTen + "', '" +NgaySinh +
                "','"+DiaChi+"', '" + SDT+ "','" + ChucVu+ "')";

            return ExecuteNonQuery(qurey);
        }

        public int xoaNhanVien(int MaNV)
        {
            String query = "Delete from NhanVien where MaNV = " + MaNV;
            return ExecuteNonQuery(query);
        }

        public int suaNhanVien(int MaNV, String HoTen, String NgaySinh, String DiaChi, String SDT, String ChucVu)
        {
            String query = "UPDATE NhanVien SET HoTen = '" + HoTen + "', NgaySinh = '" + NgaySinh + "',DiaChi = '" + DiaChi + "', SDT = '" + SDT + "',ChucVu = '" + ChucVu + "'  WHERE MaNV = " + MaNV;            
            return ExecuteNonQuery(query);
        }
    }
}
