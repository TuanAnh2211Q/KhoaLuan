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
    
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            this.MatHangs = new HashSet<MatHang>();
            this.ThongTinNhapKhoes = new HashSet<ThongTinNhapKho>();
            this.ThongTinDatHangs = new HashSet<ThongTinDatHang>();
            this.ThongTinTraHangs = new HashSet<ThongTinTraHang>();
        }
    
        public string maNCC { get; set; }
        public string tenNCC { get; set; }
        public string diaChiNCC { get; set; }
        public string emailNCC { get; set; }
        public string sdtNCC { get; set; }
        public string ghiChu { get; set; }
    
        public virtual ICollection<MatHang> MatHangs { get; set; }
        public virtual ICollection<ThongTinNhapKho> ThongTinNhapKhoes { get; set; }
        public virtual ICollection<ThongTinDatHang> ThongTinDatHangs { get; set; }
        public virtual ICollection<ThongTinTraHang> ThongTinTraHangs { get; set; }
    }
}