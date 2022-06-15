﻿
namespace QuanLySinhVien
{
    partial class FrmMonHoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMonHoc));
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.ColMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(156, 28);
            this.cbKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(160, 24);
            this.cbKhoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn khoa";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(369, 26);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 34);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dgvMon
            // 
            this.dgvMon.AllowUserToDeleteRows = false;
            this.dgvMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaMon,
            this.ColTenMon,
            this.ColSoTC});
            this.dgvMon.Location = new System.Drawing.Point(39, 68);
            this.dgvMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.ReadOnly = true;
            this.dgvMon.RowHeadersWidth = 51;
            this.dgvMon.Size = new System.Drawing.Size(431, 230);
            this.dgvMon.TabIndex = 3;
            // 
            // ColMaMon
            // 
            this.ColMaMon.DataPropertyName = "MaMon";
            this.ColMaMon.HeaderText = "Mã môn";
            this.ColMaMon.MinimumWidth = 6;
            this.ColMaMon.Name = "ColMaMon";
            this.ColMaMon.ReadOnly = true;
            this.ColMaMon.Width = 125;
            // 
            // ColTenMon
            // 
            this.ColTenMon.DataPropertyName = "TenMon";
            this.ColTenMon.HeaderText = "Tên môn";
            this.ColTenMon.MinimumWidth = 6;
            this.ColTenMon.Name = "ColTenMon";
            this.ColTenMon.ReadOnly = true;
            this.ColTenMon.Width = 125;
            // 
            // ColSoTC
            // 
            this.ColSoTC.DataPropertyName = "SoTinChi";
            this.ColSoTC.HeaderText = "Số tín chỉ";
            this.ColSoTC.MinimumWidth = 6;
            this.ColSoTC.Name = "ColSoTC";
            this.ColSoTC.ReadOnly = true;
            this.ColSoTC.Width = 125;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(350, 322);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 31);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(512, 366);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKhoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn học";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DataGridView dgvMon;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoTC;
    }
}