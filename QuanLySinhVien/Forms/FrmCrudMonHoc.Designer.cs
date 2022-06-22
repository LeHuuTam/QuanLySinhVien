
namespace QuanLySinhVien
{
    partial class FrmCrudMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCrudMonHoc));
            this.lblCrudMonHoc = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numSoTC = new System.Windows.Forms.NumericUpDown();
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.textBox_TenMH = new System.Windows.Forms.TextBox();
            this.textBox_MaMH = new System.Windows.Forms.TextBox();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.lbl_SoTinChi = new System.Windows.Forms.Label();
            this.lbl_TenMH = new System.Windows.Forms.Label();
            this.lbl_MaMH = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.MaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCrudMonHoc
            // 
            this.lblCrudMonHoc.BackColor = System.Drawing.Color.SpringGreen;
            this.lblCrudMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCrudMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrudMonHoc.ForeColor = System.Drawing.Color.Black;
            this.lblCrudMonHoc.Location = new System.Drawing.Point(0, 0);
            this.lblCrudMonHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCrudMonHoc.Name = "lblCrudMonHoc";
            this.lblCrudMonHoc.Size = new System.Drawing.Size(633, 56);
            this.lblCrudMonHoc.TabIndex = 0;
            this.lblCrudMonHoc.Text = "Thông tin môn học";
            this.lblCrudMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 56);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.btnHuy);
            this.splitContainer1.Panel1.Controls.Add(this.btnThoat);
            this.splitContainer1.Panel1.Controls.Add(this.btnLuu);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Xoa);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Sua);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Them);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMon);
            this.splitContainer1.Size = new System.Drawing.Size(633, 419);
            this.splitContainer1.SplitterDistance = 175;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numSoTC);
            this.panel1.Controls.Add(this.cbKhoa);
            this.panel1.Controls.Add(this.textBox_TenMH);
            this.panel1.Controls.Add(this.textBox_MaMH);
            this.panel1.Controls.Add(this.lbl_Khoa);
            this.panel1.Controls.Add(this.lbl_SoTinChi);
            this.panel1.Controls.Add(this.lbl_TenMH);
            this.panel1.Controls.Add(this.lbl_MaMH);
            this.panel1.Location = new System.Drawing.Point(12, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 147);
            this.panel1.TabIndex = 34;
            // 
            // numSoTC
            // 
            this.numSoTC.Location = new System.Drawing.Point(137, 78);
            this.numSoTC.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numSoTC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoTC.Name = "numSoTC";
            this.numSoTC.Size = new System.Drawing.Size(120, 20);
            this.numSoTC.TabIndex = 35;
            this.numSoTC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(137, 108);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(200, 21);
            this.cbKhoa.TabIndex = 34;
            // 
            // textBox_TenMH
            // 
            this.textBox_TenMH.Location = new System.Drawing.Point(137, 50);
            this.textBox_TenMH.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TenMH.Name = "textBox_TenMH";
            this.textBox_TenMH.Size = new System.Drawing.Size(200, 20);
            this.textBox_TenMH.TabIndex = 33;
            // 
            // textBox_MaMH
            // 
            this.textBox_MaMH.Location = new System.Drawing.Point(137, 18);
            this.textBox_MaMH.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_MaMH.Name = "textBox_MaMH";
            this.textBox_MaMH.Size = new System.Drawing.Size(200, 20);
            this.textBox_MaMH.TabIndex = 32;
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Khoa.Location = new System.Drawing.Point(23, 108);
            this.lbl_Khoa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(47, 18);
            this.lbl_Khoa.TabIndex = 31;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // lbl_SoTinChi
            // 
            this.lbl_SoTinChi.AutoSize = true;
            this.lbl_SoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTinChi.Location = new System.Drawing.Point(23, 78);
            this.lbl_SoTinChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SoTinChi.Name = "lbl_SoTinChi";
            this.lbl_SoTinChi.Size = new System.Drawing.Size(79, 18);
            this.lbl_SoTinChi.TabIndex = 30;
            this.lbl_SoTinChi.Text = "Số tín chỉ";
            // 
            // lbl_TenMH
            // 
            this.lbl_TenMH.AutoSize = true;
            this.lbl_TenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenMH.Location = new System.Drawing.Point(23, 48);
            this.lbl_TenMH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TenMH.Name = "lbl_TenMH";
            this.lbl_TenMH.Size = new System.Drawing.Size(67, 18);
            this.lbl_TenMH.TabIndex = 29;
            this.lbl_TenMH.Text = "Tên MH";
            // 
            // lbl_MaMH
            // 
            this.lbl_MaMH.AutoSize = true;
            this.lbl_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaMH.Location = new System.Drawing.Point(23, 16);
            this.lbl_MaMH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MaMH.Name = "lbl_MaMH";
            this.lbl_MaMH.Size = new System.Drawing.Size(62, 18);
            this.lbl_MaMH.TabIndex = 28;
            this.lbl_MaMH.Text = "Mã MH";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Yellow;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(527, 71);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(88, 39);
            this.btnHuy.TabIndex = 33;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Red;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(527, 125);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 39);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Lime;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(527, 17);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(88, 39);
            this.btnLuu.TabIndex = 31;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(404, 125);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(88, 39);
            this.btn_Xoa.TabIndex = 30;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(404, 71);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(88, 39);
            this.btn_Sua.TabIndex = 29;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Lime;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(404, 16);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(88, 39);
            this.btn_Them.TabIndex = 28;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // dgvMon
            // 
            this.dgvMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMon,
            this.TenMon,
            this.SoTinChi,
            this.Khoa});
            this.dgvMon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMon.Location = new System.Drawing.Point(0, 0);
            this.dgvMon.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.RowHeadersWidth = 51;
            this.dgvMon.RowTemplate.Height = 24;
            this.dgvMon.Size = new System.Drawing.Size(633, 241);
            this.dgvMon.TabIndex = 0;
            // 
            // MaMon
            // 
            this.MaMon.DataPropertyName = "MaMon";
            this.MaMon.HeaderText = "Mã môn";
            this.MaMon.MaxInputLength = 20;
            this.MaMon.MinimumWidth = 6;
            this.MaMon.Name = "MaMon";
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên môn";
            this.TenMon.MaxInputLength = 50;
            this.TenMon.MinimumWidth = 6;
            this.TenMon.Name = "TenMon";
            // 
            // SoTinChi
            // 
            this.SoTinChi.DataPropertyName = "SoTinChi";
            this.SoTinChi.HeaderText = "Số tín chỉ";
            this.SoTinChi.MaxInputLength = 2;
            this.SoTinChi.MinimumWidth = 6;
            this.SoTinChi.Name = "SoTinChi";
            // 
            // Khoa
            // 
            this.Khoa.DataPropertyName = "Khoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MaxInputLength = 20;
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            // 
            // FrmCrudMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 475);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblCrudMonHoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmCrudMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin môn học";
            this.Load += new System.EventHandler(this.FrmCrudMonHoc_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCrudMonHoc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numSoTC;
        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.TextBox textBox_TenMH;
        private System.Windows.Forms.TextBox textBox_MaMH;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.Label lbl_SoTinChi;
        private System.Windows.Forms.Label lbl_TenMH;
        private System.Windows.Forms.Label lbl_MaMH;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    }
}