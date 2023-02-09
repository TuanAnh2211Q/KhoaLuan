namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ThongTinNhapKho")]
    public partial class ThongTinNhapKho
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string maNhap { get; set; }

        [StringLength(10)]
        public string maNCC { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string maHang { get; set; }

        public int? soLuong { get; set; }

        [Column(TypeName = "money")]
        public decimal? tongDonGia { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        public virtual NhapKho NhapKho { get; set; }
    }
}
