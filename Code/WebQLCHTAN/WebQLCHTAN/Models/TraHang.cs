namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TraHang")]
    public partial class TraHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TraHang()
        {
            ThongTinTraHang = new HashSet<ThongTinTraHang>();
        }

        [Key]
        [StringLength(10)]
        public string maTra { get; set; }

        public DateTime? ngayTra { get; set; }

        public string ghiChu { get; set; }

        [StringLength(10)]
        public string maDatHang { get; set; }

        public bool? trangThai { get; set; }

        public virtual DatHang DatHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinTraHang> ThongTinTraHang { get; set; }
    }
}
