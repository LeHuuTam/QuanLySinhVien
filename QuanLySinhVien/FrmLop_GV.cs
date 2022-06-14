using QuanLySinhVien.DAO;
using QuanLySinhVien.Data;
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
    public partial class FrmLop_GV : Form
    {
        public FrmLop_GV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLop_GV_Load(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien();
            gv = BLGiangVien.LayGV(DangNhap.TenDN);
            var mons = BLMonHoc.LayMon(gv.MaKhoa);

            cbMon.DataSource = mons;
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            dgvLop.DataSource = BLLop.LayLop(cbMon.SelectedValue.ToString());
        }
    }
}
