using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldoanhthu_mvp.view
{
    interface i_view_TK_Thang
    {

         int mahang { set; get; }
         String tenhang { set; get; }
         int soluong { set; get; }

         float giahnag { set; get; }

         float tongtien { set; get; }

         String Message { set; get; }
    }
}
