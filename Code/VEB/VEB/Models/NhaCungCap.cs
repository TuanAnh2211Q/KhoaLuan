namespace VEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhaCungCap")]
    public partial class NhaCungCap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhaCungCap()
        {
            MatHangs = new HashSet<MatHang>();
        }

        [Key]
        [StringLength(10)]
        public string maNCC { get; set; }

        [Required]
        [StringLength(50)]
        public string tenNCC { get; set; }

        [StringLength(50)]
        public string diaChiNCC { get; set; }

        [StringLength(50)]
        public string emailNCC { get; set; }

        [StringLength(11)]
        public string sdtNCC { get; set; }

        public string ghiChu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MatHang> MatHangs { get; set; }
    }
}