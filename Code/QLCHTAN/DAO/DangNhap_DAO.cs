using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Windows.Forms;


namespace DAO
{
    public class DangNhap_DAO:DataProvider
    {
     
        public bool kiemTraDangNhap(string taiKhoan,string matKhau)
        {
            try
            {
                Open();
               SqlDataAdapter da = new SqlDataAdapter("select * from dbo.KTDN'" + taiKhoan + "','" + matKhau + "','", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt!=null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        return true;
                    }
                }
            } 
            catch(Exception)
            {
                MessageBox.Show("Lỗi !!! Truy vấn dữ liệu sai hoặc kết nối server thất bại!!");

            }
            finally 
            {
                Close();
            }
            return false;
        }
        public void dangNhap()
        {
            try 
            {
                Open();
                //string kt= "select * from dbo.DangNhap('"+DangNhap_DTO.
            }
            catch
            {

            }
        }
    }
}
