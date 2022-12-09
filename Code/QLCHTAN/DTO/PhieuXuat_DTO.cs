using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuat_DTO
    {
        private string maXuat;

        public string MaXuat
        {
            get { return maXuat; }
            set { maXuat = value; }
        }

        private DateTime ngayXuat ;

        public DateTime NgayXuat
        {
            get { return ngayXuat ; }
            set { ngayXuat  = value; }
        }
        private bool trangThai;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }



        public PhieuXuat_DTO(string MaXuat, DateTime NgayXuat, bool TrangThai)
        {
            this.maXuat = MaXuat;
            this.ngayXuat = NgayXuat;
            this.trangThai = TrangThai;
        }
    }
}
