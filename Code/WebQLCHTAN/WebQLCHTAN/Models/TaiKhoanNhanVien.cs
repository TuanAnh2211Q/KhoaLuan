namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoanNhanVien")]
    public partial class TaiKhoanNhanVien
    {
        public int id { get; set; }

        [StringLength(10)]
        public string tenTaiKhoan { get; set; }

        [StringLength(10)]
        public string matKhau { get; set; }

        [StringLength(10)]
        public string maNhanVien { get; set; }

        [StringLength(10)]
        public string maQuyen { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
