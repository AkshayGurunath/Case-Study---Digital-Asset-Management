using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Asset_Management.util
{
    public static class DbUtil
    {
        public static SqlConnection GetDBConnection()
        {
            string connectionString = "Data Source=LAPTOP-2H2P4CPV;Initial Catalog=Asset_Management;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}
