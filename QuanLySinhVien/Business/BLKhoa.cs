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
        public List<Data.Khoa> LayKhoa()
        {
            return db.Khoas.ToList();
        }
    }
}
