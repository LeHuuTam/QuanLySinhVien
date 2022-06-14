using QuanLySinhVien.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dgvSV.DataSource = BLSinhVien.LaySinhVien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvSV.DataSource = BLSinhVien.TimSinhVien(txbTim.Text.Trim());
        }
    }
}
