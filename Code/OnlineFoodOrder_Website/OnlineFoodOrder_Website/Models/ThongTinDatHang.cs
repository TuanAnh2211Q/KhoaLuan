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
    
    public partial class ThongTinDatHang
    {
        public string maDatHang { get; set; }
        public string maHang { get; set; }
        public string maNCC { get; set; }
        public Nullable<int> soLuongDat { get; set; }
        public Nullable<decimal> tongDonGia { get; set; }
    
        public virtual DatHang DatHang { get; set; }
        public virtual MatHang MatHang { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
