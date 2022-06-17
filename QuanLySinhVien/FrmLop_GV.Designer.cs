
namespace QuanLySinhVien
{
    partial class FrmLop_GV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLop_GV));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnChonMon = new System.Windows.Forms.Button();
            this.dgvDSLop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnChonLop = new System.Windows.Forms.Button();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDSSV = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMaSV = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txbCK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbGK = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Gender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_DateOfB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_GiuaKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChonMon);
            this.tabPage1.Controls.Add(this.dgvDSLop);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbMon);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(594, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnChonMon
            // 
            this.btnChonMon.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChonMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonMon.Location = new System.Drawing.Point(242, 20);
            this.btnChonMon.Name = "btnChonMon";
            this.btnChonMon.Size = new System.Drawing.Size(91, 27);
            this.btnChonMon.TabIndex = 1;
            this.btnChonMon.Text = "OK";
            this.btnChonMon.UseVisualStyleBackColor = false;
            this.btnChonMon.Click += new System.EventHandler(this.btnChonMon_Click);
            // 
            // dgvDSLop
            // 
            this.dgvDSLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvDSLop.Location = new System.Drawing.Point(9, 56);
            this.dgvDSLop.Name = "dgvDSLop";
            this.dgvDSLop.RowHeadersWidth = 51;
            this.dgvDSLop.Size = new System.Drawing.Size(590, 248);
            this.dgvDSLop.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLop";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayBatDau";
            this.Column2.HeaderText = "Ngày bắt đầu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayKetThuc";
            this.Column3.HeaderText = "Ngày kết thúc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn môn";
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(108, 23);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(121, 21);
            this.cbMon.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnFile);
            this.tabPage2.Controls.Add(this.txbGK);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txbCK);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.btnLuu);
            this.tabPage2.Controls.Add(this.txbMaSV);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnChonLop);
            this.tabPage2.Controls.Add(this.cbLop);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dgvDSSV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(767, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách sinh viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnChonLop
            // 
            this.btnChonLop.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChonLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonLop.Location = new System.Drawing.Point(345, 18);
            this.btnChonLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChonLop.Name = "btnChonLop";
            this.btnChonLop.Size = new System.Drawing.Size(86, 27);
            this.btnChonLop.TabIndex = 3;
            this.btnChonLop.Text = "OK";
            this.btnChonLop.UseVisualStyleBackColor = false;
            this.btnChonLop.Click += new System.EventHandler(this.btnChonLop_Click);
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(116, 21);
            this.cbLop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(199, 21);
            this.cbLop.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn lớp";
            // 
            // dgvDSSV
            // 
            this.dgvDSSV.AllowUserToAddRows = false;
            this.dgvDSSV.AllowUserToDeleteRows = false;
            this.dgvDSSV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.Col_HoTen,
            this.Col_Gender,
            this.Col_DateOfB,
            this.Col_Khoa,
            this.Col_GiuaKi,
            this.Col_CuoiKy,
            this.Col_TB});
            this.dgvDSSV.Location = new System.Drawing.Point(0, 123);
            this.dgvDSSV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDSSV.Name = "dgvDSSV";
            this.dgvDSSV.RowHeadersWidth = 51;
            this.dgvDSSV.RowTemplate.Height = 24;
            this.dgvDSSV.Size = new System.Drawing.Size(769, 272);
            this.dgvDSSV.TabIndex = 0;
            this.dgvDSSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSV_CellClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(708, 457);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã sinh viên";
            // 
            // txbMaSV
            // 
            this.txbMaSV.Location = new System.Drawing.Point(106, 77);
            this.txbMaSV.Name = "txbMaSV";
            this.txbMaSV.ReadOnly = true;
            this.txbMaSV.Size = new System.Drawing.Size(109, 20);
            this.txbMaSV.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(584, 72);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(86, 27);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Text = "Lưu điểm";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txbCK
            // 
            this.txbCK.Location = new System.Drawing.Point(477, 77);
            this.txbCK.Name = "txbCK";
            this.txbCK.Size = new System.Drawing.Size(86, 20);
            this.txbCK.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cuối kỳ";
            // 
            // txbGK
            // 
            this.txbGK.Location = new System.Drawing.Point(297, 77);
            this.txbGK.Name = "txbGK";
            this.txbGK.Size = new System.Drawing.Size(86, 20);
            this.txbGK.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(230, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Giữa kỳ";
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "MaSV";
            this.MaSV.HeaderText = "Mã Sinh Viên";
            this.MaSV.MaxInputLength = 10;
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // Col_HoTen
            // 
            this.Col_HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Col_HoTen.DataPropertyName = "HoTen";
            this.Col_HoTen.HeaderText = "Họ Tên ";
            this.Col_HoTen.MaxInputLength = 50;
            this.Col_HoTen.MinimumWidth = 6;
            this.Col_HoTen.Name = "Col_HoTen";
            this.Col_HoTen.Width = 71;
            // 
            // Col_Gender
            // 
            this.Col_Gender.DataPropertyName = "GioiTinh";
            this.Col_Gender.HeaderText = "Nữ";
            this.Col_Gender.MinimumWidth = 6;
            this.Col_Gender.Name = "Col_Gender";
            this.Col_Gender.Width = 125;
            // 
            // Col_DateOfB
            // 
            this.Col_DateOfB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Col_DateOfB.DataPropertyName = "NgaySinh";
            this.Col_DateOfB.HeaderText = "Ngày Sinh";
            this.Col_DateOfB.MaxInputLength = 12;
            this.Col_DateOfB.MinimumWidth = 6;
            this.Col_DateOfB.Name = "Col_DateOfB";
            this.Col_DateOfB.Width = 81;
            // 
            // Col_Khoa
            // 
            this.Col_Khoa.DataPropertyName = "Khoa";
            this.Col_Khoa.HeaderText = "Khoa";
            this.Col_Khoa.MaxInputLength = 10;
            this.Col_Khoa.MinimumWidth = 6;
            this.Col_Khoa.Name = "Col_Khoa";
            this.Col_Khoa.Width = 125;
            // 
            // Col_GiuaKi
            // 
            this.Col_GiuaKi.DataPropertyName = "Giuaky";
            this.Col_GiuaKi.HeaderText = "Giữa Kì";
            this.Col_GiuaKi.MaxInputLength = 4;
            this.Col_GiuaKi.MinimumWidth = 6;
            this.Col_GiuaKi.Name = "Col_GiuaKi";
            this.Col_GiuaKi.Width = 60;
            // 
            // Col_CuoiKy
            // 
            this.Col_CuoiKy.DataPropertyName = "CuoiKy";
            this.Col_CuoiKy.HeaderText = "Cuối Kì";
            this.Col_CuoiKy.MaxInputLength = 4;
            this.Col_CuoiKy.MinimumWidth = 6;
            this.Col_CuoiKy.Name = "Col_CuoiKy";
            this.Col_CuoiKy.Width = 60;
            // 
            // Col_TB
            // 
            this.Col_TB.DataPropertyName = "TrungBinh";
            this.Col_TB.HeaderText = "Trung Bình";
            this.Col_TB.MaxInputLength = 4;
            this.Col_TB.MinimumWidth = 6;
            this.Col_TB.Name = "Col_TB";
            this.Col_TB.Width = 60;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(679, 72);
            this.btnFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(86, 27);
            this.btnFile.TabIndex = 11;
            this.btnFile.Text = "Lưu file";
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // FrmLop_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(799, 507);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLop_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLop_GV_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLop)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChonMon;
        private System.Windows.Forms.DataGridView dgvDSLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView dgvDSSV;
        private System.Windows.Forms.Label label2;
        //private QuanLySinhVienDataSet quanLySinhVienDataSet;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.Button btnChonLop;
        private System.Windows.Forms.TextBox txbGK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txbMaSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_HoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DateOfB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_GiuaKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TB;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}