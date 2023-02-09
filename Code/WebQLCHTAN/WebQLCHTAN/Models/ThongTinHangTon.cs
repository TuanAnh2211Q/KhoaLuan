namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinHangTon")]
    public partial class ThongTinHangTon
    {
        [Key]
        [StringLength(10)]
        public string maHang { get; set; }

        public int? soLuongTon { get; set; }

        [Column(TypeName = "money")]
        public decimal? tongDonGia { get; set; }

        public virtual MatHang MatHang { get; set; }
    }
}
