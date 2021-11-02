using QLMatHang.Model;
using QLMatHang.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLMatHang.Presenter
{
    class ThemMatHangPresenter
    {
        ThemMatHangIView _view;
        public ThemMatHangPresenter(ThemMatHangIView view)
        {
            this._view = view;
        }

        public void themMatHang()
        {
            MatHangModel model = new MatHangModel();
            
            if (model.themMatHang(_view.maHang, _view.tenMatHang,_view.SL, _view.NCC, _view.DVT,_view.Gia) > 0)
                _view.message = "Đã thêm thành công";
            else
                _view.message = " Thêm thất bại trùng mã";
        }
    }
}
