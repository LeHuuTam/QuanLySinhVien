using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Business
{
    public class BLLop
    {
        QuanLySinhVienDbContext db = null;
        public BLLop()
        {
            db = new QuanLySinhVienDbContext();
        }
        public List<Lop> LayLop(string maMon)
        {
            return db.Lops.Where(x => x.MaMon == maMon).ToList();
        }
    }
}
