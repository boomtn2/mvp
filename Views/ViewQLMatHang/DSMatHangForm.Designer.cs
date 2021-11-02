
namespace QLMatHang
{
    partial class DSMatHangForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvDSMH = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttXemDS = new System.Windows.Forms.Button();
            this.bttXoaMH = new System.Windows.Forms.Button();
            this.bttSuaMH = new System.Windows.Forms.Button();
            this.bttThemMH = new System.Windows.Forms.Button();
            this.clEmpoyeeMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpoyeeTenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpoyeeDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpoyeeSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clEmpoyeeNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMH)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 52);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.thôngTinToolStripMenuItem.Text = "ThuKho";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvDSMH);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(5, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 497);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Mặt Hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtgvDSMH
            // 
            this.dtgvDSMH.AllowUserToDeleteRows = false;
            this.dtgvDSMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSMH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clEmpoyeeMH,
            this.clEmpoyeeTenHang,
            this.DVT,
            this.clEmpoyeeDVT,
            this.clEmpoyeeSL,
            this.clEmpoyeeNCC});
            this.dtgvDSMH.Location = new System.Drawing.Point(1, 26);
            this.dtgvDSMH.Name = "dtgvDSMH";
            this.dtgvDSMH.ReadOnly = true;
            this.dtgvDSMH.RowHeadersWidth = 51;
            this.dtgvDSMH.RowTemplate.Height = 29;
            this.dtgvDSMH.Size = new System.Drawing.Size(799, 465);
            this.dtgvDSMH.TabIndex = 0;
            this.dtgvDSMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSMH_CellClick);
            this.dtgvDSMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSMH_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttXemDS);
            this.groupBox2.Controls.Add(this.bttXoaMH);
            this.groupBox2.Controls.Add(this.bttSuaMH);
            this.groupBox2.Controls.Add(this.bttThemMH);
            this.groupBox2.Location = new System.Drawing.Point(12, 564);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 75);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // bttXemDS
            // 
            this.bttXemDS.Location = new System.Drawing.Point(613, 20);
            this.bttXemDS.Name = "bttXemDS";
            this.bttXemDS.Size = new System.Drawing.Size(148, 49);
            this.bttXemDS.TabIndex = 3;
            this.bttXemDS.Text = "Xem Danh Sách";
            this.bttXemDS.UseVisualStyleBackColor = true;
            this.bttXemDS.Click += new System.EventHandler(this.bttXemDS_Click);
            // 
            // bttXoaMH
            // 
            this.bttXoaMH.Location = new System.Drawing.Point(424, 20);
            this.bttXoaMH.Name = "bttXoaMH";
            this.bttXoaMH.Size = new System.Drawing.Size(148, 49);
            this.bttXoaMH.TabIndex = 2;
            this.bttXoaMH.Text = "Xóa Mặt Hàng";
            this.bttXoaMH.UseVisualStyleBackColor = true;
            this.bttXoaMH.Click += new System.EventHandler(this.bttXoaMH_Click);
            // 
            // bttSuaMH
            // 
            this.bttSuaMH.Location = new System.Drawing.Point(222, 20);
            this.bttSuaMH.Name = "bttSuaMH";
            this.bttSuaMH.Size = new System.Drawing.Size(148, 49);
            this.bttSuaMH.TabIndex = 1;
            this.bttSuaMH.Text = "Sửa Mặt Hàng";
            this.bttSuaMH.UseVisualStyleBackColor = true;
            this.bttSuaMH.Click += new System.EventHandler(this.bttSuaMH_Click);
            // 
            // bttThemMH
            // 
            this.bttThemMH.Location = new System.Drawing.Point(21, 20);
            this.bttThemMH.Name = "bttThemMH";
            this.bttThemMH.Size = new System.Drawing.Size(148, 49);
            this.bttThemMH.TabIndex = 0;
            this.bttThemMH.Text = "Thêm Mặt Hàng";
            this.bttThemMH.UseVisualStyleBackColor = true;
            this.bttThemMH.Click += new System.EventHandler(this.bttThemMH_Click);
            // 
            // clEmpoyeeMH
            // 
            this.clEmpoyeeMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clEmpoyeeMH.DataPropertyName = "maHang";
            this.clEmpoyeeMH.HeaderText = "Mã Hàng";
            this.clEmpoyeeMH.MinimumWidth = 6;
            this.clEmpoyeeMH.Name = "clEmpoyeeMH";
            this.clEmpoyeeMH.ReadOnly = true;
            this.clEmpoyeeMH.Width = 125;
            // 
            // clEmpoyeeTenHang
            // 
            this.clEmpoyeeTenHang.DataPropertyName = "tenHang";
            this.clEmpoyeeTenHang.HeaderText = "Tên Hàng";
            this.clEmpoyeeTenHang.MinimumWidth = 6;
            this.clEmpoyeeTenHang.Name = "clEmpoyeeTenHang";
            this.clEmpoyeeTenHang.ReadOnly = true;
            this.clEmpoyeeTenHang.Width = 125;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "DVT";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 125;
            // 
            // clEmpoyeeDVT
            // 
            this.clEmpoyeeDVT.DataPropertyName = "Gia";
            this.clEmpoyeeDVT.HeaderText = "Giá";
            this.clEmpoyeeDVT.MinimumWidth = 6;
            this.clEmpoyeeDVT.Name = "clEmpoyeeDVT";
            this.clEmpoyeeDVT.ReadOnly = true;
            this.clEmpoyeeDVT.Width = 125;
            // 
            // clEmpoyeeSL
            // 
            this.clEmpoyeeSL.DataPropertyName = "soLuong";
            this.clEmpoyeeSL.HeaderText = "Số Lượng";
            this.clEmpoyeeSL.MinimumWidth = 6;
            this.clEmpoyeeSL.Name = "clEmpoyeeSL";
            this.clEmpoyeeSL.ReadOnly = true;
            this.clEmpoyeeSL.Width = 125;
            // 
            // clEmpoyeeNCC
            // 
            this.clEmpoyeeNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clEmpoyeeNCC.DataPropertyName = "NCC";
            this.clEmpoyeeNCC.HeaderText = "Nhà Cung Cấp";
            this.clEmpoyeeNCC.MinimumWidth = 6;
            this.clEmpoyeeNCC.Name = "clEmpoyeeNCC";
            this.clEmpoyeeNCC.ReadOnly = true;
            // 
            // DSMatHangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 658);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DSMatHangForm";
            this.Text = "QLMatHangForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSMH)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvDSMH;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttXemDS;
        private System.Windows.Forms.Button bttXoaMH;
        private System.Windows.Forms.Button bttSuaMH;
        private System.Windows.Forms.Button bttThemMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpoyeeMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpoyeeTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpoyeeDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpoyeeSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn clEmpoyeeNCC;
    }
}

