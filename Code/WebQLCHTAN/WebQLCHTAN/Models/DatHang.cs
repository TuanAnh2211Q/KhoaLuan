namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHang")]
    public partial class DatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatHang()
        {
            NhapKho = new HashSet<NhapKho>();
            ThongTinDatHang = new HashSet<ThongTinDatHang>();
            TraHang = new HashSet<TraHang>();
        }

        [Key]
        [StringLength(10)]
        public string maDatHang { get; set; }

        public DateTime? ngayDatHang { get; set; }

        public DateTime? ngayDuKienGiao { get; set; }

        public string ghiChu { get; set; }

        [StringLength(50)]
        public string phuongThucThanhToan { get; set; }

        public bool? trangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhapKho> NhapKho { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinDatHang> ThongTinDatHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraHang> TraHang { get; set; }
    }
}
