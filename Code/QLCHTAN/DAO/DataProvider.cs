using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class DataProvider
    {
        public SqlConnection conn;
        public static string DataSource { get; set; }

        public string DataBase { get; set; }

        public string Username { get; set; }
        
        public string Password { get; set; }

        public string connSTR { get; set; }

        public DataProvider()
        {
            this.DataBase = "QLCUAHANGTHUCANNHANH";
            this.Username = "sa";
            this.Password = "123";
            this.connSTR = @"Data Source="+DataSource+";Initial Catalog="+DataBase+";Persist Security Info=True;User ID="+Username+";Password="+Password+"";
            conn = new SqlConnection(connSTR);
        }

        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else
                return;
        }

        public void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        public void Dispose()
        {
            Close();
            conn.Dispose();
        }

       
    }

}
