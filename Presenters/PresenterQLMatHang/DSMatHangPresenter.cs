using QLMatHang.Model;
using QLMatHang.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace QLMatHang.Presenter
{
    class DSMatHangPresenter
    {
        private readonly DSMatHangIView _view;
        MatHang matHang;
        MatHangModel model;

        public DSMatHangPresenter(DSMatHangIView view)
        {
            this._view = view;
            model = new MatHangModel();
        }

        public DataTable showDS()
        {
           

            return model.dsMatHang();
        }

        public DataTable reLoadData()
        {
            _view.message = ("Đã hiển thị danh sách");
            return showDS();
        }

        public void xoaDS()
        {
            
            if(model.xoaMatHang(_view.maHang) > 0)
            {
                _view.message = ("Đã xóa thành công" + _view.maHang + _view.tenMatHang);
            }else
                _view.message = ("Xóa thất bại" + _view.maHang + _view.tenMatHang);
        }

    }
}
