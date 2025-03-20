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
        public ItemTable() : base()
        {
        }

        public void InsertRow(string itemID, string itemName, double price, string category)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO Item (ItemID, ItemName, Price, Category) " +
                               "VALUES (@ItemID, @ItemName, @Price, @Category)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemID);
                    cmd.Parameters.AddWithValue("@ItemName", itemName);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@Category", category);

                    cmd.ExecuteNonQuery();

                }
            }
        }

        public object GetValue(string itemID, string column)
        {
            List<string> allowedColumns = new List<string> { "ItemID", "ItemName", "Price", "Category" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Item WHERE ItemID = @ItemID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader[column];
                        }
                        else
                        {
                            throw new Exception("Cannot find data. Are you sure you entered the ItemID and column name correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "ItemID", "ItemName", "Price", "Category" };

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

                        return columnValues;
                    }
                }

            }
        }

        public List<object> GetRowValues(string itemID)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM Item WHERE ItemID = @ItemID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["ItemID"]);
                            rowValues.Add(reader["ItemName"]);
                            rowValues.Add(reader["Price"]);
                            rowValues.Add(reader["Category"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered ItemID correctly?");
                        }
                    }
                }

            }
        }

        public void UpdateValue(string itemID, string column, object newValue)
        {
            List<string> allowedColumns = new List<string> { "ItemID", "ItemName", "Price", "Category" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"UPDATE Item SET {column} = @NewValue WHERE ItemID = @ItemID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRow(string itemID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Item WHERE ItemID = @ItemID";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ItemID", itemID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Deletion failed. The entered ItemID was not found.");
                    }
                }
            }
        }

        public List<string> GetItemIDsOfCategory(string category)
        {
            List<string> itemIDs = new List<string>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "SELECT ItemID FROM Item WHERE Category = @Category";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Category", category);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            itemIDs.Add(reader["ItemID"].ToString());
                        }
                        if (itemIDs.Count > 0)
                        {
                            return itemIDs;
                        }
                        else
                        {
                            throw new Exception("No ItemID(s) with the provided Category were found.");
                        }
                    }
                }
            }
        }

        public string GetNewItemID(string category)
        {
            string previousItemID;
            string newItemID;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 ItemID
                    FROM Item 
                    WHERE Category = @Category
                    ORDER BY CAST(SUBSTRING(ItemID, 2, LEN(ItemID)-1) AS INT) DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Category", category);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            previousItemID = reader["ItemID"].ToString();
                            int previousItemIDNum = Convert.ToInt32(previousItemID.Substring(1));
                            int newItemIDNum = previousItemIDNum + 1;
                            newItemID = $"{previousItemID[0]}{newItemIDNum:D3}";

                            return newItemID;
                        }
                        else
                        {
                            return $"{category[0]}001".ToUpper();
                        }
                    }
                }

            }
        }
    }
}
