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
    
    public partial class MatHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MatHang()
        {
            this.KhoBans = new HashSet<KhoBan>();
            this.ThongTinDatHangs = new HashSet<ThongTinDatHang>();
            this.ThongTinNhapKhoes = new HashSet<ThongTinNhapKho>();
            this.ThongTinThanhPhanDoAns = new HashSet<ThongTinThanhPhanDoAn>();
            this.ThongTinTraHangs = new HashSet<ThongTinTraHang>();
            this.ThongTinXuatKhoes = new HashSet<ThongTinXuatKho>();
        }
    
        public string maHang { get; set; }
        public string tenHang { get; set; }
        public string maNCC { get; set; }
        public string donVi { get; set; }
        public Nullable<System.DateTime> NSX { get; set; }
        public Nullable<System.DateTime> HSD { get; set; }
        public Nullable<decimal> donGia { get; set; }
        public string ghiChu { get; set; }
        public Nullable<bool> loaiHang { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhoBan> KhoBans { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
        public virtual NuocUong NuocUong { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinDatHang> ThongTinDatHangs { get; set; }
        public virtual ThongTinHangTon ThongTinHangTon { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinNhapKho> ThongTinNhapKhoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinThanhPhanDoAn> ThongTinThanhPhanDoAns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinTraHang> ThongTinTraHangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ThongTinXuatKho> ThongTinXuatKhoes { get; set; }
    }
}
