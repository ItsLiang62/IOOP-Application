using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public class employeeTable : table 
    {
        public employeeTable(SqlConnection conn) : base(conn)
        {
        }

        public void insertRow(string employeeID, string employeeName, string position, string gender, string email, string phoneNumber, string dob, string accountPassword)
        {
            string query = "INSERT INTO Employee (EmployeeID, EmployeeName, Position, Gender, Email, PhoneNumber, DOB, AccountPassword) " +
                           "VALUES (@EmployeeID, @EmployeeName, @Position, @Gender, @Email, @PhoneNumber, @DOB, @AccountPassword)";

            using (SqlCommand cmd = new SqlCommand(query, Conn))
            {
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                cmd.Parameters.AddWithValue("@EmployeeName", employeeName);
                cmd.Parameters.AddWithValue("@Position", position);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@AccountPassword", accountPassword);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
