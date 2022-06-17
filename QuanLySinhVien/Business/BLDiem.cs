using QuanLySinhVien.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.Business
{
    public class BLDiem
    {
        QuanLySinhVienDbContext db = null;
        public BLDiem()
        {
            db = new QuanLySinhVienDbContext();
        }
        public bool XoaDiem(string masv)
        {
            try
            {
                List<Diem> listDiem = db.Diems.Where(x => x.MaSV == masv).ToList();
                foreach (var i in listDiem)
                {
                    db.Diems.Remove(i);
                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool LuuDiem(string masv, string maLop, float gk, float ck)
        {
            try
            {
                Diem diem = db.Diems.Where(x => x.MaSV == masv && x.MaLop == maLop).FirstOrDefault();
                diem.DiemQuaTrinh = gk;
                diem.DiemCuoiKy = ck;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public List<Diem> LayDiemTheoSV(string maSV)
        {
            return db.Diems.Where(x => x.MaSV == maSV).ToList();
        }
        public List<Diem> LayDiemTheoLop(string maLop)
        {
            return db.Diems.Where(x => x.MaLop == maLop).ToList();
        }
    }
}
