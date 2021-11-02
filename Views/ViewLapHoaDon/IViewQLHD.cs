using QLHD.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLHD.View
{
    public interface IViewQLHD
    {
        QLHDpresenter Presenter { set; }
        string maHD { get; set; }
        string maHD1 { get; set; }
        int maNV { get; set; }
        string date { get; set; }
        int maCTHD { set; get; }
        float tongThanhTien { get; set; }
        string maHang { get; set; }
        string tenHang { get; set; }
        int soLuong { get; set; }
        float donGia { get; set; }
        float thanhTien { get; set; }
        DataSet tb { set; }
        void txtTenHangChange(string ten);
        void txtGiaChange(float gia);
        void txtTongChange(float tong);
        void showMessage(string message);
        void showTable();
        void showSaveCTHD();
        void showDelHangInCTHD();
        void showUpdateHangInCTHD();
    }
}
