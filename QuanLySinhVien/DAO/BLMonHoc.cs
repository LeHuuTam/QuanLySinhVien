using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public static class BLMonHoc
    {
        public static List<MonHoc> LayMon(string maKhoa)
        {
            return DB.QLSV.MonHocs.Where(x => x.MaKhoa == maKhoa).ToList();
        }
    }
}
