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
        public bool ThemTaiKhoan(string tenDN, string mk, int quyen)
        {
            try
            {
                db.TaiKhoans.Add(new TaiKhoan() { TenDangNhap = tenDN, MatKhau = mk, Quyen = quyen });
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaTaiKhoan(string tenDN)
        {
            try
            {
                TaiKhoan tk = db.TaiKhoans.Where(x => x.TenDangNhap == tenDN).FirstOrDefault();
                db.TaiKhoans.Remove(tk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaMK(string tenDN, string mkMoi)
        {
            try
            {
                TaiKhoan tk = db.TaiKhoans.Where(x => x.TenDangNhap == tenDN).FirstOrDefault();
                tk.MatKhau = mkMoi;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
