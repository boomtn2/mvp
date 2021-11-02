using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVPNhanVien.Models
{
    class NhanVien
    {
        public int MaNV { set; get; }
        public string HoTen { set; get; }
        public string NgaySinh { set; get; }
        public string DiaChi { set; get; }
        public string SDT { set; get; }
        public string ChucVu { set; get; }

    }
}
