using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    class IngredientsTable : Table
    {
        public IngredientsTable(string connectionString) : base(connectionString)
        {
        }

        public void InsertRow(string ingredientNumber, string ingredientName)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO Ingredients (IngredientNumber, IngredientName)" +
                               "VALUES (@IngredientNumber, @IngredientName)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IngredientNumber", ingredientNumber);
                    cmd.Parameters.AddWithValue("@IngredientName", ingredientName);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public object GetValue(string ingredientNumber, string column)
        {
            List<string> allowedColumns = new List<string> { "IngredientNumber, IngredientName" };

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
            List<string> allowedColumns = new List<string> { "IngredientNumber, IngredientName" };

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
    }
}
