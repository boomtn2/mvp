
namespace DemoMVPNhanVien
{
    partial class QLNhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.comboBoxChucVu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewNhanVien = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePickerNgaySinh);
            this.groupBox1.Controls.Add(this.buttonThoat);
            this.groupBox1.Controls.Add(this.buttonXoa);
            this.groupBox1.Controls.Add(this.buttonSua);
            this.groupBox1.Controls.Add(this.buttonThem);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtDienThoai);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.comboBoxChucVu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(71, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(980, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(133, 74);
            this.dateTimePickerNgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(280, 22);
            this.dateTimePickerNgaySinh.TabIndex = 14;
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(799, 146);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(100, 28);
            this.buttonThoat.TabIndex = 13;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(691, 146);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(100, 28);
            this.buttonXoa.TabIndex = 12;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(583, 146);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(100, 28);
            this.buttonSua.TabIndex = 11;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(475, 146);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(100, 28);
            this.buttonThem.TabIndex = 10;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(633, 78);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(264, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(633, 33);
            this.txtDienThoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(264, 22);
            this.txtDienThoai.TabIndex = 8;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(133, 30);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(280, 22);
            this.txtHoTen.TabIndex = 6;
            // 
            // comboBoxChucVu
            // 
            this.comboBoxChucVu.FormattingEnabled = true;
            this.comboBoxChucVu.Items.AddRange(new object[] {
            "Thu ngân",
            "Bảo vệ"});
            this.comboBoxChucVu.Location = new System.Drawing.Point(133, 117);
            this.comboBoxChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxChucVu.Name = "comboBoxChucVu";
            this.comboBoxChucVu.Size = new System.Drawing.Size(220, 24);
            this.comboBoxChucVu.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chức vụ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 81);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(548, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewNhanVien);
            this.groupBox2.Location = new System.Drawing.Point(69, 242);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(984, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chung";
            // 
            // dataGridViewNhanVien
            // 
            this.dataGridViewNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.hoten,
            this.ngaysinh,
            this.diachi,
            this.sdt,
            this.chucvu});
            this.dataGridViewNhanVien.Location = new System.Drawing.Point(1, 23);
            this.dataGridViewNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewNhanVien.Name = "dataGridViewNhanVien";
            this.dataGridViewNhanVien.RowHeadersWidth = 51;
            this.dataGridViewNhanVien.Size = new System.Drawing.Size(941, 306);
            this.dataGridViewNhanVien.TabIndex = 0;
            this.dataGridViewNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewNhanVien_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "MaNV";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // hoten
            // 
            this.hoten.DataPropertyName = "HoTen";
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.DataPropertyName = "NgaySinh";
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // diachi
            // 
            this.diachi.DataPropertyName = "DiaChi";
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SDT";
            this.sdt.HeaderText = "SDT";
            this.sdt.MinimumWidth = 10;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // chucvu
            // 
            this.chucvu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chucvu.DataPropertyName = "ChucVu";
            this.chucvu.HeaderText = "Chức Vụ";
            this.chucvu.MinimumWidth = 6;
            this.chucvu.Name = "chucvu";
            // 
            // QLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QLNhanVien";
            this.Text = "QLNhanVien";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.ComboBox comboBoxChucVu;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.DataGridView dataGridViewNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
    }
}

