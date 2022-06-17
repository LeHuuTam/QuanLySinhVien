namespace QuanLySinhVien.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diem")]
    public partial class Diem
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string MaLop { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string MaSV { get; set; }

        public double? DiemQuaTrinh { get; set; }

        public double? DiemCuoiKy { get; set; }

        public virtual Lop Lop { get; set; }

        public virtual SinhVien SinhVien { get; set; }
    }
}
