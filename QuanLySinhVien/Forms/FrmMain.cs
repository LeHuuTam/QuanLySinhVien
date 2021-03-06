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
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMonHoc frm = new FrmMonHoc();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void mônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLop_GV frm = new FrmLop_GV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void sinhViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmSinhVien_GV frm = new FrmSinhVien_GV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }


        private void giảngViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCrudGV frm = new FrmCrudGV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void sinhViênToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmCrudSV frm = new FrmCrudSV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void MonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudMonHoc frm = new FrmCrudMonHoc();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudLop frm = new FrmCrudLop();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void XemDiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiem_SV frm = new FrmDiem_SV();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            switch (DangNhap.Quyen)
            {
                case 1:
                    this.quảnTrịViênToolStripMenuItem.Enabled = true;
                    this.giảngViênToolStripMenuItem.Enabled = false;
                    this.sinhViênToolStripMenuItem.Enabled = false;
                    break;
                case 2:
                    this.quảnTrịViênToolStripMenuItem.Enabled = false;
                    this.giảngViênToolStripMenuItem.Enabled = true;
                    this.sinhViênToolStripMenuItem.Enabled = false;
                    break;
                case 3:
                    this.quảnTrịViênToolStripMenuItem.Enabled = false;
                    this.giảngViênToolStripMenuItem.Enabled = false;
                    this.sinhViênToolStripMenuItem.Enabled = true;
                    break;
            }
        }
    }
}
