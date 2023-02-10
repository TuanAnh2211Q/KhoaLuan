namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NuocUong")]
    public partial class NuocUong
    {
        [Key]
        [StringLength(10)]
        public string maNuoc { get; set; }

        [StringLength(50)]
        public string tenNuoc { get; set; }

        [StringLength(10)]
        public string donViBan { get; set; }

        [Column(TypeName = "money")]
        public decimal? giaBanNuoc { get; set; }

        public byte[] HinhURL { get; set; }

        public virtual MatHang MatHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
