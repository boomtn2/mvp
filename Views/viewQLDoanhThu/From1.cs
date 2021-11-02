using qldoanhthu_mvp.presenter;
using qldoanhthu_mvp.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qldoanhthu_mvp
{
    public partial class Form1 : Form,i_view_TK_Thang,i_view_TK_Ngay
    {
       

        public float giahnag { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float tongtien { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
        int i_view_TK_Thang.mahang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        string i_view_TK_Thang.tenhang { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        int i_view_TK_Thang.soluong { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        
        private string _messsage;

        public string Message
        {
            get { return _messsage; }

            set
            {
                _messsage = value;
                MessageBox.Show(_messsage);
            }
        }
        private string _messsages;

        public string Messages
        {
            get { return _messsages; }

            set
            {
                _messsages = value;
                MessageBox.Show(_messsages);
            }
        }

        public string ngayban { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        TK_Thang_presenter th;
         TK_Ngay_presenter ng;

        public Form1()
        {
            InitializeComponent();

            th = new TK_Thang_presenter(this);

            dataGridView1.DataSource = th.tk_thang();



            ng = new TK_Ngay_presenter(this);

            dataGridView2.DataSource = ng.tk_ngay();


        }
      
          


        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
