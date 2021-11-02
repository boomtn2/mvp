using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldoanhthu_mvp.model
{
    class TK_Ngay_model
    {
     public   String ngayban { set; get; }

     public   float tongtien { set; get; }
        String con = @"Data Source=DESKTOP-RIUA93F\HIEU;Initial Catalog=QLSieuThi;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter da;

        public DataTable dsTKngay()
        {
            using (SqlConnection connection = new SqlConnection(con))
            {

                String query = "SELECT NgayBan, SUM(TongTien) AS DOANHTHU FROM HOADON GROUP BY NgayBan";

                da = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                da.Dispose();

                return dt;
            }
        }

    }
}

