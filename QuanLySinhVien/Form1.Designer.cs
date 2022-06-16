
namespace QuanLySinhVien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txbTenDN = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.rbQuanTri = new System.Windows.Forms.RadioButton();
            this.rbGiangVien = new System.Windows.Forms.RadioButton();
            this.rbSinhVien = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Chức vụ";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.LimeGreen;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(296, 211);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(128, 39);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txbTenDN
            // 
            this.txbTenDN.Location = new System.Drawing.Point(220, 42);
            this.txbTenDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbTenDN.Name = "txbTenDN";
            this.txbTenDN.Size = new System.Drawing.Size(280, 22);
            this.txbTenDN.TabIndex = 3;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Location = new System.Drawing.Point(220, 95);
            this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(280, 22);
            this.txbMatKhau.TabIndex = 3;
            this.txbMatKhau.UseSystemPasswordChar = true;
            // 
            // rbQuanTri
            // 
            this.rbQuanTri.AutoSize = true;
            this.rbQuanTri.Location = new System.Drawing.Point(220, 155);
            this.rbQuanTri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbQuanTri.Name = "rbQuanTri";
            this.rbQuanTri.Size = new System.Drawing.Size(110, 21);
            this.rbQuanTri.TabIndex = 4;
            this.rbQuanTri.TabStop = true;
            this.rbQuanTri.Text = "Quản trị viên";
            this.rbQuanTri.UseVisualStyleBackColor = true;
            // 
            // rbGiangVien
            // 
            this.rbGiangVien.AutoSize = true;
            this.rbGiangVien.Location = new System.Drawing.Point(341, 155);
            this.rbGiangVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbGiangVien.Name = "rbGiangVien";
            this.rbGiangVien.Size = new System.Drawing.Size(97, 21);
            this.rbGiangVien.TabIndex = 5;
            this.rbGiangVien.TabStop = true;
            this.rbGiangVien.Text = "Giảng viên";
            this.rbGiangVien.UseVisualStyleBackColor = true;
            // 
            // rbSinhVien
            // 
            this.rbSinhVien.AutoSize = true;
            this.rbSinhVien.Location = new System.Drawing.Point(451, 155);
            this.rbSinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbSinhVien.Name = "rbSinhVien";
            this.rbSinhVien.Size = new System.Drawing.Size(87, 21);
            this.rbSinhVien.TabIndex = 6;
            this.rbSinhVien.TabStop = true;
            this.rbSinhVien.Text = "Sinh viên";
            this.rbSinhVien.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Crimson;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(432, 211);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 39);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 265);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.rbSinhVien);
            this.Controls.Add(this.rbGiangVien);
            this.Controls.Add(this.rbQuanTri);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenDN);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txbTenDN;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.RadioButton rbQuanTri;
        private System.Windows.Forms.RadioButton rbGiangVien;
        private System.Windows.Forms.RadioButton rbSinhVien;
        private System.Windows.Forms.Button btnThoat;
    }
}

