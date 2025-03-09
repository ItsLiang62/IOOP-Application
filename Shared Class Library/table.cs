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
        protected SqlConnection Conn
        { get; set; }

        public table(SqlConnection conn)
        {
            Conn = conn;
        }
    }
}
