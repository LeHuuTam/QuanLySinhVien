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
        public List<Lop> LayLopTheoGV(string maGV)
        {
            return db.Lops.Where(x => x.MaGV == maGV).ToList();
        }
        public bool XoaGVLop(string maGV)
        {
            try
            {
                var listLop = db.Lops.Where(x => x.MaGV == maGV).ToList();
                foreach (var i in listLop)
                {
                    i.MaGV = null;
                }
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
