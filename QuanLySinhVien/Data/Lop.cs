namespace QuanLySinhVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lop")]
    public partial class Lop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lop()
        {
            Diems = new HashSet<Diem>();
        }

        [Key]
        [StringLength(20)]
        public string MaLop { get; set; }

        [Required]
        [StringLength(20)]
        public string MaMon { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Diem> Diems { get; set; }

        public virtual MonHoc MonHoc { get; set; }
    }
}
