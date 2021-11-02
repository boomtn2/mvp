using qldoanhthu_mvp.model;
using qldoanhthu_mvp.view;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qldoanhthu_mvp.presenter
{
    class TK_Thang_presenter
    {
        i_view_TK_Thang tk_view;

        public TK_Thang_presenter(i_view_TK_Thang tk_view)
        {
            this.tk_view = tk_view;
        }

        public DataTable tk_thang()
        {
            TK_Thang_model tk = new TK_Thang_model();
            return tk.dsTKthang();
        }

       
    }

}
