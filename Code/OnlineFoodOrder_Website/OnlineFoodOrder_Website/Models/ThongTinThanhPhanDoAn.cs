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
    
    public partial class ThongTinThanhPhanDoAn
    {
        public string maThanhPhan { get; set; }
        public string tenThanhPhan { get; set; }
        public string dinhLuong { get; set; }
        public string maDoAn { get; set; }
        public Nullable<int> soLuong { get; set; }
    
        public virtual DoAn DoAn { get; set; }
        public virtual MatHang MatHang { get; set; }
    }
}