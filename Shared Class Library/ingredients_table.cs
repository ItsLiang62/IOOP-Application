using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public class IngredientsTable : Table
    {
        public IngredientsTable() : base()
        {
        }

        public void InsertRow(string ingredientNumber, string ingredientName, string quantity)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO Ingredients (IngredientNumber, IngredientName, Quantity)" +
                               "VALUES (@IngredientNumber, @IngredientName, @Quantity)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IngredientNumber", ingredientNumber);
                    cmd.Parameters.AddWithValue("@IngredientName", ingredientName);
                    cmd.Parameters.AddWithValue("@Quantity", quantity);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public object GetValue(string ingredientNumber, string column)
        {
            List<string> allowedColumns = new List<string> { "IngredientNumber, IngredientName", "Quantity" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Ingredients WHERE IngredientNumber = @IngredientNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IngredientNumber", ingredientNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader[column];
                        }
                        else
                        {
                            throw new Exception("Cannot find data. Are you sure you entered the IngredientNumber correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "IngredientNumber, IngredientName", "Quantity"};

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            List<object> columnValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Ingredients";

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

        public List<object> GetRowValues(string ingredientNumber)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM Ingredients WHERE IngredientNumber = @IngredientNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IngredientNumber", ingredientNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["IngredientNumber"]);
                            rowValues.Add(reader["IngredientName"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered IngredientNumber correctly?");
                        }
                    }
                }

            }
        }

        public void UpdateValue(string ingredientNumber, string column, object newValue)
        {
            List<string> allowedColumns = new List<string> { "IngredientNumber, IngredientName", "Quantity"};

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"UPDATE Ingredients SET {column} = @NewValue WHERE IngredientNumber = @IngredientNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.Parameters.AddWithValue("@IngredientNumber", ingredientNumber);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRow(string ingredientNumber)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Ingredients WHERE IngredientNumber = @IngredientNumber";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IngredientNumber", ingredientNumber);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Deletion failed. The entered IngredientNumber was not found");
                    }
                }
            }
        }

        public string GetNewIngredientNumber()
        {
            string previousIngredientNumber;
            string newIngredientNumber;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 IngredientNumber
                    FROM Ingredients
                    ORDER BY CAST(SUBSTRING(IngredientNumber, 3, LEN(IngredientNumber)-1) AS INT) DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            previousIngredientNumber = reader["IngredientNumber"].ToString();
                            int previousIngredientNumberNum = Convert.ToInt32(previousIngredientNumber.Substring(2));
                            int newIngredientNumberNum = previousIngredientNumberNum + 1;
                            newIngredientNumber = $"IN{newIngredientNumberNum:D3}";

                            return newIngredientNumber;
                        }
                        else
                        {
                            return $"IN001".ToUpper();
                        }
                    }
                }

            }
        }
    }
}
