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
    public partial class FrmCrudGV : Form
    {
        bool isAdding;
        BLKhoa blKhoa;
        BLTaiKhoan bltk;
        BLGiangVien blgv;

        string tenDNHienTai;
        public FrmCrudGV()
        {
            InitializeComponent();
        }


        void ResetForm()
        {
            rbNu.Checked = true;
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
            blgv = new BLGiangVien();
            List<object> listGV = new List<object>();
            foreach (var i in blgv.LayGV())
            {
                listGV.Add(new
                {
                    MaGV = i.MaGV,
                    HoTen = i.HoTen,
                    GioiTinh = i.GioiTinh,
                    NgaySinh = i.NgaySinh,
                    Khoa = i.Khoa.TenKhoa,
                    TenDangNhap = i.TenDangNhap,
                    MatKhau = i.TaiKhoan.MatKhau
                });
            }
            dgv_ttGV.DataSource = listGV;
        }
        private void FrmCrudGV_Load(object sender, EventArgs e)
        {
            blKhoa = new BLKhoa();
            bltk = new BLTaiKhoan();

            cbKhoa.DataSource = blKhoa.LayKhoa();
            cbKhoa.DisplayMember = "TenKhoa";
            cbKhoa.ValueMember = "MaKhoa";
            cbKhoa.SelectedIndex = 0;
            ResetForm();
            LoadData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            isAdding = true;
            panel1.Enabled = true;
            btnThoat.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            cbKhoa.Enabled = true;
            btnHuy.Enabled = true;
            btnLuu.Enabled = true;
            textBox_MaGV.Enabled = true;
            textBox_MaGV.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (textBox_MaGV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn giảng viên để sửa");
            }
            else
            {
                isAdding = false;
                tenDNHienTai = txbTenDN.Text.Trim();

                panel1.Enabled = true;
                textBox_MaGV.Enabled = false;
                textBox_HoTen.Focus();
                cbKhoa.Enabled = false;
                btnThoat.Enabled = false;
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (textBox_MaGV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xoá");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Các thông tin khác liên quan đến giảng viên cũng bị xoá. Bạn muốn tiếp tục?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    BLLop blLop = new BLLop();
                    bool xoaGVLop = blLop.XoaGVLop(textBox_MaGV.Text.Trim());
                    bool xoaGV = blgv.XoaGiangVien(textBox_MaGV.Text.Trim());
                    bool xoaTK = bltk.XoaTaiKhoan(txbTenDN.Text.Trim());

                    if (xoaGVLop && xoaGV && xoaTK)
                    {
                        MessageBox.Show("Xoá giảng viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá giảng viên");
                    }
                    LoadData();
                }
            }
        }

        bool Validate(params string[] arr)
        {
            bool ok = true;
            foreach (var i in arr)
            {
                if (i == "")
                    ok = false;
            }
            return ok;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Validate(textBox_MaGV.Text.Trim(), textBox_HoTen.Text.Trim(),
                txbMk.Text.Trim(), txbTenDN.Text.Trim()))
            {
                if (isAdding)
                {
                    bltk = new BLTaiKhoan();
                    bool themTKResult = bltk.ThemTaiKhoan(txbTenDN.Text.Trim(), txbMk.Text.Trim(), 2);
                    bool themSVresult = blgv.ThemGiangVien(textBox_MaGV.Text.Trim(), textBox_HoTen.Text.Trim(),
                        cbKhoa.SelectedValue.ToString(), dateTimePicker1.Value, rbNu.Checked, txbTenDN.Text.Trim(), txbMk.Text.Trim());
                    if (themTKResult && themSVresult)
                    {
                        MessageBox.Show("Thêm giảng viên mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm giảng viên");
                    }

                }
                else
                {
                    bltk = new BLTaiKhoan();
                    bool ok;
                   

                    if(txbTenDN.Text.Trim() == tenDNHienTai)
                    {
                        bool suaTK = bltk.SuaMK(txbTenDN.Text.Trim(), txbMk.Text.Trim());
                        bool suaGV = blgv.SuaGiangVien(textBox_MaGV.Text.Trim(), textBox_HoTen.Text.Trim(),
                       cbKhoa.SelectedValue.ToString(), dateTimePicker1.Value, rbNu.Checked, txbTenDN.Text.Trim(), txbMk.Text.Trim());
                        ok = suaGV && suaTK;
                    }
                    else
                    {
                        bool themTK = bltk.ThemTaiKhoan(txbTenDN.Text.Trim(), txbMk.Text.Trim(), 2);
                        bool suaGV = blgv.SuaGiangVien(textBox_MaGV.Text.Trim(), textBox_HoTen.Text.Trim(),
                       cbKhoa.SelectedValue.ToString(), dateTimePicker1.Value, rbNu.Checked, txbTenDN.Text.Trim(), txbMk.Text.Trim());
                        bool xoaTK = bltk.XoaTaiKhoan(tenDNHienTai);
                        ok = suaGV && themTK && xoaTK;
                    }
                    if (ok)
                    {
                        MessageBox.Show("Sửa thông tin giảng viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa thông tin giảng viên");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            ResetForm();
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_ttGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaGV.Text = dgv_ttGV.CurrentRow.Cells["MaGV"].Value.ToString();
            textBox_HoTen.Text = dgv_ttGV.CurrentRow.Cells["HoTen"].Value.ToString();
            DateTime ngSinh;

            bool parse = DateTime.TryParse(dgv_ttGV.CurrentRow.Cells["NgaySinh"].Value.ToString(), out ngSinh);
            if (parse)
            {
                dateTimePicker1.Value = ngSinh;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }

            rbNu.Checked = Convert.ToBoolean(dgv_ttGV.CurrentRow.Cells["GioiTinh"].Value);
            rbNam.Checked = !rbNu.Checked;
            string tenKhoa = dgv_ttGV.CurrentRow.Cells["Khoa"].Value.ToString();
            cbKhoa.SelectedValue = new BLKhoa().LayMaKhoa(tenKhoa);
            txbTenDN.Text = dgv_ttGV.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txbMk.Text = dgv_ttGV.CurrentRow.Cells["MatKhau"].Value.ToString();
        }
    }
}
