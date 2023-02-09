namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhapKho")]
    public partial class NhapKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhapKho()
        {
            ThongTinNhapKho = new HashSet<ThongTinNhapKho>();
        }

        [Key]
        [StringLength(10)]
        public string maNhap { get; set; }

        public DateTime? ngayNhap { get; set; }

        [StringLength(10)]
        public string maDatHang { get; set; }

        public string ghiChu { get; set; }

        public bool? trangThai { get; set; }

        public virtual DatHang DatHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinNhapKho> ThongTinNhapKho { get; set; }
    }
}
