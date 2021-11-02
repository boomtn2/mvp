using DemoMVPNhanVien;
using qldoanhthu_mvp;
using QLST.Presenters;
using QLST.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLST
{
    public partial class LoginForm : Form, ILoginView
    {
        private LoginPresenter _presenter;

        public LoginForm()
        {
            InitializeComponent();
            _presenter = new LoginPresenter(this);
        }

        public string Username
        {
            get => tbUsername.Text;
            set => tbUsername.Text = value;
        }

        public string Password
        {
            get => tbPassword.Text;
            set => tbPassword.Text = value;
        }

        public void LoginError()
        {
            MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }

        public void ShowNhanVienView()
        {
            // Triển khai Form của nhân viên
            // this.Hide();
            // var nhanVienForm = new NhanVienForm(); 
            // nhanVienForm.Closed += (sender, e) => this.Close(); // https://stackoverflow.com/a/13459878
            // nhanVienForm.Show();

            qldoanhthu_mvp.Form1 th = new Form1();
            this.Hide();
            th.Closed += (sender, e) => this.Show();
            th.Show();
        }

        public void ShowQuanLyView()
        {
             QLHD.Form1 qLHD = new QLHD.Form1();
            this.Hide();
             qLHD.ShowDialog();
            this.Show();
            /*
            QLNhanVien ql = new QLNhanVien();
            this.Hide();
            ql.ShowDialog();
            this.Show();
            */
        }

        public void ShowThuKhoView()
        {
            QLMatHang.DSMatHangForm foQLMH = new QLMatHang.DSMatHangForm();
            this.Hide();
            foQLMH.ShowDialog();
            this.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _presenter.Login();
        }
    }
}
