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
    public partial class ThemMatHangForm : Form,ThemMatHangIView
    {
        public String maHang
        {
            get
            {
                return txtMaHang.Text.ToString();
            }
            set
            {

            }
        }
        public string tenMatHang
        {
            get
            {
                return txtTenHang.Text.ToString();
            }
            set
            {

            }
        }
        public String DVT
        {
            get
            {

                return txtDVT.Text.ToString();
            }
            set
            {

            }
        }
        public int SL
        {
            get
            {
               
               return tryCatch_Int(txtSL.Text.ToString());
            }
            set
            {

            }
        }
        public string NCC
        {
            get
            {
                return txtNCC.Text.ToString();
            }
            set
            {

            }
        }

        String _messsage;
        public string message {
            get { return _messsage; }
            set
            {
                _messsage = value;
                MessageBox.Show(_messsage);
            }
        }

        public float Gia { get { return float.Parse(txtGia.Text); } set => throw new NotImplementedException(); }

        public ThemMatHangForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttThem_Click(object sender, EventArgs e)
        {
            ThemMatHangPresenter presenter = new ThemMatHangPresenter(this);

            presenter.themMatHang();

            txtDVT.Clear();
            txtNCC.Clear();
            txtMaHang.Clear();
            txtSL.Clear();
            txtTenHang.Clear();
            txtGia.Clear();

        }

        private void bttThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int tryCatch_Int(String st)
        {
            try
            {
                int number = int.Parse(st);
                return number;
            }catch(Exception e)
            {
                MessageBox.Show("Nhập sai kiểu dữ liệu");
                return 0;
            }
           
        }
    }
}
