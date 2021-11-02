using QLHD.Presenter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHD
{
    public partial class Form1 : Form, View.IViewQLHD
    {
        public Form1()
        {
            InitializeComponent();
            CenterToScreen();
        }
        public QLHDpresenter Presenter {private get; set; }
        //public string strCon = @"Data Source=DESKTOP-7LK28DU\;Initial Catalog=HoaDon;Integrated Security=True";
        public string maHD { 
            get => txtMaHD.Text.Trim(); 
            set => txtMaHD.Text = value.ToString(); }
        public int maNV { 
            get => int.Parse(cbMaNV.Text.Trim()); 
            set => cbMaNV.Text = value.ToString(); }
        public string date { 
            get => dtNgayBan.Value.Day+"/"+dtNgayBan.Value.Month+"/"+dtNgayBan.Value.Year; 
            set => dtNgayBan.Text = value; 
        }
        public float tongThanhTien { 
            get => float.Parse(txtTongTien.Text); 
            set => txtTongTien.Text = value.ToString(); 
        }
        public string maHang { 
            get => txtMaHang.Text.Trim(); 
            set => txtMaHang.Text = value; 
        }
        public string tenHang {
            get => txtTenHang.Text; 
            set => txtTenHang.Text = value; 
        }
        public int soLuong {
            get => int.Parse(txtSoLuong.Text); 
            set => txtSoLuong.Text = value.ToString(); 
        }
        public float donGia {
            get => float.Parse(txtDonGia.Text); 
            set => txtDonGia.Text = value.ToString(); 
        }
        public float thanhTien { 
            get => float.Parse(txtThanhTien.Text);
            set => txtTongTien.Text = value.ToString(); 
        }
        public DataSet tb { private get; set; }
        public int maCTHD { 
            set => txtMaCTHD.Text = value.ToString();
            get => int.Parse(txtMaCTHD.Text);
        }
        public string maHD1 { 
            get =>txtMaHD1.Text.Trim(); 
            set =>txtMaHD1.Text = value.ToString(); 
        }

        //save hang vao hoa don
        private void button1_Click(object sender, EventArgs e)
        {
            showSaveCTHD();
            showTable();
            Presenter = new QLHDpresenter(this);
            Presenter.tinhTongTien();
        }

        public void txtTenHangChange(string ten)
        {
            txtTenHang.Text = ten;
        }
        public void txtGiaChange(float gia)
        {
            txtDonGia.Text = gia.ToString();
        }
        public void showMessage(string message)
        {
            MessageBox.Show(message,"Thông báo" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
        public void loadDataGrid()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSoLuong.Text = "0";
            txtThanhTien.Text = "0";
            txtDonGia.Text = "0";
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            txtMaCTHD.Text = "0";
            txtMaHD.Text = "";
            showTable();
            //dtgHang.
        }

        private void txtMaHang_TextChanged(object sender, EventArgs e)
        {
            Presenter = new QLHDpresenter(this);
            if(txtMaHang.Text != "")
                Presenter.setNameHang();
        }

        private void txtTenHang_TextChanged(object sender, EventArgs e)
        {
            Presenter = new QLHDpresenter(this);
            if(txtTenHang.Text != "")
            {
                Presenter.setGiaHang();
                txtSoLuong.Enabled = true;
            }
        }
        private void txtSoLuong_Leave(object sender, EventArgs e)
        {
            if(txtSoLuong.Text != "0")
            {
                float don = float.Parse(txtDonGia.Text.ToString());
                int sl = int.Parse(txtSoLuong.Text);
                float thanhTien = don * sl;
                txtThanhTien.Text = thanhTien.ToString();
            }
        }

        public void showTable()
        {
            Presenter = new QLHDpresenter(this);
            dtgHang.DataSource = Presenter.getDataTb().Tables[0];
            
        }

        public void showSaveCTHD()
        {
            Presenter = new QLHDpresenter(this);
            dtgHang.DataSource = Presenter.saveCTHD().Tables[0];
            
        }

        private void dtgHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = dtgHang.CurrentRow.Index;
                txtMaCTHD.Text = dtgHang.Rows[i].Cells[0].Value.ToString().Trim();
                txtMaHang.Text = dtgHang.Rows[i].Cells[1].Value.ToString().Trim();
                txtSoLuong.Text = dtgHang.Rows[i].Cells[4].Value.ToString().Trim();
                txtThanhTien.Text = dtgHang.Rows[i].Cells[5].Value.ToString().Trim();
            }catch(Exception ex)
            {
                showMessage(ex.Message);
            }
        }

        //xoa hang in cthd
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtMaCTHD.Text != "0" && txtMaCTHD.Text != "")
            {
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    showDelHangInCTHD();
                    showTable();
                    Presenter = new QLHDpresenter(this);
                    Presenter.tinhTongTien();
                }
            }
            else MessageBox.Show("Hãy chọn hàng trong chi tiết hóa đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void showDelHangInCTHD()
        {
            Presenter = new QLHDpresenter(this);
            dtgHang.DataSource = Presenter.delHangInCTHD().Tables[0];
        }


        //Sua hang in CTHD
        private void button2_Click(object sender, EventArgs e)
        {
            if(txtMaCTHD.Text != "0" && txtMaCTHD.Text != "")
            {
                if ((MessageBox.Show("Bạn có chắc chắn muốn sửa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    showUpdateHangInCTHD();
                    showTable();
                }
            }
            else MessageBox.Show("Hãy chọn hàng trong chi tiết hóa đơn", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        public void showUpdateHangInCTHD()
        {
            Presenter = new QLHDpresenter(this);
            dtgHang.DataSource = Presenter.updateHangInCTHD().Tables[0];
        }

        public void txtTongChange(float tong)
        {
            txtTongTien.Text = tong.ToString();
        }

        private void txtMaHD_Leave(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "")
            {
                Presenter = new QLHDpresenter(this);
                Presenter.addMaHoaDon();
            }
        }
        
        //Lưu hóa đơn
        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text != "")
            {
                Presenter = new QLHDpresenter(this);
                Presenter.addHoaDon();
            }
            else MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // xóa hóa đơn
        private void btnXoaHD_Click(object sender, EventArgs e)
        {

            if (txtMaHD1.Text != "")
            {
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)) {
                    Presenter = new QLHDpresenter(this);
                    Presenter.delHangDelHD();
                    Form1_Load(sender,e);
                    showTable();
                }
            }
            else MessageBox.Show("Nhập mã trước khi xóa","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dtNgayBan_ValueChanged(object sender, EventArgs e)
        {
            /*Presenter = new QLHDpresenter(this);
            Presenter.addMaHoaDon();*/
        }
    }
}
