namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinThanhPhanDoAn")]
    public partial class ThongTinThanhPhanDoAn
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maThanhPhan { get; set; }

        [StringLength(50)]
        public string tenThanhPhan { get; set; }

        [StringLength(20)]
        public string dinhLuong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maDoAn { get; set; }

        public int? soLuong { get; set; }

        public virtual DoAn DoAn { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
