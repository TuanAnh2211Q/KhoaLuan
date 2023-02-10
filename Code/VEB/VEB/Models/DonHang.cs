namespace VEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonHang")]
    public partial class DonHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DonHang()
        {
            ThongTinDonHangs = new HashSet<ThongTinDonHang>();
        }

        [Key]
        [StringLength(10)]
        public string maDonHang { get; set; }

        [StringLength(50)]
        public string tenDonHang { get; set; }

        [StringLength(10)]
        public string maLoaiDon { get; set; }

        public bool? maHinhthuc { get; set; }

        [StringLength(10)]
        public string maNhanVien { get; set; }

        [StringLength(11)]
        public string SDTKhachHang { get; set; }

        [StringLength(10)]
        public string maKhuyenMai { get; set; }

        public DateTime? thoiGianDat { get; set; }

        public int? trangThai { get; set; }

        public string ghiChu { get; set; }

        public int? idKhachHang { get; set; }

        [Column(TypeName = "money")]
        public decimal? tongGia { get; set; }

        public virtual HinhThucThanhToan HinhThucThanhToan { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }

        public virtual LoaiDonHang LoaiDonHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinDonHang> ThongTinDonHangs { get; set; }
    }
}
