namespace VEB.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            DonHangs = new HashSet<DonHang>();
            TaiKhoanNhanViens = new HashSet<TaiKhoanNhanVien>();
        }

        [Key]
        [StringLength(10)]
        public string maNhanVien { get; set; }

        [StringLength(100)]
        public string tenNhanVien { get; set; }

        [StringLength(10)]
        public string Phai { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string diaChi { get; set; }

        [StringLength(10)]
        public string maChucDanh { get; set; }

        [StringLength(10)]
        public string maLoaiNhanVien { get; set; }

        public virtual ChucDanh ChucDanh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }

        public virtual LoaiNhanVien LoaiNhanVien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanNhanVien> TaiKhoanNhanViens { get; set; }

      

    }
}
