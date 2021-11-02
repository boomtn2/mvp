using System;
using System.Collections.Generic;
using System.Text;

namespace QLMatHang.View
{
    interface ThemMatHangIView
    {
        String maHang { set; get; }
        String tenMatHang { set; get; }
        String DVT { set; get; }

        float Gia { set; get; }
        int SL { set; get; }
        String NCC { set; get; }
        String message { set; get; }
    }
}
