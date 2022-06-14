using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Business
{
    public class BLTaiKhoan
    {
        QuanLySinhVienDbContext db = null;
        public BLTaiKhoan()
        {
            db = new QuanLySinhVienDbContext();
        }
        public TaiKhoan LayTaiKhoan(string tenDN, string mk)
        {
            return db.TaiKhoans.Where(x => x.TenDangNhap == tenDN && x.MatKhau == mk).FirstOrDefault();
        }
    }
}
