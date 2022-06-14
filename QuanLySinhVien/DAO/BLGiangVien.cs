using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.DAO
{
    public static class BLGiangVien
    {
        public static GiangVien LayGV(string tenDN)
        {
            return DB.QLSV.GiangViens.Where(x => x.TenDangNhap == tenDN).FirstOrDefault();
        }
        public static string Khoa(string maGV)
        {
            return DB.QLSV.GiangViens.Where(x => x.MaGV == maGV).FirstOrDefault().MaKhoa;
        }
    }
}
