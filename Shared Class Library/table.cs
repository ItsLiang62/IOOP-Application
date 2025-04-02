using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public abstract class Table
    {
        protected string ConnectionString
        { get; set; }

        public Table()
        {
            //Enter connection string here before running the application
            //ConnectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
            ConnectionString = "Server=tcp:ioop-sql-server.database.windows.net,1433;Initial Catalog=IOOP-DB;Persist Security Info=False;User ID=CloudSA1adb6faf;Password=Mm05087732@@;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
    }
}
