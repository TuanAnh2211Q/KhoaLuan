namespace VEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatHang")]
    public partial class DatHang
    {
        [Key]
        [StringLength(10)]
        public string maDatHang { get; set; }

        public DateTime? ngayDatHang { get; set; }

        public DateTime? ngayDuKienGiao { get; set; }

        public string ghiChu { get; set; }

        [StringLength(50)]
        public string phuongThucThanhToan { get; set; }

        public bool? trangThai { get; set; }
    }
}
