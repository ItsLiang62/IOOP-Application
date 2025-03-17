using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public class ItemTable : Table
    {
        public ItemTable(string connectionString) : base(connectionString)
        {
        }

        public void InsertRow(string itemNumber, string itemName, double price, string category)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO Item (ItemNumber, ItemName, Price, Category) " +
                               "VALUES (@ItemNumber, @ItemName, @Price, @Category)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemNumber", itemNumber);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Category", category);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public object GetValue(string itemNumber, string column)
        {
            List<string> allowedColumns = new List<string> { "ItemNumber", "ItemName", "Price", "Category" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Item WHERE ItemNumber = @ItemNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemNumber", itemNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader[column];
                        }
                        else
                        {
                            throw new Exception("Cannot find data. Are you sure you entered the ItemNumber and column name correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "ItemNumber", "ItemName", "Price", "Category" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            List<object> columnValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Item";

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

        public List<object> GetRowValues(string itemNumber)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM Item WHERE ItemNumber = @ItemNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemNumber", itemNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["ItemNumber"]);
                            rowValues.Add(reader["ItemName"]);
                            rowValues.Add(reader["Price"]);
                            rowValues.Add(reader["Category"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered ItemName correctly?");
                        }
                    }
                }

            }
        }

        public void UpdateValue(string itemNumber, string column, object newValue)
        {
            List<string> allowedColumns = new List<string> { "ItemNumber", "ItemName", "Price", "Category" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"UPDATE Item SET {column} = @NewValue WHERE ItemNumber = @ItemNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.Parameters.AddWithValue("@ItemNumber", itemNumber);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Update failed. The entered ItemNumber or column name was not found.");
                    }
                }
            }
        }

        public void DeleteRow(string itemNumber)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE * FROM Item WHERE ItemNumber = @itemNumber";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemNumber", itemNumber);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Deletion failed. The entered ItemNumber was not found");
                    }
                }
            }
        }

        public List<string> GetItemNumbersOfCategory(string category)
        {
            List<string> itemNumbers = new List<string>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "SELECT ItemNumber FROM Item WHERE Category = @Category";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Category", category);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            itemNumbers.Add(reader["ItemNumber"].ToString());
                        }
                        if (itemNumbers.Count > 0)
                        {
                            return itemNumbers;
                        }
                        else
                        {
                            throw new Exception("No ItemNumber(s) with the provided Category were found. Are you sure you entered the correct category?");
                        }
                    }
                }
            }
        }
    }
}
