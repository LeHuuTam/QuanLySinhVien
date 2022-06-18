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
    public partial class FrmCrudMonHoc : Form
    {
        bool isAdding;
        BLKhoa blKhoa;
        BLMonHoc blmh;
        public FrmCrudMonHoc()
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
            blmh = new BLMonHoc();
            List<object> listMon = new List<object>();
            foreach (var i in blmh.LayMon())
            {
                listMon.Add(new
                {
                    MaMon = i.MaMon,
                    TenMon = i.TenMon,
                    SoTinChi = i.SoTinChi,
                    Khoa = i.Khoa.TenKhoa
                });
            }
            dgvMon.DataSource = listMon;
        }
        private void FrmCrudMonHoc_Load(object sender, EventArgs e)
        {
            blKhoa = new BLKhoa();

            cbKhoa.DataSource = blKhoa.LayKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.SelectedIndex = 0;
            ResetForm();
            LoadData();
        }
    }
}
