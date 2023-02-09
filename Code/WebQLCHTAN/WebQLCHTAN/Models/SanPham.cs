namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            DanhGia = new HashSet<DanhGia>();
            GioHang = new HashSet<GioHang>();
            ThongTinDonHang = new HashSet<ThongTinDonHang>();
        }

        [Key]
        [StringLength(10)]
        public string maSanPham { get; set; }

        [StringLength(10)]
        public string maLoaiSanPham { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DanhGia> DanhGia { get; set; }

        public virtual DoAn DoAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHang { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual NuocUong NuocUong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinDonHang> ThongTinDonHang { get; set; }
    }
}
