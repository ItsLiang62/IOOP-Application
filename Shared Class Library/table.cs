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
            ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Chef_T1;Trusted_Connection=True;"; //"Data Source=172.18.48.1;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }
    }
}
