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
            List<object> list = new List<object>();
            foreach (var i in blMon.LayMon(cbKhoa.SelectedValue.ToString()))
            {

                list.Add(new
                { 
                    MaMon = i.MaMon,
                    TenMon = i.TenMon,
                    SoTinChi = i.SoTinChi
                });
            }
            dgvMon.DataSource = list;
        }
    }
}
