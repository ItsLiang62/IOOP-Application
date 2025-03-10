using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public abstract class table
    {
        protected string ConnectionString
        { get; set; }

        public table(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
