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
    
    public partial class ThongTinKhuyenMai
    {
        public string maKhuyenMai { get; set; }
        public string maSanPham { get; set; }
        public Nullable<System.DateTime> ngayBatDau { get; set; }
        public Nullable<System.DateTime> ngayKetThuc { get; set; }
        public string ghiChu { get; set; }
    
        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
