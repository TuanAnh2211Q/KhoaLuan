//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebQLCHTAN.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GioHang
    {
        public string maGioHang { get; set; }
        public Nullable<int> soLuong { get; set; }
        public Nullable<int> idKhachHang { get; set; }
        public string maSanPham { get; set; }
    
        public virtual SanPham SanPham { get; set; }
        public virtual KhachHang KhachHang { get; set; }
    }
}
