using QuanLySinhVien.Business;
using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
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
            var blgv = new BLGiangVien();
            var blmh = new BLMonHoc();
            gv = blgv.LayGV(DangNhap.TenDN);
            var mons = blmh.LayMon(gv.MaKhoa);

            cbMon.DataSource = mons;
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var blLop = new BLLop();
            List<object> listLop = new List<object>();
            foreach (var i in blLop.LayLop(cbMon.SelectedValue.ToString()))
            {
                listLop.Add(new
                {
                    MaLop = i.MaLop,
                    NgayBatDau = i.NgayBatDau,
                    NgayKetThuc = i.NgayKetThuc
                });
            }
            dgvLop.DataSource = listLop;
        }
    }
}
