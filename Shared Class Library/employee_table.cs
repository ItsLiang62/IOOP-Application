using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shared_Class_Library
{
    public class EmployeeTable : Table 
    {
        public EmployeeTable(string connectionString) : base(connectionString)
        {
        }

        public void InsertRow(string employeeID, string employeeName, string position, string gender, string email, string phoneNumber, string dob, string accountPassword)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO Employee (EmployeeID, EmployeeName, Position, Gender, Email, PhoneNumber, DOB, AccountPassword) " +
                               "VALUES (@EmployeeID, @EmployeeName, @Position, @Gender, @Email, @PhoneNumber, @DOB, @AccountPassword)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
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

        public object GetValue(string employeeID, string column)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Employee WHERE EmployeeID = @employeeID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader[column];
                        }
                        else
                        {
                            throw new Exception("Cannot find data. Are you sure you entered the Employee ID and column name correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {

            List<object> columnValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Employee";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnValues.Add(reader[column]);
                        }
                        if (columnValues.Count > 0)
                        {
                            return columnValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find column. Are you sure you entered the column name correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetRowValues(string employeeID)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM Employee WHERE EmployeeID = @employeeID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["EmployeeID"]);
                            rowValues.Add(reader["EmployeeName"]);
                            rowValues.Add(reader["Position"]);
                            rowValues.Add(reader["Gender"]);
                            rowValues.Add(reader["Email"]);
                            rowValues.Add(reader["Phone"]);
                            rowValues.Add(reader["DOB"]);
                            rowValues.Add(reader["AccountPassword"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered Employee ID correctly?");
                        }
                    }
                }

            }
        }

        public string GetEmployeeIDWithEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT EmployeeID FROM Employee WHERE Email = @email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["EmployeeID"].ToString();
                        }
                        else
                        {
                            throw new Exception("Cannot find Employee ID with the provided Email. Are you sure you entered the Email correctly?");
                        }
                    }
                }

            }
        }

        public string GetNewEmployeeID(string position)
        {
            string previousEmployeeID;
            string newEmployeeID;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 EmployeeID
                    FROM Employee 
                    WHERE Position = @position
                    ORDER BY CAST(SUBSTRING(EmployeeID, 2, LEN(EmployeeID)-1) AS INT) DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@position", position);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            previousEmployeeID = reader["EmployeeID"].ToString();
                            int previousEmployeeIDNum = Convert.ToInt32(previousEmployeeID.Substring(1));
                            int newEmployeeIDNum = previousEmployeeIDNum + 1;
                            newEmployeeID = $"{previousEmployeeID[0]}{newEmployeeIDNum:D3}";

                            return newEmployeeID;
                        }
                        else
                        {
                           return $"{position[0]}001".ToUpper();
                        }
                    }
                }

            }
        }

        public void UpdateValue(string employeeID, string column, object newValue)
        {
            List<string> allowedColumns = new List<string> { "EmployeeID", "EmployeeName", "Position", "Gender", "Email", "PhoneNumber", "DOB", "AccountPassword" };

            if (!allowedColumns.Contains(column))
            {
                MessageBox.Show("Invalid column name. Please enter a correct column.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"UPDATE Employee SET {column} = @newValue WHERE EmployeeID = @employeeID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@newValue", newValue);
                    cmd.Parameters.AddWithValue("@employeeID", employeeID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Update failed. Record not found.");
                    }
                }
            }
        }

        public void DeleteRow(string employeeID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE * FROM Employee WHERE EmployeeID = @employeeID";

                
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("No Employee ID was found");
                    }
                }
            }
        }
    }
}
