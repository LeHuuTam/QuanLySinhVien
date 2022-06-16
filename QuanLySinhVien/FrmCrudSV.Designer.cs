
namespace QuanLySinhVien
{
    partial class FrmCrudSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrudSV));
            this.lblfrmcrudSV = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.textBox_MaSV = new System.Windows.Forms.TextBox();
            this.textBox_NgaySinh = new System.Windows.Forms.TextBox();
            this.textBox_Khoa = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.comboBox_GioiTinh = new System.Windows.Forms.ComboBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.grdview_ttSV = new System.Windows.Forms.DataGridView();
            this.MaSv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdview_ttSV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfrmcrudSV
            // 
            this.lblfrmcrudSV.BackColor = System.Drawing.Color.SteelBlue;
            this.lblfrmcrudSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblfrmcrudSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrmcrudSV.Location = new System.Drawing.Point(0, 0);
            this.lblfrmcrudSV.Name = "lblfrmcrudSV";
            this.lblfrmcrudSV.Size = new System.Drawing.Size(932, 67);
            this.lblfrmcrudSV.TabIndex = 0;
            this.lblfrmcrudSV.Text = "Thông tin sinh viên";
            this.lblfrmcrudSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 67);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btn_Xoa);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Sua);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Them);
            this.splitContainer1.Panel1.Controls.Add(this.lblGioiTinh);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_GioiTinh);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_HoTen);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Khoa);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_NgaySinh);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_MaSV);
            this.splitContainer1.Panel1.Controls.Add(this.lblKhoa);
            this.splitContainer1.Panel1.Controls.Add(this.lblNgaySinh);
            this.splitContainer1.Panel1.Controls.Add(this.lblHoTen);
            this.splitContainer1.Panel1.Controls.Add(this.lblMaSV);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            this.splitContainer1.Panel1MinSize = 15;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.grdview_ttSV);
            this.splitContainer1.Size = new System.Drawing.Size(932, 420);
            this.splitContainer1.SplitterDistance = 216;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(39, 17);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(71, 24);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã SV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(39, 51);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(72, 24);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ tên";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(38, 85);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(103, 24);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhoa.Location = new System.Drawing.Point(39, 124);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(58, 24);
            this.lblKhoa.TabIndex = 3;
            this.lblKhoa.Text = "Khoa";
            // 
            // textBox_MaSV
            // 
            this.textBox_MaSV.Location = new System.Drawing.Point(181, 19);
            this.textBox_MaSV.Name = "textBox_MaSV";
            this.textBox_MaSV.Size = new System.Drawing.Size(356, 22);
            this.textBox_MaSV.TabIndex = 4;
            // 
            // textBox_NgaySinh
            // 
            this.textBox_NgaySinh.Location = new System.Drawing.Point(181, 87);
            this.textBox_NgaySinh.Name = "textBox_NgaySinh";
            this.textBox_NgaySinh.Size = new System.Drawing.Size(356, 22);
            this.textBox_NgaySinh.TabIndex = 5;
            // 
            // textBox_Khoa
            // 
            this.textBox_Khoa.Location = new System.Drawing.Point(181, 126);
            this.textBox_Khoa.Name = "textBox_Khoa";
            this.textBox_Khoa.Size = new System.Drawing.Size(356, 22);
            this.textBox_Khoa.TabIndex = 6;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(181, 53);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(356, 22);
            this.textBox_HoTen.TabIndex = 7;
            // 
            // comboBox_GioiTinh
            // 
            this.comboBox_GioiTinh.FormattingEnabled = true;
            this.comboBox_GioiTinh.Location = new System.Drawing.Point(181, 164);
            this.comboBox_GioiTinh.Name = "comboBox_GioiTinh";
            this.comboBox_GioiTinh.Size = new System.Drawing.Size(356, 24);
            this.comboBox_GioiTinh.TabIndex = 8;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(39, 162);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(87, 24);
            this.lblGioiTinh.TabIndex = 9;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Lime;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(611, 17);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(117, 48);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(611, 85);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(117, 48);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(611, 151);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(117, 48);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // grdview_ttSV
            // 
            this.grdview_ttSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdview_ttSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdview_ttSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSv,
            this.HoTen,
            this.NgaySinh,
            this.Khoa,
            this.Nu});
            this.grdview_ttSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdview_ttSV.Location = new System.Drawing.Point(0, 0);
            this.grdview_ttSV.Name = "grdview_ttSV";
            this.grdview_ttSV.RowHeadersWidth = 51;
            this.grdview_ttSV.RowTemplate.Height = 24;
            this.grdview_ttSV.Size = new System.Drawing.Size(932, 200);
            this.grdview_ttSV.TabIndex = 0;
            // 
            // MaSv
            // 
            this.MaSv.DataPropertyName = "MaSV";
            this.MaSv.HeaderText = "Mã SV";
            this.MaSv.MaxInputLength = 10;
            this.MaSv.MinimumWidth = 6;
            this.MaSv.Name = "MaSv";
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
            this.Khoa.DataPropertyName = "MaKhoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MaxInputLength = 20;
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            // 
            // Nu
            // 
            this.Nu.DataPropertyName = "GioiTinh";
            this.Nu.HeaderText = "Nữ";
            this.Nu.MinimumWidth = 6;
            this.Nu.Name = "Nu";
            // 
            // FrmCrudSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 487);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblfrmcrudSV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCrudSV";
            this.Text = "Thông tin sinh viên";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdview_ttSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblfrmcrudSV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.ComboBox comboBox_GioiTinh;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.TextBox textBox_Khoa;
        private System.Windows.Forms.TextBox textBox_NgaySinh;
        private System.Windows.Forms.TextBox textBox_MaSV;
        private System.Windows.Forms.DataGridView grdview_ttSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSv;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nu;
    }
}