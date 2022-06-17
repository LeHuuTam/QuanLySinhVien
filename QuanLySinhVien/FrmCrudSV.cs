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
    public partial class FrmCrudSV : Form
    {
        bool isAdding;
        BLKhoa blKhoa;
        BLTaiKhoan bltk;
        BLSinhVien blsv;

        string tenDNHienTai;
        public FrmCrudSV()
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
            blsv = new BLSinhVien();
            List<object> listSV = new List<object>();
            foreach (var i in blsv.LaySinhVien())
            {
                listSV.Add(new
                {
                    MaSV = i.MaSV,
                    HoTen = i.HoTen,
                    GioiTinh = i.GioiTinh,
                    NgaySinh = i.NgaySinh,
                    Khoa = i.Khoa.TenKhoa,
                    TenDangNhap = i.TenDangNhap,
                    MatKhau = i.TaiKhoan.MatKhau
                });
            }
            dgv_ttSV.DataSource = listSV;
        }
        private void FrmCrudSV_Load(object sender, EventArgs e)
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
            textBox_MaSV.Enabled = true;
            textBox_MaSV.Focus();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (textBox_MaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa");
            }
            else
            {
                isAdding = false;
                tenDNHienTai = txbTenDN.Text.Trim();

                panel1.Enabled = true;
                textBox_MaSV.Enabled = false;
                textBox_HoTen.Focus();
                cbKhoa.Enabled = false;
                btnThoat.Enabled = false;
                btn_Them.Enabled = false;
                btn_Xoa.Enabled = false;
                btnHuy.Enabled = true;
                btnLuu.Enabled = true;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetForm();
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
            if (Validate(textBox_MaSV.Text.Trim(), textBox_HoTen.Text.Trim(),
                txbMk.Text.Trim(), txbTenDN.Text.Trim()))
            {
                if (isAdding)
                {
                    bltk = new BLTaiKhoan();
                    bool themTKResult = bltk.ThemTaiKhoan(txbTenDN.Text.Trim(), txbMk.Text.Trim(), 3);
                    bool themSVresult = blsv.ThemSinhVien(textBox_MaSV.Text.Trim(), textBox_HoTen.Text.Trim(),
                        cbKhoa.SelectedValue.ToString(), dateTimePicker1.Value, rbNu.Checked, txbTenDN.Text.Trim(), txbMk.Text.Trim());
                    if (themTKResult && themSVresult)
                    {
                        MessageBox.Show("Thêm sinh viên mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm sinh viên");
                    }

                }
                else
                {
                    bltk = new BLTaiKhoan();
                    bool ok;


                    if (txbTenDN.Text.Trim() == tenDNHienTai)
                    {
                        bool suaTK = bltk.SuaMK(txbTenDN.Text.Trim(), txbMk.Text.Trim());
                        bool suaGV = blsv.SuaSinhVien(textBox_MaSV.Text.Trim(), textBox_HoTen.Text.Trim(),
                       cbKhoa.SelectedValue.ToString(), dateTimePicker1.Value, rbNu.Checked, txbTenDN.Text.Trim(), txbMk.Text.Trim());
                        ok = suaGV && suaTK;
                    }
                    else
                    {
                        bool themTK = bltk.ThemTaiKhoan(txbTenDN.Text.Trim(), txbMk.Text.Trim(), 2);
                        bool suaGV = blsv.SuaSinhVien(textBox_MaSV.Text.Trim(), textBox_HoTen.Text.Trim(),
                       cbKhoa.SelectedValue.ToString(), dateTimePicker1.Value, rbNu.Checked, txbTenDN.Text.Trim(), txbMk.Text.Trim());
                        bool xoaTK = bltk.XoaTaiKhoan(tenDNHienTai);
                        ok = suaGV && themTK && xoaTK;
                    }
                    if (ok)
                    {
                        MessageBox.Show("Sửa thông tin sinh viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể sửa thông tin sinh viên");
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

        private void dgv_ttSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_MaSV.Text = dgv_ttSV.CurrentRow.Cells["MaSV"].Value.ToString();
            textBox_HoTen.Text = dgv_ttSV.CurrentRow.Cells["HoTen"].Value.ToString();
            DateTime ngSinh;

            bool parse = DateTime.TryParse(dgv_ttSV.CurrentRow.Cells["NgaySinh"].Value.ToString(), out ngSinh);
            if (parse)
            {
                dateTimePicker1.Value = ngSinh;
            }
            else
            {
                dateTimePicker1.Value = DateTime.Now;
            }

            rbNu.Checked = Convert.ToBoolean(dgv_ttSV.CurrentRow.Cells["GioiTinh"].Value);
            rbNam.Checked = !rbNu.Checked;
            string tenKhoa = dgv_ttSV.CurrentRow.Cells["Khoa"].Value.ToString();
            cbKhoa.SelectedValue = new BLKhoa().LayMaKhoa(tenKhoa);
            txbTenDN.Text = dgv_ttSV.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txbMk.Text = dgv_ttSV.CurrentRow.Cells["MatKhau"].Value.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (textBox_MaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xoá");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Các thông tin khác liên quan đến sinh viên cũng bị xoá. Bạn muốn tiếp tục?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    BLDiem blDiem = new BLDiem();
                    bool xoaDiem = blDiem.XoaDiem(textBox_MaSV.Text.Trim());
                    bool xoaSV = blsv.XoaSinhVien(textBox_MaSV.Text.Trim());
                    bool xoaTK = bltk.XoaTaiKhoan(txbTenDN.Text.Trim());

                    if (xoaDiem && xoaSV && xoaTK)
                    {
                        MessageBox.Show("Xoá sinh viên thành công");
                    }
                    else
                    {
                        MessageBox.Show("Không thể xoá sinh viên");
                    }
                    LoadData();
                }
            }
        }
    }
}
