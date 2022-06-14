namespace QuanLySinhVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MonHoc")]
    public partial class MonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonHoc()
        {
            Lops = new HashSet<Lop>();
            GiangViens = new HashSet<GiangVien>();
        }

        [Key]
        [StringLength(20)]
        public string MaMon { get; set; }

        [Required]
        [StringLength(50)]
        public string TenMon { get; set; }

        public int SoTinChi { get; set; }

        [Required]
        [StringLength(20)]
        public string MaKhoa { get; set; }

        public virtual Khoa Khoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lop> Lops { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GiangVien> GiangViens { get; set; }
    }
}
