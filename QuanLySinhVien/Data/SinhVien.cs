namespace QuanLySinhVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            Diems = new HashSet<Diem>();
        }

        [Key]
        [StringLength(20)]
        public string MaSV { get; set; }

        [Required]
        [StringLength(50)]
        public string HoTen { get; set; }

        public bool GioiTinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [Required]
        [StringLength(20)]
        public string MaKhoa { get; set; }

        [StringLength(20)]
        public string TenDangNhap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        public virtual Khoa Khoa { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
