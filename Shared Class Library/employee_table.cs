using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public class employee_table : table, ITable 
    {
        public employee_table(SqlConnection conn) : base(conn)
        {
        }

        public void insertRow(string employeeID, string employeeName, string position, string gender, string email, string phoneNumber, string dob, string accountPassword)
        {
            string query = "insert into Employee ("
        }
    }
}
