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
    
    public partial class DatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DatHang()
        {
            this.NhapKhoes = new HashSet<NhapKho>();
            this.ThongTinDatHangs = new HashSet<ThongTinDatHang>();
            this.TraHangs = new HashSet<TraHang>();
        }
    
        public string maDatHang { get; set; }
        public Nullable<System.DateTime> ngayDatHang { get; set; }
        public Nullable<System.DateTime> ngayDuKienGiao { get; set; }
        public string ghiChu { get; set; }
        public string phuongThucThanhToan { get; set; }
        public Nullable<bool> trangThai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NhapKho> NhapKhoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinDatHang> ThongTinDatHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TraHang> TraHangs { get; set; }
    }
}
