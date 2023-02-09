namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinDonHang")]
    public partial class ThongTinDonHang
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maDonHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maSanPham { get; set; }

        [Column(TypeName = "money")]
        public decimal? giaTien { get; set; }

        public int? soLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? thanhTien { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
