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
            cbKhoa.DataSource = BLKhoa.LayKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.SelectedIndex = 0;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //var tb = MonHocDAO.LayMon(cbKhoa.SelectedValue.ToString());

            dgvMon.DataSource = BLMonHoc.LayMon(cbKhoa.SelectedValue.ToString());
            //dgvMon.DataSource = tb;
        }
    }
}
