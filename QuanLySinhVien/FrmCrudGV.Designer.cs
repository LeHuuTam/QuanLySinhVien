
namespace QuanLySinhVien
{
    partial class FrmCrudGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrudGV));
            this.lblcrudGV = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txbMk = new System.Windows.Forms.TextBox();
            this.txbTenDN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.textBox_MaGV = new System.Windows.Forms.TextBox();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgv_ttGV = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcrudGV
            // 
            this.lblcrudGV.BackColor = System.Drawing.Color.Orchid;
            this.lblcrudGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcrudGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrudGV.Location = new System.Drawing.Point(0, 0);
            this.lblcrudGV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcrudGV.Name = "lblcrudGV";
            this.lblcrudGV.Size = new System.Drawing.Size(779, 54);
            this.lblcrudGV.TabIndex = 0;
            this.lblcrudGV.Text = "Thông tin giảng viên";
            this.lblcrudGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 54);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnThoat);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Xoa);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Sua);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Them);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgv_ttGV);
            this.splitContainer1.Size = new System.Drawing.Size(779, 386);
            this.splitContainer1.SplitterDistance = 245;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbNam);
            this.panel1.Controls.Add(this.rbNu);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txbMk);
            this.panel1.Controls.Add(this.txbTenDN);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblGioiTinh);
            this.panel1.Controls.Add(this.cbKhoa);
            this.panel1.Controls.Add(this.textBox_HoTen);
            this.panel1.Controls.Add(this.textBox_MaGV);
            this.panel1.Controls.Add(this.lblKhoa);
            this.panel1.Controls.Add(this.lblNgaySinh);
            this.panel1.Controls.Add(this.lblHoTen);
            this.panel1.Controls.Add(this.lblMaSV);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 238);
            this.panel1.TabIndex = 18;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(220, 142);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(47, 17);
            this.rbNam.TabIndex = 28;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(137, 142);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(39, 17);
            this.rbNu.TabIndex = 27;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 74);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // txbMk
            // 
            this.txbMk.Location = new System.Drawing.Point(137, 205);
            this.txbMk.Margin = new System.Windows.Forms.Padding(2);
            this.txbMk.Name = "txbMk";
            this.txbMk.Size = new System.Drawing.Size(268, 20);
            this.txbMk.TabIndex = 25;
            // 
            // txbTenDN
            // 
            this.txbTenDN.Location = new System.Drawing.Point(137, 171);
            this.txbTenDN.Margin = new System.Windows.Forms.Padding(2);
            this.txbTenDN.Name = "txbTenDN";
            this.txbTenDN.Size = new System.Drawing.Size(268, 20);
            this.txbTenDN.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên đăng nhập";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(15, 136);
            this.lblGioiTinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(71, 18);
            this.lblGioiTinh.TabIndex = 19;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(137, 105);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(268, 21);
            this.cbKhoa.TabIndex = 18;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(137, 48);
            this.textBox_HoTen.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(268, 20);
            this.textBox_HoTen.TabIndex = 17;
            // 
            // textBox_MaGV
            // 
            this.textBox_MaGV.Location = new System.Drawing.Point(137, 20);
            this.textBox_MaGV.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MaGV.Name = "textBox_MaGV";
            this.textBox_MaGV.Size = new System.Drawing.Size(268, 20);
            this.textBox_MaGV.TabIndex = 14;
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(15, 105);
            this.lblKhoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(47, 18);
            this.lblKhoa.TabIndex = 13;
            this.lblKhoa.Text = "Khoa";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(14, 73);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(82, 18);
            this.lblNgaySinh.TabIndex = 12;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(15, 45);
            this.lblHoTen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 18);
            this.lblHoTen.TabIndex = 11;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(15, 18);
            this.lblMaSV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(59, 18);
            this.lblMaSV.TabIndex = 10;
            this.lblMaSV.Text = "Mã GV";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Yellow;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(606, 81);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 39);
            this.btnHuy.TabIndex = 24;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(606, 135);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 39);
            this.btnThoat.TabIndex = 23;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Lime;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(606, 27);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 39);
            this.btnLuu.TabIndex = 22;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(483, 135);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 39);
            this.btn_Xoa.TabIndex = 21;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(483, 81);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(88, 39);
            this.btn_Sua.TabIndex = 20;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Lime;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(483, 26);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(88, 39);
            this.btn_Them.TabIndex = 19;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dgv_ttGV
            // 
            this.dgv_ttGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ttGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ttGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTen,
            this.NgaySinh,
            this.Khoa,
            this.GioiTinh,
            this.TenDangNhap,
            this.MatKhau});
            this.dgv_ttGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ttGV.Location = new System.Drawing.Point(0, 0);
            this.dgv_ttGV.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ttGV.Name = "dgv_ttGV";
            this.dgv_ttGV.RowHeadersWidth = 51;
            this.dgv_ttGV.RowTemplate.Height = 24;
            this.dgv_ttGV.Size = new System.Drawing.Size(779, 138);
            this.dgv_ttGV.TabIndex = 1;
            this.dgv_ttGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ttGV_CellClick);
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.MaxInputLength = 10;
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MaxInputLength = 30;
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MaxInputLength = 20;
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Nữ";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            // 
            // TenDangNhap
            // 
            this.TenDangNhap.DataPropertyName = "TenDangNhap";
            this.TenDangNhap.HeaderText = "Tên đăng nhập";
            this.TenDangNhap.Name = "TenDangNhap";
            this.TenDangNhap.ReadOnly = true;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật khẩu";
            this.MatKhau.Name = "MatKhau";
            // 
            // FrmCrudGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 440);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblcrudGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmCrudGV";
            this.Text = "Thông tin giảng viên";
            this.Load += new System.EventHandler(this.FrmCrudGV_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ttGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcrudGV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txbMk;
        private System.Windows.Forms.TextBox txbTenDN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.TextBox textBox_MaGV;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridView dgv_ttGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
    }
}