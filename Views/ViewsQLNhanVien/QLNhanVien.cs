
using DemoMVPNhanVien.Presenters;
using DemoMVPNhanVien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace DemoMVPNhanVien
{

    public partial class QLNhanVien : Form, INhanVienView
    {
        NhanVienPresenter nhanVienPresenter;
        int oldmaNV;
        public int MaNV { set { oldmaNV = value; } }
        public string HoTen { get { return txtHoTen.Text; } set { txtHoTen.Text = value.ToString();  } }
        public string NgaySinh { get { return dateTimePickerNgaySinh.Value.ToShortDateString(); } set { dateTimePickerNgaySinh.Text = value.ToString(); } }
       public string DiaChi { get {return txtDiaChi.Text; } set { txtDiaChi.Text = value.ToString(); } }
        public string SDT { get { return txtDienThoai.Text; } set { txtDienThoai.Text = value.ToString(); } }
        public string ChucVu { get { return comboBoxChucVu.Text; } set { comboBoxChucVu.Text = value.ToString(); } }
        private string _message;

        public string message {
            get
            {
                return _message;
            }
            set
            {
                _message = value;
                MessageBox.Show(_message);
            }
        }

        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int INhanVienView.MaNV { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public QLNhanVien()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nhanVienPresenter = new NhanVienPresenter(this);
            dataGridViewNhanVien.DataSource = nhanVienPresenter.showDS();
        }

    private void buttonThem_Click(object sender, EventArgs e)
        {
            NhanVienPresenter prs = new NhanVienPresenter(this);
            prs.themNhanVien();
            prs.reLoadData();
            dataGridViewNhanVien.DataSource = nhanVienPresenter.showDS();

            /*ListViewItem item = lvNhanVien.Items.Add(txtHoTen.Text);
            item.SubItems.Add(dateTimePickerNgaySinh.Value.ToShortDateString());
            item.SubItems.Add(txtDiaChi.Text);
            item.SubItems.Add(txtDienThoai.Text);
            item.SubItems.Add(comboBoxChucVu.Text);
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            txtDienThoai.Text = "";
            comboBoxChucVu.Text = "";
            dateTimePickerNgaySinh.Value = DateTime.Now;*/
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            NhanVienPresenter prs = new NhanVienPresenter(this);
            prs.SuaNhanVien(oldmaNV) ;
            prs.reLoadData();
            dataGridViewNhanVien.DataSource = nhanVienPresenter.showDS();
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                nhanVienPresenter.XoaNhanVien(oldmaNV);
                dataGridViewNhanVien.DataSource = nhanVienPresenter.showDS();
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewNhanVien.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridViewNhanVien.CurrentRow.Selected = true;
               string a = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString();
                oldmaNV = int.Parse(a);
                txtHoTen.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["HoTen"].FormattedValue.ToString();
                dateTimePickerNgaySinh.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["NgaySinh"].FormattedValue.ToString();
                txtDiaChi.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["DiaChi"].FormattedValue.ToString();
                txtDienThoai.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["SDT"].FormattedValue.ToString();
                comboBoxChucVu.Text = dataGridViewNhanVien.Rows[e.RowIndex].Cells["ChucVu"].FormattedValue.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
