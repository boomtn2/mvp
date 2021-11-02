using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVPNhanVien.Views
{
    interface INhanVienView
    {
        int MaNV { set; get; }
        string HoTen { set; get; }
        string NgaySinh { set; get; }
        string DiaChi { set; get; }
        string SDT { set; get; }
        string ChucVu { set; get; }
        string Message { set; get; }
        string message { get; set; }
    }
}
