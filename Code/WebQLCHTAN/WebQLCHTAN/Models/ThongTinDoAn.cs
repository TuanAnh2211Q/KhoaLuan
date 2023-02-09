namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinDoAn")]
    public partial class ThongTinDoAn
    {
        [Key]
        [StringLength(10)]
        public string maDoAn { get; set; }

        [StringLength(10)]
        public string donViBan { get; set; }

        [Column(TypeName = "money")]
        public decimal? donGia { get; set; }

        public string ghiChu { get; set; }

        public virtual DoAn DoAn { get; set; }
    }
}
