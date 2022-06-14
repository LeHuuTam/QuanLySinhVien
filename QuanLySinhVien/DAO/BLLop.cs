using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public static class BLLop
    {
        public static List<Lop> LayLop(string maMon)
        {
            return DB.QLSV.Lops.Where(x => x.MaMon == maMon).ToList();
        }
    }
}
