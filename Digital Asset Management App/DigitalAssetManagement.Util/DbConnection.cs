using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace DigitalAssetManagement.Util
{
    public static class DBUtil
    {
        readonly static SqlConnection sqlConnection;
        static DBUtil()
        {
            sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
        }

        public static SqlConnection SqlConnection => sqlConnection;
    }
    //public static class DbUtil
    //{
    //    public static SqlConnection GetDBConnection()
    //    {

    //        SqlConnection connection = new SqlConnection(connectionString);
    //        sqlConnection.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnection"].ConnectionString;
    //        return connection;
    //    }

    //}

}
