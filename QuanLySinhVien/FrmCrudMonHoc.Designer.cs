
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
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.textBox_TenMH = new System.Windows.Forms.TextBox();
            this.textBox_SoTinChi = new System.Windows.Forms.TextBox();
            this.textBox_Khoa = new System.Windows.Forms.TextBox();
            this.textBox_MaMH = new System.Windows.Forms.TextBox();
            this.lbl_Khoa = new System.Windows.Forms.Label();
            this.lbl_SoTinChi = new System.Windows.Forms.Label();
            this.lbl_TenMH = new System.Windows.Forms.Label();
            this.lbl_MaMH = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCrudMonHoc
            // 
            this.lblCrudMonHoc.BackColor = System.Drawing.Color.SpringGreen;
            this.lblCrudMonHoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCrudMonHoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrudMonHoc.ForeColor = System.Drawing.Color.Black;
            this.lblCrudMonHoc.Location = new System.Drawing.Point(0, 0);
            this.lblCrudMonHoc.Name = "lblCrudMonHoc";
            this.lblCrudMonHoc.Size = new System.Drawing.Size(844, 69);
            this.lblCrudMonHoc.TabIndex = 0;
            this.lblCrudMonHoc.Text = "Thông tin môn học";
            this.lblCrudMonHoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 69);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.splitContainer1.Panel1.Controls.Add(this.btn_Xoa);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Sua);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Them);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_TenMH);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_SoTinChi);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Khoa);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_MaMH);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_Khoa);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_SoTinChi);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_TenMH);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_MaMH);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(844, 408);
            this.splitContainer1.SplitterDistance = 263;
            this.splitContainer1.TabIndex = 1;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Red;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(640, 169);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(119, 48);
            this.btn_Xoa.TabIndex = 25;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.Yellow;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(640, 105);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(119, 48);
            this.btn_Sua.TabIndex = 24;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.Lime;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(640, 45);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(119, 48);
            this.btn_Them.TabIndex = 23;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // textBox_TenMH
            // 
            this.textBox_TenMH.Location = new System.Drawing.Point(237, 85);
            this.textBox_TenMH.Name = "textBox_TenMH";
            this.textBox_TenMH.Size = new System.Drawing.Size(352, 22);
            this.textBox_TenMH.TabIndex = 21;
            // 
            // textBox_SoTinChi
            // 
            this.textBox_SoTinChi.Location = new System.Drawing.Point(237, 121);
            this.textBox_SoTinChi.Name = "textBox_SoTinChi";
            this.textBox_SoTinChi.Size = new System.Drawing.Size(352, 22);
            this.textBox_SoTinChi.TabIndex = 20;
            // 
            // textBox_Khoa
            // 
            this.textBox_Khoa.Location = new System.Drawing.Point(237, 158);
            this.textBox_Khoa.Name = "textBox_Khoa";
            this.textBox_Khoa.Size = new System.Drawing.Size(352, 22);
            this.textBox_Khoa.TabIndex = 19;
            // 
            // textBox_MaMH
            // 
            this.textBox_MaMH.Location = new System.Drawing.Point(237, 45);
            this.textBox_MaMH.Name = "textBox_MaMH";
            this.textBox_MaMH.Size = new System.Drawing.Size(352, 22);
            this.textBox_MaMH.TabIndex = 18;
            // 
            // lbl_Khoa
            // 
            this.lbl_Khoa.AutoSize = true;
            this.lbl_Khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Khoa.Location = new System.Drawing.Point(86, 156);
            this.lbl_Khoa.Name = "lbl_Khoa";
            this.lbl_Khoa.Size = new System.Drawing.Size(58, 24);
            this.lbl_Khoa.TabIndex = 16;
            this.lbl_Khoa.Text = "Khoa";
            // 
            // lbl_SoTinChi
            // 
            this.lbl_SoTinChi.AutoSize = true;
            this.lbl_SoTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoTinChi.Location = new System.Drawing.Point(86, 119);
            this.lbl_SoTinChi.Name = "lbl_SoTinChi";
            this.lbl_SoTinChi.Size = new System.Drawing.Size(97, 24);
            this.lbl_SoTinChi.TabIndex = 15;
            this.lbl_SoTinChi.Text = "Số tín chỉ";
            // 
            // lbl_TenMH
            // 
            this.lbl_TenMH.AutoSize = true;
            this.lbl_TenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenMH.Location = new System.Drawing.Point(86, 83);
            this.lbl_TenMH.Name = "lbl_TenMH";
            this.lbl_TenMH.Size = new System.Drawing.Size(85, 24);
            this.lbl_TenMH.TabIndex = 14;
            this.lbl_TenMH.Text = "Tên MH";
            // 
            // lbl_MaMH
            // 
            this.lbl_MaMH.AutoSize = true;
            this.lbl_MaMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MaMH.Location = new System.Drawing.Point(86, 43);
            this.lbl_MaMH.Name = "lbl_MaMH";
            this.lbl_MaMH.Size = new System.Drawing.Size(76, 24);
            this.lbl_MaMH.TabIndex = 13;
            this.lbl_MaMH.Text = "Mã MH";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.SoTinChi,
            this.Khoa});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(844, 141);
            this.dataGridView1.TabIndex = 0;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMon";
            this.MaMH.HeaderText = "Mã môn";
            this.MaMH.MaxInputLength = 20;
            this.MaMH.MinimumWidth = 6;
            this.MaMH.Name = "MaMH";
            // 
            // TenMH
            // 
            this.TenMH.DataPropertyName = "TenMon";
            this.TenMH.HeaderText = "Tên môn";
            this.TenMH.MaxInputLength = 50;
            this.TenMH.MinimumWidth = 6;
            this.TenMH.Name = "TenMH";
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
            this.Khoa.DataPropertyName = "MaKhoa";
            this.Khoa.HeaderText = "Khoa";
            this.Khoa.MaxInputLength = 20;
            this.Khoa.MinimumWidth = 6;
            this.Khoa.Name = "Khoa";
            // 
            // FrmCrudMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 477);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblCrudMonHoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCrudMonHoc";
            this.Text = "Thông tin môn học";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCrudMonHoc;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TextBox textBox_TenMH;
        private System.Windows.Forms.TextBox textBox_SoTinChi;
        private System.Windows.Forms.TextBox textBox_Khoa;
        private System.Windows.Forms.TextBox textBox_MaMH;
        private System.Windows.Forms.Label lbl_Khoa;
        private System.Windows.Forms.Label lbl_SoTinChi;
        private System.Windows.Forms.Label lbl_TenMH;
        private System.Windows.Forms.Label lbl_MaMH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoTinChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Khoa;
    }
}