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
    
    public partial class NhapKho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhapKho()
        {
            this.ThongTinNhapKhoes = new HashSet<ThongTinNhapKho>();
        }
    
        public string maNhap { get; set; }
        public Nullable<System.DateTime> ngayNhap { get; set; }
        public string maDatHang { get; set; }
        public string ghiChu { get; set; }
        public Nullable<bool> trangThai { get; set; }
    
        public virtual DatHang DatHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinNhapKho> ThongTinNhapKhoes { get; set; }
    }
}