using QuanLySinhVien.Business;
using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool check = false;
            var bltk = new BLTaiKhoan();
            var tk = bltk.LayTaiKhoan(txbTenDN.Text.Trim(), txbMatKhau.Text.Trim());
            if (tk != null)
            {
                if (rbQuanTri.Checked)
                {
                    check = tk.Quyen == 1;
                }
                else if (rbGiangVien.Checked)
                {
                    check = tk.Quyen == 2;
                }
                else
                {
                    check = tk.Quyen == 3;
                }
            }

            if (check)
            {
                DangNhap.Quyen = tk.Quyen;
                DangNhap.TenDN = txbTenDN.Text.Trim();

                FrmMain frm = new FrmMain();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Đăng nhập không đúng. Vui lòng kiểm tra lại");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbQuanTri.Checked = true;
            txbTenDN.Text = "giangvien";
            txbMatKhau.Text = "123";
        }
    }
}
