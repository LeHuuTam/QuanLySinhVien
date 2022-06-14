using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Business
{
    public class BLGiangVien
    {
        QuanLySinhVienDbContext db = null;
        public BLGiangVien()
        {
            db = new QuanLySinhVienDbContext();
        }
        public GiangVien LayGV(string tenDN)
        {
            return db.GiangViens.Where(x => x.TenDangNhap == tenDN).FirstOrDefault();
        }
        public string Khoa(string maGV)
        {
            return db.GiangViens.Where(x => x.MaGV == maGV).FirstOrDefault().MaKhoa;
        }
    }
}
