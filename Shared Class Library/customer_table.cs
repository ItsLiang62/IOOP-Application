using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public class CustomerTable: Table
    {
        public CustomerTable(string connectionString) : base(connectionString)
        {
        }

        public void InsertRow(string customerID, string customerName, string gender, string email, string phoneNumber)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO Customer (CustomerID, CustomerName, Gender, Email, PhoneNumber) " +
                               "VALUES (@CustomerID, @CustomerName, @Gender, @Email, @PhoneNumber)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@CustomerName", customerName);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                    cmd.ExecuteNonQuery();
                    
                }
            }
        }

        public object GetValue(string customerID, string column)
        {
            List<string> allowedColumns = new List<string> { "CustomerID", "CustomerName", "Gender", "Email", "PhoneNumber" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Customer WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader[column];
                        }
                        else
                        {
                            throw new Exception("Cannot find data. Are you sure you entered the CustomerID and column name correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "CustomerID", "CustomerName", "Gender", "Email", "PhoneNumber" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            List<object> columnValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Customer";

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

        public List<object> GetRowValues(string customerID)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM Customer WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["CustomerID"]);
                            rowValues.Add(reader["CustomerName"]);
                            rowValues.Add(reader["Gender"]);
                            rowValues.Add(reader["Email"]);
                            rowValues.Add(reader["Phone"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered CustomerID correctly?");
                        }
                    }
                }

            }
        }

        public string GetCustomerIDWithEmail(string email)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT CustomerID FROM Customer WHERE Email = @Email";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", email);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader["CustomerID"].ToString();
                        }
                        else
                        {
                            throw new Exception("Cannot find CustomerID with the provided Email. Are you sure you entered the Email correctly?");
                        }
                    }
                }

            }
        }

        public string GetNewCustomerID()
        {
            string previousCustomerID;
            string newCustomerID;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 CustomerID
                    FROM Customer
                    ORDER BY CAST(SUBSTRING(CustomerID, 3, LEN(CustomerID)-1) AS INT) DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            previousCustomerID = reader["CustomerID"].ToString();
                            int previousCustomerIDNum = Convert.ToInt32(previousCustomerID.Substring(2));
                            int newCustomerIDNum = previousCustomerIDNum + 1;
                            newCustomerID = $"CU{newCustomerIDNum:D3}";

                            return newCustomerID;
                        }
                        else
                        {
                            return $"CU001".ToUpper();
                        }
                    }
                }

            }
        }

        public void UpdateValue(string customerID, string column, object newValue)
        {
            List<string> allowedColumns = new List<string> { "CustomerID", "CustomerName", "Gender", "Email", "PhoneNumber" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"UPDATE Customer SET {column} = @NewValue WHERE CustomerID = @CustomerID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Update failed. The entered CustomerID or column name was not found.");
                    }
                }
            }
        }

        public void DeleteRow(string customerID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Customer WHERE CustomerID = @CustomerID";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Deletion failed. The entered CustomerID was not found");
                    }
                }
            }
        }
    }
}
