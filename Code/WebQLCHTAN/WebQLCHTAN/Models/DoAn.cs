namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DoAn")]
    public partial class DoAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoAn()
        {
            ThongTinThanhPhanDoAn = new HashSet<ThongTinThanhPhanDoAn>();
        }

        [Key]
        [StringLength(10)]
        public string maDoAn { get; set; }

        [StringLength(10)]
        public string maLoaiDoAn { get; set; }

        [StringLength(50)]
        public string tenDoAn { get; set; }

        public byte[] HinhURL { get; set; }

        public virtual SanPham SanPham { get; set; }

        public virtual ThongTinDoAn ThongTinDoAn { get; set; }

        public virtual LoaiDoAn LoaiDoAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinThanhPhanDoAn> ThongTinThanhPhanDoAn { get; set; }
    }
}
