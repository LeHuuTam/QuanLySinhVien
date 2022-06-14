using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public static class BLKhoa
    {
        public static List<Data.Khoa> LayKhoa()
        {
            return DB.QLSV.Khoas.ToList();
        }
    }
}
