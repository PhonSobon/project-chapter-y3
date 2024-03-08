using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Maintenance
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()
        {
            // If necessary, change the following connection string
            // so it works for your system
            string connectionString =
                 "Data Source=ACER-ASPIRE-7;Initial Catalog=MMABooks;Integrated Security=True";
            SqlConnection connection =
                new SqlConnection(connectionString);
            return connection;
        }
    }
}
