namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhoBan")]
    public partial class KhoBan
    {
        [Key]
        [StringLength(10)]
        public string maHang { get; set; }

        public int? soLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? tongGia { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
