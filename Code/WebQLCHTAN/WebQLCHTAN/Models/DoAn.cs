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
    
    public partial class DoAn
    {
        public DoAn()
        {
            this.ThongTinThanhPhanDoAns = new HashSet<ThongTinThanhPhanDoAn>();
        }
    
        public string maDoAn { get; set; }
        public string maLoaiDoAn { get; set; }
        public string tenDoAn { get; set; }
        public byte[] HinhURL { get; set; }
    
        public virtual SanPham SanPham { get; set; }
        public virtual ThongTinDoAn ThongTinDoAn { get; set; }
        public virtual LoaiDoAn LoaiDoAn { get; set; }
        public virtual ICollection<ThongTinThanhPhanDoAn> ThongTinThanhPhanDoAns { get; set; }
    }
}
