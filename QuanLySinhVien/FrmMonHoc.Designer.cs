
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
            this.cbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXem = new System.Windows.Forms.Button();
            this.dgvMon = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.ColMaMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMon)).BeginInit();
            this.SuspendLayout();
            // 
            // cbKhoa
            // 
            this.cbKhoa.FormattingEnabled = true;
            this.cbKhoa.Location = new System.Drawing.Point(117, 23);
            this.cbKhoa.Name = "cbKhoa";
            this.cbKhoa.Size = new System.Drawing.Size(121, 21);
            this.cbKhoa.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn khoa";
            // 
            // btnXem
            // 
            this.btnXem.Location = new System.Drawing.Point(277, 21);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(75, 23);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = true;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dgvMon
            // 
            this.dgvMon.AllowUserToDeleteRows = false;
            this.dgvMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaMon,
            this.ColTenMon,
            this.ColSoTC});
            this.dgvMon.Location = new System.Drawing.Point(29, 55);
            this.dgvMon.Name = "dgvMon";
            this.dgvMon.ReadOnly = true;
            this.dgvMon.Size = new System.Drawing.Size(323, 187);
            this.dgvMon.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(277, 262);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ColMaMon
            // 
            this.ColMaMon.DataPropertyName = "MaMon";
            this.ColMaMon.HeaderText = "Mã môn";
            this.ColMaMon.Name = "ColMaMon";
            this.ColMaMon.ReadOnly = true;
            // 
            // ColTenMon
            // 
            this.ColTenMon.DataPropertyName = "TenMon";
            this.ColTenMon.HeaderText = "Tên môn";
            this.ColTenMon.Name = "ColTenMon";
            this.ColTenMon.ReadOnly = true;
            // 
            // ColSoTC
            // 
            this.ColSoTC.DataPropertyName = "SoTinChi";
            this.ColSoTC.HeaderText = "Số tín chỉ";
            this.ColSoTC.Name = "ColSoTC";
            this.ColSoTC.ReadOnly = true;
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 297);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvMon);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbKhoa);
            this.Name = "FrmMonHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Môn học";
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