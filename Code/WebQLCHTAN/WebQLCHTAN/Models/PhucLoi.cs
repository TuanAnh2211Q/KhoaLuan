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
    
    public partial class PhucLoi
    {
        public PhucLoi()
        {
            this.ThongTinPhucLois = new HashSet<ThongTinPhucLoi>();
        }
    
        public string maPhucLoi { get; set; }
        public string tenPhucLoi { get; set; }
        public Nullable<decimal> mucThuong { get; set; }
    
        public virtual ICollection<ThongTinPhucLoi> ThongTinPhucLois { get; set; }
    }
}
