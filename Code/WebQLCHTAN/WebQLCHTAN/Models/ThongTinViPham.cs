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
    
    public partial class ThongTinViPham
    {
        public string maViPham { get; set; }
        public string maNhanVien { get; set; }
        public string ghiChu { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual ViPham ViPham { get; set; }
    }
}
