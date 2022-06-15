using QuanLySinhVien.Business;
using System;
using System.Collections.Generic;
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
            var blsv = new BLSinhVien();
            List<object> list = new List<object>();
            foreach (var i in blsv.LaySinhVien())
            {
                list.Add(new
                {
                    MaSV = i.MaSV,
                    HoTen = i.HoTen,
                    GioiTinh = i.GioiTinh,
                    NgaySinh = i.NgaySinh,
                    MaKhoa = i.MaKhoa
                });
            }
            dgvSV.DataSource = list;
            //dgvSV.DataSource = BLSinhVien.LaySinhVien();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var blsv = new BLSinhVien();
            List<object> list = new List<object>();
            foreach (var i in blsv.TimSinhVien(txbTim.Text.Trim()))
            {
                list.Add(new
                {
                    MaSV = i.MaSV,
                    HoTen = i.HoTen,
                    GioiTinh = i.GioiTinh,
                    NgaySinh = i.NgaySinh,
                    MaKhoa = i.MaKhoa
                });
            }
            dgvSV.DataSource = list;
        }
    }
}
