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
    
    public partial class ViPham
    {
        public ViPham()
        {
            this.ThongTinViPhams = new HashSet<ThongTinViPham>();
        }
    
        public string maViPham { get; set; }
        public string tenViPham { get; set; }
        public Nullable<decimal> mucPhat { get; set; }
    
        public virtual ICollection<ThongTinViPham> ThongTinViPhams { get; set; }
    }
}