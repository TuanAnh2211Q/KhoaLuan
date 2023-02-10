namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiDoAn")]
    public partial class LoaiDoAn
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiDoAn()
        {
            DoAn = new HashSet<DoAn>();
        }

        [Key]
        [StringLength(10)]
        public string maLoaiDoAn { get; set; }

        [StringLength(50)]
        public string tenLoaiDoAn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoAn> DoAn { get; set; }
    }
}
