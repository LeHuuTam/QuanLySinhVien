using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Business
{
    public class BLKhoa
    {
        QuanLySinhVienDbContext db = null;
        public BLKhoa()
        {
            db = new QuanLySinhVienDbContext();
        }
        public List<Khoa> LayKhoa()
        {
            return db.Khoas.ToList();
        }
        public string LayMaKhoa(string tenKhoa)
        {
            return db.Khoas.Where(x => x.TenKhoa == tenKhoa).FirstOrDefault().MaKhoa;
        }
    }
}
