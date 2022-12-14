//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineFoodOrder_Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            this.DonHangs = new HashSet<DonHang>();
            this.TaiKhoanNhanViens = new HashSet<TaiKhoanNhanVien>();
            this.ThongTinPhucLois = new HashSet<ThongTinPhucLoi>();
            this.ThongTinViPhams = new HashSet<ThongTinViPham>();
        }
    
        public string maNhanVien { get; set; }
        public string tenNhanVien { get; set; }
        public string Phai { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string diaChi { get; set; }
        public string maChucDanh { get; set; }
        public string maLoaiNhanVien { get; set; }
    
        public virtual ChamCong ChamCong { get; set; }
        public virtual ChucDanh ChucDanh { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DonHang> DonHangs { get; set; }
        public virtual LoaiNhanVien LoaiNhanVien { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TaiKhoanNhanVien> TaiKhoanNhanViens { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinPhucLoi> ThongTinPhucLois { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinViPham> ThongTinViPhams { get; set; }
    }
}
