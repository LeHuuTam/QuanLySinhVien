
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLop_GV));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOK = new System.Windows.Forms.Button();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMon = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThoat = new System.Windows.Forms.Button();
            this.DSSV_view = new System.Windows.Forms.DataGridView();
            //this.quanLySinhVienDataSet = new QuanLySinhVien.QuanLySinhVienDataSet();
            this.quanLySinhVienDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_SelectSV = new System.Windows.Forms.Button();
            this.Col_MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Gender = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Col_DateOfB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_GiuaKi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CuoiKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_TB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSSV_view)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 524);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnOK);
            this.tabPage1.Controls.Add(this.dgvLop);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbMon);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(795, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Danh sách lớp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(323, 24);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 33);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLop.Location = new System.Drawing.Point(12, 69);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.Size = new System.Drawing.Size(787, 305);
            this.dgvLop.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLop";
            this.Column1.HeaderText = "Mã lớp";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NgayBatDau";
            this.Column2.HeaderText = "Ngày bắt đầu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayKetThuc";
            this.Column3.HeaderText = "Ngày kết thúc";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn môn";
            // 
            // cbMon
            // 
            this.cbMon.FormattingEnabled = true;
            this.cbMon.Location = new System.Drawing.Point(144, 28);
            this.cbMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMon.Name = "cbMon";
            this.cbMon.Size = new System.Drawing.Size(160, 24);
            this.cbMon.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_SelectSV);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.DSSV_view);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(795, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách sinh viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(800, 570);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DSSV_view
            // 
            this.DSSV_view.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DSSV_view.AutoGenerateColumns = false;
            this.DSSV_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DSSV_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaSV,
            this.Col_HoTen,
            this.Col_Gender,
            this.Col_DateOfB,
            this.Col_Khoa,
            this.Col_GiuaKi,
            this.Col_CuoiKy,
            this.Col_TB});
            this.DSSV_view.DataSource = this.quanLySinhVienDataSetBindingSource;
            this.DSSV_view.Location = new System.Drawing.Point(0, 87);
            this.DSSV_view.Name = "DSSV_view";
            this.DSSV_view.RowHeadersWidth = 51;
            this.DSSV_view.RowTemplate.Height = 24;
            this.DSSV_view.Size = new System.Drawing.Size(795, 412);
            this.DSSV_view.TabIndex = 0;
            // 
            // quanLySinhVienDataSet
            // 
            //this.quanLySinhVienDataSet.DataSetName = "QuanLySinhVienDataSet";
            //this.quanLySinhVienDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            //// 
            // quanLySinhVienDataSetBindingSource
            // 
            //this.quanLySinhVienDataSetBindingSource.DataSource = this.quanLySinhVienDataSet;
            this.quanLySinhVienDataSetBindingSource.Position = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn sinh viên";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(155, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(264, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // btn_SelectSV
            // 
            this.btn_SelectSV.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_SelectSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SelectSV.Location = new System.Drawing.Point(460, 22);
            this.btn_SelectSV.Name = "btn_SelectSV";
            this.btn_SelectSV.Size = new System.Drawing.Size(114, 33);
            this.btn_SelectSV.TabIndex = 3;
            this.btn_SelectSV.Text = "OK";
            this.btn_SelectSV.UseVisualStyleBackColor = false;
            // 
            // Col_MaSV
            // 
            this.Col_MaSV.HeaderText = "Mã Sinh Viên";
            this.Col_MaSV.MaxInputLength = 10;
            this.Col_MaSV.MinimumWidth = 6;
            this.Col_MaSV.Name = "Col_MaSV";
            this.Col_MaSV.ReadOnly = true;
            this.Col_MaSV.Width = 125;
            // 
            // Col_HoTen
            // 
            this.Col_HoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Col_HoTen.HeaderText = "Họ Tên ";
            this.Col_HoTen.MaxInputLength = 50;
            this.Col_HoTen.MinimumWidth = 6;
            this.Col_HoTen.Name = "Col_HoTen";
            this.Col_HoTen.Width = 88;
            // 
            // Col_Gender
            // 
            this.Col_Gender.HeaderText = "Nữ";
            this.Col_Gender.MinimumWidth = 6;
            this.Col_Gender.Name = "Col_Gender";
            this.Col_Gender.Width = 125;
            // 
            // Col_DateOfB
            // 
            this.Col_DateOfB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Col_DateOfB.HeaderText = "Ngày Sinh";
            this.Col_DateOfB.MaxInputLength = 12;
            this.Col_DateOfB.MinimumWidth = 6;
            this.Col_DateOfB.Name = "Col_DateOfB";
            this.Col_DateOfB.Width = 102;
            // 
            // Col_Khoa
            // 
            this.Col_Khoa.HeaderText = "Khoa";
            this.Col_Khoa.MaxInputLength = 10;
            this.Col_Khoa.MinimumWidth = 6;
            this.Col_Khoa.Name = "Col_Khoa";
            this.Col_Khoa.Width = 125;
            // 
            // Col_GiuaKi
            // 
            this.Col_GiuaKi.HeaderText = "Giữa Kì";
            this.Col_GiuaKi.MaxInputLength = 4;
            this.Col_GiuaKi.MinimumWidth = 6;
            this.Col_GiuaKi.Name = "Col_GiuaKi";
            this.Col_GiuaKi.Width = 60;
            // 
            // Col_CuoiKy
            // 
            this.Col_CuoiKy.HeaderText = "Cuối Kì";
            this.Col_CuoiKy.MaxInputLength = 4;
            this.Col_CuoiKy.MinimumWidth = 6;
            this.Col_CuoiKy.Name = "Col_CuoiKy";
            this.Col_CuoiKy.Width = 60;
            // 
            // Col_TB
            // 
            this.Col_TB.HeaderText = "Trung Bình";
            this.Col_TB.MaxInputLength = 4;
            this.Col_TB.MinimumWidth = 6;
            this.Col_TB.Name = "Col_TB";
            this.Col_TB.Width = 60;
            // 
            // FrmLop_GV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 624);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmLop_GV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lớp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLop_GV_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSSV_view)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLySinhVienDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cbMon;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridView DSSV_view;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource quanLySinhVienDataSetBindingSource;
        //private QuanLySinhVienDataSet quanLySinhVienDataSet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_SelectSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_HoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Col_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DateOfB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_GiuaKi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CuoiKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_TB;
    }
}