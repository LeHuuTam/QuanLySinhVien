using QuanLySinhVien.Business;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmSinhVien_GV : Form
    {
        BLSinhVien blsv;
        public FrmSinhVien_GV()
        {
            InitializeComponent();
            blsv = new BLSinhVien();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSinhVien_GV_Load(object sender, EventArgs e)
        {
            List<object> listSV = new List<object>();
            foreach (var i in blsv.LaySinhVien())
            {
                listSV.Add(new
                {
                    MaSV = i.MaSV,
                    HoTen = i.HoTen,
                    GioiTinh = i.GioiTinh,
                    NgaySinh = i.NgaySinh,
                    MaKhoa = i.Khoa.TenKhoa
                });
            }
            dgvSV.DataSource = listSV;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            List<object> listSV = new List<object>();
            foreach (var i in blsv.TimSinhVien(txbTim.Text.Trim()))
            {
                listSV.Add(new
                {
                    MaSV = i.MaSV,
                    HoTen = i.HoTen,
                    GioiTinh = i.GioiTinh,
                    NgaySinh = i.NgaySinh,
                    MaKhoa = i.Khoa.TenKhoa
                });
            }
            dgvSV.DataSource = listSV;
        }
    }
}
