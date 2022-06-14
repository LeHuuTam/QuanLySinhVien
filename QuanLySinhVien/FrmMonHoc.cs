using QuanLySinhVien.Business;
using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmMonHoc : Form
    {
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            var blKhoa = new BLKhoa();
            cbKhoa.DataSource = blKhoa.LayKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.SelectedIndex = 0;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //var tb = MonHocDAO.LayMon(cbKhoa.SelectedValue.ToString());
            var blMon = new BLMonHoc();
            dgvMon.DataSource = blMon.LayMon(cbKhoa.SelectedValue.ToString());
            //dgvMon.DataSource = tb;
        }
    }
}
