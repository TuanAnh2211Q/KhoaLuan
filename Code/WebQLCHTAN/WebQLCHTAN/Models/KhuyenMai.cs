namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuyenMai")]
    public partial class KhuyenMai
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhuyenMai()
        {
            DonHang = new HashSet<DonHang>();
        }

        [Key]
        [StringLength(10)]
        public string maKhuyenMai { get; set; }

        [StringLength(50)]
        public string tenKhuyenMai { get; set; }

        [StringLength(10)]
        public string maLoaiKhuyenMai { get; set; }

        public double? mucGiam { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHang { get; set; }

        public virtual LoaiKhuyenMai LoaiKhuyenMai { get; set; }
    }
}
