// Wang Liang Xuan

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public class ItemOrderTable : Table
    {
        public ItemOrderTable() : base()
        {
        }
        public class SalesReportRecord
        {
            public string OrderID { get; set; }
            public string ItemName { get; set; }
            public string Category { get; set; }
            public double Price { get; set; }
            public string ChefEmployeeID { get; set; }
            public DateTime DateOfOrder { get; set; }
            public string OrderStatus { get; set; }
        }
       
        

        public void InsertRow(string orderID, string itemID, string customerID, string chefEmployeeID, string dateOfOrder, string orderStatus)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO ItemOrder (OrderID, ItemNumber, CustomerID, ChefEmployeeID, DateOfOrder, OrderStatus) " +
                               "VALUES (@OrderID, @ItemNumber, @CustomerID, @ChefEmployeeID, @DateOfOrder, @OrderStatus)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@OrderID", orderID);
                    cmd.Parameters.AddWithValue("@ItemNumber", itemID);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@ChefEmployeeID", chefEmployeeID);
                    cmd.Parameters.AddWithValue("@DateOfOrder", DateTime.ParseExact(dateOfOrder, "d/M/yyyy", CultureInfo.InvariantCulture));
                    cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public object GetValue(string orderID, string column)
        {
            List<string> allowedColumns = new List<string> { "OrderID", "ItemID", "CustomerID", "ChefEmployeeID", "DateOfOrder", "OrderStatus" };

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
            List<string> allowedColumns = new List<string> { "OrderID", "ItemID", "CustomerID", "ChefEmployeeID", "DateOfOrder", "OrderStatus" };

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
                        if (column == "DateOfOrder")
                        {
                            while (reader.Read())
                            {
                                columnValues.Add(((DateTime)reader["EventDate"]).ToString("dd/MM/yyyy"));
                            }
                        }
                        else
                        {
                            while (reader.Read())
                            {
                                columnValues.Add(reader[column]);
                            }
                        }
                        

                        return columnValues;
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
                            rowValues.Add(reader["ItemID"]);
                            rowValues.Add(reader["CustomerID"]);
                            rowValues.Add(reader["ChefEmployeeID"]);
                            rowValues.Add(((DateTime)reader["EventDate"]).ToString("dd/MM/yyyy"));
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
            List<string> allowedColumns = new List<string> { "OrderID", "ItemID", "CustomerID", "ChefEmployeeID", "DateOfOrder", "OrderStatus" };

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
                    if (column == "DateOfOrder")
                    {
                        DateTime newDate = DateTime.ParseExact(newValue.ToString(), "d/M/yyyy", CultureInfo.InvariantCulture);
                        cmd.Parameters.AddWithValue("@NewValue", newDate);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@NewValue", newValue);
                    }

                    cmd.Parameters.AddWithValue("@OrderID", orderID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRow(string orderID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM ItemOrder WHERE OrderID = @orderID";


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

        public string GetNewOrderID()
        {
            string previousOrderID;
            string newOrderID;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 OrderID
                    FROM ItemOrder 
                    ORDER BY CAST(SUBSTRING(OrderID, 2, LEN(OrderID)-1) AS INT) DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            previousOrderID = reader["OrderID"].ToString();
                            int previousOrderIDNum = Convert.ToInt32(previousOrderID.Substring(1));
                            int newOrderIDNum = previousOrderIDNum + 1;
                            newOrderID = $"X{newOrderIDNum:D3}";

                            return newOrderID;
                        }
                        else
                        {
                            return $"X001".ToUpper();
                        }
                    }
                }

            }
        }
    }
}
