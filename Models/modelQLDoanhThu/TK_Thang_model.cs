using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldoanhthu_mvp.model
{
    class TK_Thang_model
    {
   public     int mahang { set; get; }
   public     String tenhang { set; get; }
   public     int soluong { set; get; }

   public     float giahnag { set; get; }

   public     float tongtien { set; get; }

        String con = @"Data Source=DESKTOP-RIUA93F\HIEU;Initial Catalog=QLSieuThi;Integrated Security=True";
        private SqlConnection connection;
        private SqlDataAdapter da;

        public DataTable dsTKthang()
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                
                String query = "SELECT MONTH(NgayBan) AS THANG,Year(NgayBan) AS Nam, SUM(TongTien) AS DOANHTHU"
                   +"   FROM HOADON "+
                      " Where Year(NgayBan) = 2000"+
                     "GROUP BY MONTH(NgayBan),Year (NgayBan)";

                da = new SqlDataAdapter(query, connection);

                DataTable dt = new DataTable();

                da.Fill(dt);

                da.Dispose();

                return dt;
            }
        }

    }
}
