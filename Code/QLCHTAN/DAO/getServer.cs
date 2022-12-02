using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace DAO
{
      public  class getServer
    {
       public List<String> GetServerNameFromPC()
        {
            List<String> ServerList = new List<string>();
            SqlDataSourceEnumerator serverNames = SqlDataSourceEnumerator.Instance;
            DataTable serversInfo = serverNames.GetDataSources();

            //for(int i=0;i<=serversInfo.Rows.Count;i++)
            //{
            //    DataRow r = serversInfo.Rows[i];
            //    string serverName ;
            //    if(r.ToString()!="")
            //    {
            //        serverName = r["Servername"].ToString() + "\\" + r.ToString();
            //    }
            //    else
            //    {
            //        serverName = r["Servername"].ToString();
            //    }    
            //    ServerList.Add(serverName);
            //}
            //return ServerList;

            foreach (DataRow r in serversInfo.Rows)
            {
                string serverName = r["Servername"].ToString();
                if (r[1].ToString() != "")
                {
                    serverName = r["Servername"].ToString() + "\\" + r[1].ToString();
                }
                ServerList.Add(serverName);
            }
            return ServerList;

        } 
    }
}
