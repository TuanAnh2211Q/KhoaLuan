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
    
    public partial class TaiKhoanNhanVien
    {
        public int id { get; set; }
        public string tenTaiKhoan { get; set; }
        public string matKhau { get; set; }
        public string maNhanVien { get; set; }
        public string maQuyen { get; set; }
    
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhanQuyen PhanQuyen { get; set; }
    }
}
