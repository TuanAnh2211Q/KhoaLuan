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

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();


            try
            {
                Open();

                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                Close();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            try
            {
                Open();
                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                Close();
            }
            catch (Exception)
            {

                throw;
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            try
            {
                Open();
                SqlCommand command = new SqlCommand(query, conn);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                Close();


            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }
    }

}
