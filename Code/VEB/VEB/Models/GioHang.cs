namespace VEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GioHang")]
    public partial class GioHang
    {
        [Key]
        [StringLength(10)]
        public string maGioHang { get; set; }

        public int? soLuong { get; set; }

        public int? idKhachHang { get; set; }

        [StringLength(10)]
        public string maSanPham { get; set; }

        public virtual SanPham SanPham { get; set; }

        public virtual KhachHang KhachHang { get; set; }
    }
}
