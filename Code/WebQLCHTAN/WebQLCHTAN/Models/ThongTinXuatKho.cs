namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinXuatKho")]
    public partial class ThongTinXuatKho
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maXuat { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maHang { get; set; }

        public int? soLuong { get; set; }

        public string ghiChu { get; set; }

        [Column(TypeName = "money")]
        public decimal? tongDonGia { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual XuatKho XuatKho { get; set; }
    }
}
