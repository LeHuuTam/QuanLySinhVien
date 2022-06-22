using QuanLySinhVien.Business;
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
    public partial class FrmDiem_SV : Form
    {
        public FrmDiem_SV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDiem_SV_Load(object sender, EventArgs e)
        {
            BLSinhVien blsv = new BLSinhVien();
            var sv = blsv.LaySinhVienTheoTenDN(DangNhap.TenDN);

            lbMSSV.Text = sv.MaSV;
            lbTen.Text = sv.HoTen;
            BLDiem bld = new BLDiem();
            var diems = bld.LayDiemTheoSV(sv.MaSV);
            List<object> ketqua = new List<object>();
            foreach (var i in diems)
            {
                ketqua.Add(new
                {
                    Lop = i.MaLop,
                    Mon = i.Lop.MonHoc.TenMon,
                    Gk = i.DiemQuaTrinh,
                    Ck = i.DiemCuoiKy,
                    Tb = (i.DiemCuoiKy + i.DiemQuaTrinh) / 2,
                    KetQua = i.DiemCuoiKy + i.DiemQuaTrinh >= 10
                });
            }
            this.dgvKetQua.DataSource = ketqua;
        }
    }
}
