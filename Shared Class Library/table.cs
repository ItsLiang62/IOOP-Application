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
            ConnectionString = "Data Source=192.168.0.196,1433;Initial Catalog=IOOP;User ID=Adrian;Password=1212asas3434;Trust Server Certificate=True";
        }
    }
}
