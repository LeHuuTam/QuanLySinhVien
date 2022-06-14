using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public static class BLSinhVien
    {
        public static List<SinhVien> LaySinhVien()
        {
            return DB.QLSV.SinhViens.ToList();
        }
        public static List<SinhVien> LaySinhVienKhoa(string maKhoa)
        {
            return DB.QLSV.SinhViens.Where(x => x.MaKhoa == maKhoa).ToList();
        }
        public static SinhVien LaySinhVien(string maSV)
        {
            return DB.QLSV.SinhViens.Where(x => x.MaSV == maSV).FirstOrDefault();
        }
        public static List<SinhVien> TimSinhVien(string text)
        {
            return DB.QLSV.SinhViens.Where(x => x.MaSV.Contains(text)
                || x.HoTen.Contains(text)
                || x.Khoa.TenKhoa.Contains(text)).ToList();
        }
    }
}
