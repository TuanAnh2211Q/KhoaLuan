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
        //instance là Design patern Singleton nha mấy bro :V
        private static DataProvider instance;
        public static DataProvider Instance 
        {
            get {
                    if (instance == null)
                        instance = new DataProvider();
                    return DataProvider.instance; 
                }
            set
            {
                DataProvider.instance = value;
            }
        }

        public SqlConnection conn;
        public static string DataSource { get; set; }

        public string DataBase { get; set; }

        public string Username { get; set; }
        
        public string Password { get; set; }

        public string connSTR { get; set; }
      
        //XÓa dataSource

        public DataProvider()
        {
            this.DataBase = "QLCUAHANGTHUCANNHANH";
            this.Username = "sa";
            this.Password = "123";
            this.connSTR = @"Database=" + DataBase+";Persist Security Info=True;User ID="+Username+";Password="+Password+"";
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

        //Sài này truy vấn cho mau nha bro
        /// Này thêm nè
        public DataTable ExecuteQuery(string query, object[] Parameter = null)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection =new SqlConnection(connSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if(Parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string item in listPara)
                    {
                        if(item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, Parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
        // sài để update cho nhẹ :v
        public int ExecuteNoQuery(string query, object[] Parameter = null)
        {
           int data =0;
            using (SqlConnection connection = new SqlConnection(connSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (Parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, Parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteNonQuery();
                connection.Close();
                
            }
            return data;
        }
        //Sài để đếm số lượng đồ nè (select count*)
        public object ExecuteScalar(string query, object[] Parameter = null)
        {
           object data = 0;
            using (SqlConnection connection = new SqlConnection(connSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                if (Parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, Parameter[i]);
                            i++;
                        }
                    }
                }
                data = command.ExecuteScalar();
                connection.Close();

            }
            return data;
        }
    }

}
