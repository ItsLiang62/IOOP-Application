using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    class ItemOrderTable : Table
    {
        public ItemOrderTable(string connectionString) : base(connectionString)
        {
        }

        public void InsertRow(string orderID, string itemNumber, double customerID, string chefEmployeeID, string dateOfOrder, string orderStatus)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO ItemOrder (OrderID, ItemNumber, CustomerID, ChefEmployeeID, DateOfOrder, OrderStatus) " +
                               "VALUES (@OrderID, @ItemNumber, @CustomerID, @ChefEmployeeID, @DateOfOrder, @OrderStatus)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.AddWithValue("@ItemNumber", itemNumber);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@ChefEmployeeID", chefEmployeeID);
                    cmd.Parameters.AddWithValue("@DateOfOrder", dateOfOrder);
                    cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public object GetValue(string orderID, string column)
        {
            List<string> allowedColumns = new List<string> { "OrderID", "ItemNumber", "CustomerID", "ChefEmployeeID", "DateOfOrder", "OrderStatus" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM ItemOrder WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader[column];
                        }
                        else
                        {
                            throw new Exception("Cannot find data. Are you sure you entered the OrderID correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "OrderID", "ItemNumber", "CustomerID", "ChefEmployeeID", "DateOfOrder", "OrderStatus" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            List<object> columnValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM ItemOrder";

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

        public List<object> GetRowValues(string orderID)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM Item WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["OrderID"]);
                            rowValues.Add(reader["ItemNumber"]);
                            rowValues.Add(reader["CustomerID"]);
                            rowValues.Add(reader["ChefEmployeeID"]);
                            rowValues.Add(reader["DateOfOrder"]);
                            rowValues.Add(reader["OrderStatus"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered OrderID correctly?");
                        }
                    }
                }

            }
        }

        public void UpdateValue(string orderID, string column, object newValue)
        {
            List<string> allowedColumns = new List<string> { "OrderID", "ItemNumber", "CustomerID", "ChefEmployeeID", "DateOfOrder", "OrderStatus" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"UPDATE ItemOrder SET {column} = @NewValue WHERE OrderID = @OrderID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Update failed. The entered OrderID or column name was not found.");
                    }
                }
            }
        }

        public void DeleteRow(string orderID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE * FROM ItemOrder WHERE OrderID = @orderID";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Deletion failed. The entered OrderID was not found");
                    }
                }
            }
        }
    }
}
