
namespace QLHD
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaCTHD = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtgHang = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.txtMaHD1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHang)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(166, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbMaNV);
            this.groupBox1.Controls.Add(this.dtNgayBan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 70);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn";
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayBan.Location = new System.Drawing.Point(441, 28);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(99, 20);
            this.dtNgayBan.TabIndex = 3;
            this.dtNgayBan.Value = new System.DateTime(2021, 11, 2, 10, 35, 43, 0);
            this.dtNgayBan.ValueChanged += new System.EventHandler(this.dtNgayBan_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(77, 31);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(88, 20);
            this.txtMaHD.TabIndex = 1;
            this.txtMaHD.Leave += new System.EventHandler(this.txtMaHD_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtMaCTHD);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtThanhTien);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Controls.Add(this.dtgHang);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDonGia);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTenHang);
            this.groupBox2.Controls.Add(this.txtSoLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMaHang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 302);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 271);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "mã CTHD";
            // 
            // txtMaCTHD
            // 
            this.txtMaCTHD.Enabled = false;
            this.txtMaCTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaCTHD.ForeColor = System.Drawing.Color.Red;
            this.txtMaCTHD.Location = new System.Drawing.Point(73, 267);
            this.txtMaCTHD.Name = "txtMaCTHD";
            this.txtMaCTHD.Size = new System.Drawing.Size(53, 20);
            this.txtMaCTHD.TabIndex = 21;
            this.txtMaCTHD.TabStop = false;
            this.txtMaCTHD.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Sửa hàng";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Xóa hàng";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.Red;
            this.txtThanhTien.Location = new System.Drawing.Point(447, 32);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(114, 21);
            this.txtThanhTien.TabIndex = 99;
            this.txtThanhTien.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng Tiền";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongTien.ForeColor = System.Drawing.Color.Red;
            this.txtTongTien.Location = new System.Drawing.Point(447, 265);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(114, 22);
            this.txtTongTien.TabIndex = 15;
            this.txtTongTien.TabStop = false;
            this.txtTongTien.Text = "0";
            // 
            // dtgHang
            // 
            this.dtgHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHang.Location = new System.Drawing.Point(0, 98);
            this.dtgHang.Name = "dtgHang";
            this.dtgHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgHang.Size = new System.Drawing.Size(587, 161);
            this.dtgHang.TabIndex = 11;
            this.dtgHang.TabStop = false;
            this.dtgHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgHang_CellClick);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(465, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Đơn giá";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGia.ForeColor = System.Drawing.Color.Red;
            this.txtDonGia.Location = new System.Drawing.Point(255, 70);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(114, 22);
            this.txtDonGia.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên hàng";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Enabled = false;
            this.txtTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenHang.ForeColor = System.Drawing.Color.Red;
            this.txtTenHang.Location = new System.Drawing.Point(61, 70);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(114, 22);
            this.txtTenHang.TabIndex = 98;
            this.txtTenHang.TabStop = false;
            this.txtTenHang.TextChanged += new System.EventHandler(this.txtTenHang_TextChanged);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(255, 30);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(114, 20);
            this.txtSoLuong.TabIndex = 5;
            this.txtSoLuong.Leave += new System.EventHandler(this.txtSoLuong_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Số lượng";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(61, 28);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(114, 20);
            this.txtMaHang.TabIndex = 4;
            this.txtMaHang.TextChanged += new System.EventHandler(this.txtMaHang_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã hàng";
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.Location = new System.Drawing.Point(175, 30);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(81, 23);
            this.btnXoaHD.TabIndex = 10;
            this.btnXoaHD.Text = "Xóa hóa đơn";
            this.btnXoaHD.UseVisualStyleBackColor = true;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // txtMaHD1
            // 
            this.txtMaHD1.Location = new System.Drawing.Point(80, 32);
            this.txtMaHD1.Name = "txtMaHD1";
            this.txtMaHD1.Size = new System.Drawing.Size(73, 20);
            this.txtMaHD1.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Mã hóa đơn";
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.Location = new System.Drawing.Point(78, 30);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(87, 23);
            this.btnTaoHD.TabIndex = 12;
            this.btnTaoHD.Text = "Lưu hóa đơn";
            this.btnTaoHD.UseVisualStyleBackColor = true;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTaoHD);
            this.groupBox4.Location = new System.Drawing.Point(12, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 73);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbMaNV.Location = new System.Drawing.Point(272, 30);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(93, 21);
            this.cbMaNV.TabIndex = 2;
            this.cbMaNV.Text = "1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMaHD1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnXoaHD);
            this.groupBox3.Location = new System.Drawing.Point(300, 420);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(300, 73);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(611, 505);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayBan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.DataGridView dtgHang;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaCTHD;
        private System.Windows.Forms.TextBox txtMaHD1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

