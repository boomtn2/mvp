using QLHD.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLHD.Presenter
{
    public class QLHDpresenter
    {
        private readonly IViewQLHD _view;
        
        
        public QLHDpresenter(IViewQLHD view)
        {
            _view = view;
            view.Presenter = this;
        }
        public void setNameHang()
        {
            string maHD = _view.maHD;
            string maHang = _view.maHang;
            string tenHang = _view.tenHang;
            int soLuong = _view.soLuong;
            float donGia = _view.donGia;
            float thanhTien = _view.thanhTien;

            var cthd = new Model.CTHD(maHD, maHang, tenHang, soLuong, donGia, thanhTien);
            string nameH = cthd.getTenHang();
            
            if (nameH != "")
            {
                _view.txtTenHangChange(nameH);
            }
            else
                _view.showMessage("Rỗng!");
        }
        public void setGiaHang()
        {
            string maHD = _view.maHD;
            string maHang = _view.maHang;
            string tenHang = _view.tenHang;
            int soLuong = _view.soLuong;
            float donGia = _view.donGia;
            float thanhTien = _view.thanhTien;

            var cthd = new Model.CTHD(maHD, maHang, tenHang, soLuong, donGia, thanhTien);
            float gia = cthd.getDonGia();

            if (gia != null)
            {
                _view.txtGiaChange(gia);
            }
            else
                _view.showMessage("Rỗng!");
        }
        public void tinhTongTien()
        {
            string maHD = _view.maHD;
            string maHang = _view.maHang;
            string tenHang = _view.tenHang;
            int soLuong = _view.soLuong;
            float donGia = _view.donGia;
            float thanhTien = _view.thanhTien;
            var cthd = new Model.CTHD(maHD, maHang, tenHang, soLuong, donGia, thanhTien);
            try
            {
                float tong = cthd.tongTien();
                _view.txtTongChange(tong);
            }
            catch(Exception e)
            {
                _view.showMessage(e.Message);
            }
            
            
        }
        public DataSet getDataTb()
        {
            string maHD = _view.maHD;
            string maHang = _view.maHang;
            string tenHang = _view.tenHang;
            int soLuong = _view.soLuong;
            float donGia = _view.donGia;
            float thanhTien = _view.thanhTien;

            var cthd = new Model.CTHD(maHD, maHang, tenHang, soLuong, donGia, thanhTien);
            return _view.tb = cthd.getAll();
        }
        public DataSet saveCTHD()
        {
            string maHD = _view.maHD;
            string maHang = _view.maHang;
            string tenHang = _view.tenHang;
            int soLuong = _view.soLuong;
            float donGia = _view.donGia;
            float thanhTien = _view.thanhTien;

            var cthd = new Model.CTHD(maHD, maHang, tenHang, soLuong, donGia, thanhTien);
            try
            {
                cthd.saveCTHD();
            }
            catch(Exception e)
            {
                _view.showMessage(e.Message);
            }
            return _view.tb = cthd.getAll();
        }
        public DataSet delHangInCTHD()
        {
            int id = _view.maCTHD;

            var cthd = new Model.CTHD(id);
            try
            {
                cthd.delHangInCTHD();
            }
            catch (Exception e)
            {
                _view.showMessage(e.Message);
            }
            return _view.tb = cthd.getAll();
        }
        public DataSet updateHangInCTHD()
        {

            int id = _view.maCTHD;
            string maHD = _view.maHD;
            string maHang = _view.maHang;
            string tenHang = _view.tenHang;
            int soLuong = _view.soLuong;
            float donGia = _view.donGia;
            float thanhTien = _view.thanhTien;

            var cthd = new Model.CTHD(maHD, maHang, tenHang, soLuong, donGia, thanhTien);
            try
            {
                cthd.updateHangInCTHD(id);
                _view.showMessage("Sửa thành công!");
            }
            catch (Exception e)
            {
                _view.showMessage(e.Message);
            }
            return _view.tb = cthd.getAll();
        }
        //hoa don
        public void addHoaDon()
        {

            string mahd = _view.maHD;
            int manv = _view.maNV;
            string ngay = _view.date;
            float tong = _view.tongThanhTien;
            var hd = new Model.HoaDon(mahd,manv,ngay,tong);
            try
            {
                hd.updateHD();
                _view.showMessage("Tạo thành công");
            }
            catch (Exception e)
            {
                _view.showMessage(e.Message);
            }
            //return _view.tb = hd.getAll();
        }
        public void addMaHoaDon()
        {

            string mahd = _view.maHD;
            int manv = _view.maNV;
            string ngay = _view.date;
            float tong = _view.tongThanhTien;
            var hd = new Model.HoaDon(mahd, manv, ngay, tong);
            try
            {
                hd.taoHdTruocKhiLuu();
            }
            catch (Exception e)
            {
                _view.showMessage(e.Message);
            }
            //return _view.tb = hd.getAll();
        }
        public void delHangDelHD()
        {
            string maHD1 = _view.maHD1;

            var cthd = new Model.CTHD(maHD1);
            var hd = new Model.HoaDon(maHD1);
            try
            {
                cthd.xoaHangTheoXoaHoaDon();
                hd.xoaHD();
                _view.showMessage("Xóa thành công!");
            }
            catch (Exception e)
            {
                _view.showMessage(e.Message);
            }
        }
    }
}
