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
        bool isAdding;
        public FrmCrudLop()
        {
            InitializeComponent();
        }
        void ResetForm()
        {
            panel1.Enabled = false;
            btnHuy.Enabled = false;
            btnLuu.Enabled = false;
            btnThoat.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
        }
        void LoadData()
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
                    Khoa = i.MonHoc.Khoa.TenKhoa
                });
            }
            dgvLop.DataSource = list;
        }
        private void btn_Xoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            isAdding = true;
            panel1.Enabled = true;
            btnThoat.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            textBox_MaLop.Enabled = true;
            textBox_MaLop.Focus();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (isAdding)
            {
                var bll = new BLLop();
                var them = bll.ThemLop(textBox_MaLop.Text, textBox_MaMH.Text, dpBD.Value, dpKT.Value, txbMaGV.Text);
                if (them)
                {
                    MessageBox.Show("Thêm lớp thành công");
                }
                else
                {
                    MessageBox.Show("Không thể thêm lớp học này. Vui lòng kiểm tra lại thông tin");
                }
            }

            ResetForm();
            LoadData();
        }

        private void FrmCrudLop_Load(object sender, EventArgs e)
        {
            ResetForm();
            LoadData();
        }
    }
}
