using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Business
{
    public class BLSinhVien
    {
        QuanLySinhVienDbContext db = null;
        public BLSinhVien()
        {
            db = new QuanLySinhVienDbContext();
        }
        public List<SinhVien> LaySinhVien()
        {
            return db.SinhViens.ToList();
        }
        public List<SinhVien> LaySinhVienKhoa(string maKhoa)
        {
            return db.SinhViens.Where(x => x.MaKhoa == maKhoa).ToList();
        }
        public SinhVien LaySinhVien(string maSV)
        {
            return db.SinhViens.Where(x => x.MaSV == maSV).FirstOrDefault();
        }
        public SinhVien LaySinhVienTheoTenDN(string tenDN)
        {
            return db.SinhViens.Where(x => x.TenDangNhap == tenDN).FirstOrDefault();
        }
        public List<SinhVien> TimSinhVien(string text)
        {
            return db.SinhViens.Where(x => x.MaSV.Contains(text)
                || x.HoTen.Contains(text)
                || x.Khoa.TenKhoa.Contains(text)).ToList();
        }
        public bool ThemSinhVien(string masv, string hoTen, string maKhoa, DateTime ngSinh, bool laNu, string tenDN, string mk)
        {
            try
            {
                SinhVien sv = new SinhVien()
                {
                    MaSV = masv,
                    MaKhoa = maKhoa,
                    HoTen = hoTen,
                    GioiTinh = laNu,
                    NgaySinh = ngSinh,
                    TenDangNhap = tenDN
                };
                db.SinhViens.Add(sv);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaSinhVien(string masv, string hoTen, string maKhoa, DateTime ngSinh, bool laNu, string tenDN, string mk)
        {
            try
            {
                SinhVien sv = db.SinhViens.Where(x => x.MaSV == masv).FirstOrDefault();

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
        public bool XoaSinhVien(string masv)
        {
            try
            {
                SinhVien sv = db.SinhViens.Where(x => x.MaSV == masv).FirstOrDefault();

                db.SinhViens.Remove(sv);
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
