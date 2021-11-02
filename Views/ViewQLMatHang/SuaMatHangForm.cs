using QLMatHang.Model;
using QLMatHang.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLMatHang.View
{
    public partial class SuaMatHangForm : Form, SuaMatHangIView
    {
 
        public SuaMatHangForm()
        {
            InitializeComponent();
            
        }

        String oldMaHang;

        public String maHang { 
            get { return  txtMaHang.Text.ToString().Trim(); }
            set {
                txtMaHang.Text = value.ToString().Trim();
                oldMaHang = value.Trim();
            } 
        }
        public string tenMatHang { get { return  txtTenHang.Text.ToString(); } 
            set {
                txtTenHang.Text = value.ToString();
            } 
        }
        public String DVT { get { return txtDVT.Text; } 
            set { 
                txtDVT.Text = value.ToString();
            } }
        public int SL { get { return tryCatch_Int( txtSL.Text.ToString()); }
            set {
                txtSL.Text = value.ToString();
            } }
        public string NCC { get { return txtNCC.Text; } 
            set { 
                txtNCC.Text = value.ToString();
            } }

        String _message;
        public string message
        {
            get { return _message; }
            set
            {
                _message = value;
                MessageBox.Show(_message);
            }
        }

        public float Gia { get { return float.Parse(txtGia.Text); } set { txtGia.Text = value.ToString(); } }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int tryCatch_Int(String st)
        {
            try
            {
                int number = int.Parse(st);
                return number;
            }
            catch (Exception e)
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu");
                return 0;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SuaMatHangPresenter presenter = new SuaMatHangPresenter(this,oldMaHang);
            presenter.suaMatHang();

            this.Close();

        }
    }
}
