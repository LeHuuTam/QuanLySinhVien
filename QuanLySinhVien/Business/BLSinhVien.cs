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
        public List<SinhVien> TimSinhVien(string text)
        {
            return db.SinhViens.Where(x => x.MaSV.Contains(text)
                || x.HoTen.Contains(text)
                || x.Khoa.TenKhoa.Contains(text)).ToList();
        }
    }
}
