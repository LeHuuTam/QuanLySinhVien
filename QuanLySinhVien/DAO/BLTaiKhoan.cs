using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public static class BLTaiKhoan
    {
        public static TaiKhoan LayTaiKhoan(string tenDN, string mk)
        {
            return DB.QLSV.TaiKhoans.Where(x => x.TenDangNhap == tenDN && x.MatKhau == mk).FirstOrDefault();
        }
    }
}
