namespace VEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhachHang()
        {
            GioHangs = new HashSet<GioHang>();
        }

        [StringLength(100)]
        public string tenKhachHang { get; set; }

        [StringLength(10)]
        public string Phai { get; set; }

        [Required]
        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(100)]
        public string diaChi { get; set; }

        public string ghiChu { get; set; }

        [Key]
        public int idKhachHang { get; set; }

        [StringLength(20)]
        public string matKhau { get; set; }

        [StringLength(10)]
        public string maLoaiKhach { get; set; }

        public virtual DanhGia DanhGia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GioHang> GioHangs { get; set; }

        public virtual LoaiKhachHang LoaiKhachHang { get; set; }
    }
}
