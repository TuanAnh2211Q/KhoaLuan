namespace VEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MatHang")]
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            ThongTinThanhPhanDoAns = new HashSet<ThongTinThanhPhanDoAn>();
        }

        [Key]
        [StringLength(10)]
        public string maHang { get; set; }

        [Required]
        [StringLength(50)]
        public string tenHang { get; set; }

        [StringLength(10)]
        public string maNCC { get; set; }

        [StringLength(10)]
        public string donVi { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NSX { get; set; }

        [Column(TypeName = "date")]
        public DateTime? HSD { get; set; }

        [Column(TypeName = "money")]
        public decimal? donGia { get; set; }

        public string ghiChu { get; set; }

        public bool? loaiHang { get; set; }

        public virtual KhoBan KhoBan { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NuocUong NuocUong { get; set; }

        public virtual ThongTinHangTon ThongTinHangTon { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinThanhPhanDoAn> ThongTinThanhPhanDoAns { get; set; }
    }
}
