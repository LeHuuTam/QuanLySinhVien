
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
            this.lbl_MaGV = new System.Windows.Forms.Label();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.lbl_NgaySinh = new System.Windows.Forms.Label();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.lbl_GioiTinh = new System.Windows.Forms.Label();
            this.textBox_MaGV = new System.Windows.Forms.TextBox();
            this.textBox_Khoa = new System.Windows.Forms.TextBox();
            this.textBox_NgaySinh = new System.Windows.Forms.TextBox();
            this.textBox_HoTen = new System.Windows.Forms.TextBox();
            this.comboBox_GioiTinh = new System.Windows.Forms.ComboBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nu = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcrudGV
            // 
            this.lblcrudGV.BackColor = System.Drawing.Color.Orchid;
            this.lblcrudGV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcrudGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrudGV.Location = new System.Drawing.Point(0, 0);
            this.lblcrudGV.Name = "lblcrudGV";
            this.lblcrudGV.Size = new System.Drawing.Size(800, 66);
            this.lblcrudGV.TabIndex = 0;
            this.lblcrudGV.Text = "Thông tin giảng viên";
            this.lblcrudGV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.btn_Xoa);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Sua);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Them);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_GioiTinh);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_HoTen);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_NgaySinh);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Khoa);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_MaGV);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_GioiTinh);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Khoa);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_NgaySinh);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_HoTen);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_MaGV);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 476);
            this.splitContainer1.SplitterDistance = 280;
            this.splitContainer1.TabIndex = 1;
            // 
            // lbl_MaGV
            // 
            this.lbl_MaGV.AutoSize = true;
            this.lbl_MaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaGV.Location = new System.Drawing.Point(21, 38);
            this.lbl_MaGV.Name = "lbl_MaGV";
            this.lbl_MaGV.Size = new System.Drawing.Size(73, 24);
            this.lbl_MaGV.TabIndex = 0;
            this.lbl_MaGV.Text = "Mã GV";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_HoTen.Location = new System.Drawing.Point(21, 78);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(72, 24);
            this.lbl_HoTen.TabIndex = 1;
            this.lbl_HoTen.Text = "Họ tên";
            // 
            // lbl_NgaySinh
            // 
            this.lbl_NgaySinh.AutoSize = true;
            this.lbl_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgaySinh.Location = new System.Drawing.Point(21, 114);
            this.lbl_NgaySinh.Name = "lbl_NgaySinh";
            this.lbl_NgaySinh.Size = new System.Drawing.Size(103, 24);
            this.lbl_NgaySinh.TabIndex = 2;
            this.lbl_NgaySinh.Text = "Ngày sinh";
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Khoa.Location = new System.Drawing.Point(21, 151);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(58, 24);
            this.lbl_Khoa.TabIndex = 3;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // lbl_GioiTinh
            // 
            this.lbl_GioiTinh.AutoSize = true;
            this.lbl_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GioiTinh.Location = new System.Drawing.Point(21, 190);
            this.lbl_GioiTinh.Name = "lbl_GioiTinh";
            this.lbl_GioiTinh.Size = new System.Drawing.Size(87, 24);
            this.lbl_GioiTinh.TabIndex = 4;
            this.lbl_GioiTinh.Text = "Giới tính";
            // 
            // textBox_MaGV
            // 
            this.textBox_MaGV.Location = new System.Drawing.Point(172, 40);
            this.textBox_MaGV.Name = "textBox_MaGV";
            this.textBox_MaGV.Size = new System.Drawing.Size(352, 22);
            this.textBox_MaGV.TabIndex = 5;
            // 
            // textBox_Khoa
            // 
            this.textBox_Khoa.Location = new System.Drawing.Point(172, 153);
            this.textBox_Khoa.Name = "textBox_Khoa";
            this.textBox_Khoa.Size = new System.Drawing.Size(352, 22);
            this.textBox_Khoa.TabIndex = 6;
            // 
            // textBox_NgaySinh
            // 
            this.textBox_NgaySinh.Location = new System.Drawing.Point(172, 116);
            this.textBox_NgaySinh.Name = "textBox_NgaySinh";
            this.textBox_NgaySinh.Size = new System.Drawing.Size(352, 22);
            this.textBox_NgaySinh.TabIndex = 7;
            // 
            // textBox_HoTen
            // 
            this.textBox_HoTen.Location = new System.Drawing.Point(172, 80);
            this.textBox_HoTen.Name = "textBox_HoTen";
            this.textBox_HoTen.Size = new System.Drawing.Size(352, 22);
            this.textBox_HoTen.TabIndex = 8;
            // 
            // comboBox_GioiTinh
            // 
            this.comboBox_GioiTinh.FormattingEnabled = true;
            this.comboBox_GioiTinh.Location = new System.Drawing.Point(172, 188);
            this.comboBox_GioiTinh.Name = "comboBox_GioiTinh";
            this.comboBox_GioiTinh.Size = new System.Drawing.Size(352, 24);
            this.comboBox_GioiTinh.TabIndex = 9;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Lime;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(575, 40);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 48);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(575, 100);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 48);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(575, 164);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 48);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGV,
            this.HoTen,
            this.NgaySinh,
            this.Khoa,
            this.Nu});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 192);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaGV
            // 
            this.MaGV.DataPropertyName = "MaGV";
            this.MaGV.HeaderText = "Mã GV";
            this.MaGV.MaxInputLength = 20;
            this.MaGV.MinimumWidth = 6;
            this.MaGV.Name = "MaGV";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.MaxInputLength = 50;
            this.HoTen.MinimumWidth = 6;
            this.HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.MaxInputLength = 20;
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "MaKhoa";
            this.Khoa.HeaderText = "Khoa";
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
            // FrmCrudGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 542);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblcrudGV);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCrudGV";
            this.Text = "Thông tin giảng viên";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblcrudGV;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_MaGV;
        private System.Windows.Forms.Label lbl_GioiTinh;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.Label lbl_NgaySinh;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.ComboBox comboBox_GioiTinh;
        private System.Windows.Forms.TextBox textBox_HoTen;
        private System.Windows.Forms.TextBox textBox_NgaySinh;
        private System.Windows.Forms.TextBox textBox_Khoa;
        private System.Windows.Forms.TextBox textBox_MaGV;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nu;
    }
}