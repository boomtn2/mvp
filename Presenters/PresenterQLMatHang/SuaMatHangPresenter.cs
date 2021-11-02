using QLMatHang.Model;
using QLMatHang.View;
using System;
using System.Collections.Generic;
using System.Text;

namespace QLMatHang.Presenter
{
    class SuaMatHangPresenter
    {
        SuaMatHangIView _view;
        String _oldMaHang;
        public SuaMatHangPresenter(SuaMatHangIView view, String oldMaHang)
        {
            this._view = view;
            this._oldMaHang = oldMaHang;
        }

        public void suaMatHang()
        {
            MatHangModel model = new MatHangModel();
            
            if (model.suaMatHang(_oldMaHang, _view.maHang, _view.tenMatHang, _view.SL, _view.NCC, _view.DVT,_view.Gia) > 0)
            {
                _view.message = "Đã sửa thành công";
            }else
                _view.message = "Sửa thất bại";

        }
    }
}
