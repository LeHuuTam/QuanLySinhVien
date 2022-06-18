using QuanLySinhVien.Business;
using System;
using System.Collections.Generic;
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
            var blMon = new BLMonHoc();

            List<object> listMon = new List<object>();
            foreach (var item in blMon.LayMon(cbKhoa.SelectedValue.ToString()))
            {
                listMon.Add(new { 
                    MaMon = item.MaMon,
                    TenMon = item.TenMon,
                    SoTinChi = item.SoTinChi});
            }
            dgvMon.DataSource = listMon;

        }
    }
}
