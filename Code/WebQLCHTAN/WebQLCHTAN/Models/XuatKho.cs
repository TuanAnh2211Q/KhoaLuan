namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("XuatKho")]
    public partial class XuatKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public XuatKho()
        {
            ThongTinXuatKho = new HashSet<ThongTinXuatKho>();
        }

        [Key]
        [StringLength(10)]
        public string maXuat { get; set; }

        public DateTime? ngayXuat { get; set; }

        public bool? trangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinXuatKho> ThongTinXuatKho { get; set; }
    }
}
