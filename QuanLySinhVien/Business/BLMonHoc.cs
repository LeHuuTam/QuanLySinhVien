using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Business
{
    public class BLMonHoc
    {
        QuanLySinhVienDbContext db = null;
        public BLMonHoc()
        {
            db = new QuanLySinhVienDbContext();
        }
        public List<MonHoc> LayMon(string maKhoa)
        {
            return  db.MonHocs.Where(x => x.MaKhoa == maKhoa).ToList();
        }
    }
}
