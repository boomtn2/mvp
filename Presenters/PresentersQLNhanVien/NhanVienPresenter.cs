using DemoMVPNhanVien.Models;
using DemoMVPNhanVien.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoMVPNhanVien.Presenters
{
    class NhanVienPresenter
    {
        private readonly INhanVienView nhanVienView;
        NhanVien nhanvien;
        NhanVienModel nhanVienModel;
        public NhanVienPresenter(INhanVienView nhanVienView)
        {
            this.nhanVienView = nhanVienView;
            nhanVienModel = new NhanVienModel();
        }
        public DataTable showDS()
        {
            return nhanVienModel.dsNhanVien();
        }
        public DataTable reLoadData()
        {
            nhanVienView.message = ("Đã hiển thị danh sách");
            return showDS();
        }
        public void themNhanVien()
        {
            NhanVienModel model = new NhanVienModel();

            if (model.themNhanVien(nhanVienView.HoTen, nhanVienView.NgaySinh, nhanVienView.DiaChi, nhanVienView.SDT, nhanVienView.ChucVu) > 0)
                nhanVienView.message = "Đã thêm thành công";
            else
                nhanVienView.message = nhanVienView.NgaySinh;//" Thêm thất bại";
        }
        public void SuaNhanVien(int oldmaNV)
        {
            NhanVienModel model = new NhanVienModel();
            if (model.suaNhanVien(oldmaNV, nhanVienView.HoTen, nhanVienView.NgaySinh, nhanVienView.DiaChi, nhanVienView.SDT, nhanVienView.ChucVu) > 0)
            {
                nhanVienView.message = "Đã sửa thành công";
            }
            else 
            {
                nhanVienView.message = "Sửa thất bại";
            }

        }
        public void XoaNhanVien(int oldMaNV)
        {
            if (nhanVienModel.xoaNhanVien(oldMaNV) > 0)
            {
                nhanVienView.message = ("Đã xóa thành công");
            }
            else
                nhanVienView.message = ("Xóa thất bại");

        }
    }
}
