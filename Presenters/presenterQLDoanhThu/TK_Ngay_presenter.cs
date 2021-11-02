using qldoanhthu_mvp.model;
using qldoanhthu_mvp.view;
using System.Data;

namespace qldoanhthu_mvp
{
    class TK_Ngay_presenter
    {
        i_view_TK_Ngay tk_views;
        public TK_Ngay_presenter(i_view_TK_Ngay tk_views)
        {
            this.tk_views = tk_views;
        }
        public DataTable tk_ngay()
        {
            TK_Ngay_model tk = new TK_Ngay_model();
            return tk.dsTKngay();
        }

    }
}