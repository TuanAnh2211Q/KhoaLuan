namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanQuyen")]
    public partial class PhanQuyen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhanQuyen()
        {
            TaiKhoanNhanVien = new HashSet<TaiKhoanNhanVien>();
        }

        [Key]
        [StringLength(10)]
        public string maQuyen { get; set; }

        [StringLength(50)]
        public string tenQuyen { get; set; }

        public string ghiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanNhanVien> TaiKhoanNhanVien { get; set; }
    }
}
