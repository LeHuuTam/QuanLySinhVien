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
    public partial class FrmCrudLop : Form
    {
        public FrmCrudLop()
        {
            InitializeComponent();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void FrmCrudLop_Load(object sender, EventArgs e)
        {
            BLLop bll = new BLLop();
            List<object> list = new List<object>();
            foreach (var i in bll.LayLop())
            {
                list.Add(new
                {
                    MaLop = i.MaLop,
                    Mon = i.MonHoc.TenMon,
                    GiangVien = i.GiangVien.HoTen,
                    Khoa = i.MonHoc.Khoa
                });
            }
            dgvLop.DataSource = list;
        }
    }
}
