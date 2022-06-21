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
    public partial class FrmThongKe : Form
    {
        List<int> thongKe;
        public FrmThongKe(List<int> diem)
        {
            this.thongKe = diem;
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                chart1.Series["Diem"].Points.AddXY(i, thongKe[i]);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
