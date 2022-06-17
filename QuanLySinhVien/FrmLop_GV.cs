using QuanLySinhVien.Business;
using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class FrmLop_GV : Form
    {
        public FrmLop_GV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmLop_GV_Load(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien();
            var bllop = new BLLop();
            var blgv = new BLGiangVien();
            var blmh = new BLMonHoc();
            gv = blgv.LayGV(DangNhap.TenDN);
            var mons = blmh.LayMon(gv.MaKhoa);

            cbMon.DataSource = mons;
            cbMon.DisplayMember = "TenMon";
            cbMon.ValueMember = "MaMon";

            var lops = bllop.LayLopTheoGV(gv.MaGV);
            cbLop.DataSource = lops;
            cbLop.DisplayMember = "MaLop";
            cbLop.ValueMember = "MaLop";
        }

        private void btnChonMon_Click(object sender, EventArgs e)
        {
            var blLop = new BLLop();
            List<object> listLop = new List<object>();
            foreach (var i in blLop.LayLop(cbMon.SelectedValue.ToString()))
            {
                listLop.Add(new
                {
                    MaLop = i.MaLop,
                    NgayBatDau = i.NgayBatDau,
                    NgayKetThuc = i.NgayKetThuc
                });
            }
            dgvDSLop.DataSource = listLop;
        }

        private void btnChonLop_Click(object sender, EventArgs e)
        {
            var blDiem = new BLDiem();
            var blsv = new BLSinhVien();
            var listDiem = blDiem.LayDiemTheoLop(cbLop.SelectedValue.ToString());
            var listSV = new List<object>();
            foreach (var i in listDiem)
            {
                double? tb = null;
                if (i.DiemQuaTrinh != null && i.DiemCuoiKy != null)
                {
                    tb = (i.DiemQuaTrinh + i.DiemCuoiKy) / 2;
                }
                listSV.Add(new {
                    MaSV = i.MaSV,
                    HoTen = i.SinhVien.HoTen,
                    NgaySinh = i.SinhVien.NgaySinh,
                    GioiTinh = i.SinhVien.GioiTinh,
                    Khoa = i.SinhVien.Khoa.TenKhoa,
                    GiuaKy = String.Format("{0:0.0}", i.DiemQuaTrinh),
                    CuoiKy = String.Format("{0:0.0}", i.DiemCuoiKy),
                    TrungBinh = String.Format("{0:0.0}", tb)
                });
            }
            dgvDSSV.DataSource = listSV;
        }

        private void dgvDSSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbMaSV.Text = dgvDSSV.CurrentRow.Cells["MaSV"].Value.ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            float gk, ck;
            if (float.TryParse(txbGK.Text, out gk) && float.TryParse(txbCK.Text, out ck))
            {
                var bld = new BLDiem();
                if (bld.LuuDiem(txbMaSV.Text, cbLop.SelectedValue.ToString(), gk, ck))
                {
                    var blDiem = new BLDiem();
                    var listDiem = blDiem.LayDiemTheoLop(cbLop.SelectedValue.ToString());
                    var listSV = new List<object>();
                    foreach (var i in listDiem)
                    {
                        double? tb = null;
                        if (i.DiemQuaTrinh != null && i.DiemCuoiKy != null)
                        {
                            tb = (i.DiemQuaTrinh + i.DiemCuoiKy) / 2;
                        }
                        listSV.Add(new
                        {
                            MaSV = i.MaSV,
                            HoTen = i.SinhVien.HoTen,
                            NgaySinh = i.SinhVien.NgaySinh,
                            GioiTinh = i.SinhVien.GioiTinh,
                            Khoa = i.SinhVien.Khoa.TenKhoa,
                            GiuaKy = String.Format("{0:0.0}", i.DiemQuaTrinh),
                            CuoiKy = String.Format("{0:0.0}", i.DiemCuoiKy),
                            TrungBinh = String.Format("{0:0.0}", tb)
                        });;
                    }
                    dgvDSSV.DataSource = listSV;
                }
            }
        }
        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Bảng điểm";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
       
                ToExcel(dgvDSSV, saveFileDialog1.FileName);
            }
        }
    }
}
