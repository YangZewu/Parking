using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParKing;
namespace DAL
{
    public class DBHelper
    {
        //private static string constring;//= "Data Source=.;Initial Catalog=Parking;Integrated Security=True";
        private static SqlConnection connection;

        public static SqlConnection Connection
        {
            get
            {
                // 分析和处理数据库连接可能出现在不同状态
                string connectionstring = "data source=" + IpConfig.Ip + ";initial catalog=Parking;integrated security=true;";

                if (connection == null)
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }

        }
        //验证用户

        public static object executeScalar(string sql)
        {
            SqlCommand com = new SqlCommand(sql, Connection);
            return com.ExecuteScalar();
            
        }
        //非查询
        public static object ExecuteNonQuery(string sql)
        {
            SqlCommand com = new SqlCommand(sql, Connection);
            return com.ExecuteNonQuery();
        }

    }
 }

