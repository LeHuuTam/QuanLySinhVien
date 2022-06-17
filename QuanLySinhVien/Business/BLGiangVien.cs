using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Business
{
    public class BLGiangVien
    {
        QuanLySinhVienDbContext db = null;
        public BLGiangVien()
        {
            db = new QuanLySinhVienDbContext();
        }
        public GiangVien LayGV(string tenDN)
        {
            return db.GiangViens.Where(x => x.TenDangNhap == tenDN).FirstOrDefault();
        }
        public List<GiangVien> LayGV()
        {
            return db.GiangViens.ToList();
        }
        public string Khoa(string maGV)
        {
            return db.GiangViens.Where(x => x.MaGV == maGV).FirstOrDefault().MaKhoa;
        }

        public bool ThemGiangVien(string magv, string hoTen, string maKhoa, DateTime ngSinh, bool laNu, string tenDN, string mk)
        {
            try
            {
                GiangVien sv = new GiangVien()
                {
                    MaGV = magv,
                    MaKhoa = maKhoa,
                    HoTen = hoTen,
                    GioiTinh = laNu,
                    NgaySinh = ngSinh,
                    TenDangNhap = tenDN
                };
                db.GiangViens.Add(sv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaGiangVien(string magv, string hoTen, string maKhoa, DateTime ngSinh, bool laNu, string tenDN, string mk)
        {
            try
            {
                GiangVien sv = db.GiangViens.Where(x => x.MaGV == magv).FirstOrDefault();

                sv.MaKhoa = maKhoa;
                sv.HoTen = hoTen;
                sv.GioiTinh = laNu;
                sv.NgaySinh = ngSinh;
                sv.TenDangNhap = tenDN;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool XoaGiangVien(string magv)
        {
            try
            {
                GiangVien sv = db.GiangViens.Where(x => x.MaGV == magv).FirstOrDefault();

                db.GiangViens.Remove(sv);
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
