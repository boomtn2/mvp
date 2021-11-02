using QLMatHang.Model;
using QLMatHang.Presenter;
using QLMatHang.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLMatHang
{
    public partial class DSMatHangForm : Form,DSMatHangIView
    {
        int rawIndexDTGV = -1;

        DSMatHangPresenter presenter;

        public string maHang
        {
            get { if (rawIndexDTGV == -1) return "";
                  else return dtgvDSMH.Rows[rawIndexDTGV].Cells[0].Value.ToString().Trim();
            }
            set
            {
               
            }
        }

        public string tenMatHang {
            get
            {
                if (rawIndexDTGV == -1) return "";
                else return dtgvDSMH.Rows[rawIndexDTGV].Cells[1].Value.ToString();

            } set => throw new NotImplementedException(); }
        public string dvt {
            get
            {
                if (rawIndexDTGV == -1) return "";
                else return dtgvDSMH.Rows[rawIndexDTGV].Cells[2].Value.ToString();

            }
            set { } 
        }
        public int SL {
            get
            {
                if (rawIndexDTGV == -1) return 0;
                else return int.Parse(dtgvDSMH.Rows[rawIndexDTGV].Cells[3].Value.ToString());

            }
            set => throw new NotImplementedException(); }
        public string NCC { get
            {
                if (rawIndexDTGV == -1) return "";
                else return dtgvDSMH.Rows[rawIndexDTGV].Cells[4].Value.ToString();

            }
            set => throw new NotImplementedException(); }


        private string _messsage;
        public string message { 
            get { return _messsage; }
            set {
                _messsage = value;
                MessageBox.Show(_messsage);
            } 
        }

        public float Gia { get {return float.Parse(dtgvDSMH.Rows[rawIndexDTGV].Cells[5].Value.ToString()); } set => throw new NotImplementedException(); }

        public DSMatHangForm()
        {
            InitializeComponent();

            presenter = new DSMatHangPresenter(this);
           dtgvDSMH.DataSource =  presenter.showDS();
            
        }

        //dataGridView1.Rows[numrow].Cells[1].Value.ToString();

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttThemMH_Click(object sender, EventArgs e)
        {
            ThemMatHangForm formThem = new ThemMatHangForm();
            this.Hide();
            formThem.ShowDialog();
            reloadDataGirdView();
            this.Show();
        }

        private void bttSuaMH_Click(object sender, EventArgs e)
        {
            if(rawIndexDTGV != -1)
            {
                SuaMatHangForm formSua = new SuaMatHangForm();
                formSua.maHang = maHang;
                formSua.tenMatHang = tenMatHang;
                formSua.DVT = dvt;
                formSua.Gia = Gia;
                formSua.NCC = NCC;
                formSua.SL = SL;
                formSua.ShowDialog();
                this.Show();
                dtgvDSMH.DataSource  =presenter.showDS();
            }
            
        }

        private void bttXoaMH_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                presenter.xoaDS();
                dtgvDSMH.DataSource = presenter.showDS();
            }
        }

        private void bttXemDS_Click(object sender, EventArgs e)
        {
            reloadDataGirdView();
        }

        private void dtgvDSMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rawIndexDTGV = e.RowIndex;
            int columnIndex = e.ColumnIndex;
        }

        void reloadDataGirdView()
        {
            dtgvDSMH.DataSource = presenter.reLoadData();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn là Thủ tờ kho :v");
        }

        private void dtgvDSMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
