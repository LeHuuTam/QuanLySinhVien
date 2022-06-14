using QuanLySinhVien.Business;
using System;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmSinhVien_GV : Form
    {
        public FrmSinhVien_GV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSinhVien_GV_Load(object sender, EventArgs e)
        {
            //dgvSV.DataSource = BLSinhVien.LaySinhVien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var blsv = new BLSinhVien();
            dgvSV.DataSource = blsv.TimSinhVien(txbTim.Text.Trim());
        }
    }
}
