using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public class FeedbackTable : Table
    {
        public FeedbackTable() : base()
        {
        }

        public void InsertRow(string feedbackID, string customerID, string feedbackSentence, int rating)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO Feedback (FeedbackID, CustomerID, FeedbackSentence, Rating)" +
                               "VALUES (@FeedbackID, @CustomerID, @FeedbackSentence, @Rating)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@FeedbackSentence", feedbackSentence);
                    cmd.Parameters.AddWithValue("@Rating", rating);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public object GetValue(string feedbackID, string column)
        {
            List<string> allowedColumns = new List<string> { "FeedbackID", "CustomerID", "FeedbackSentence", "Rating" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Feedback WHERE FeedbackID = @FeedbackID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader[column];
                        }
                        else
                        {
                            throw new Exception("Cannot find data. Are you sure you entered the FeedbackID correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "FeedbackID", "CustomerID", "FeedbackSentence", "Rating" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            List<object> columnValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Feedback";

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

        public List<object> GetRowValues(string feedbackID)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM Feedback WHERE FeedbackID = @FeedbackID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["FeedbackID"]);
                            rowValues.Add(reader["CustomerID"]);
                            rowValues.Add(reader["FeedbackSentence"]);
                            rowValues.Add(reader["Rating"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered FeedbackID correctly?");
                        }
                    }
                }

            }
        }

        public void UpdateValue(string feedbackID, string column, object newValue)
        {
            List<string> allowedColumns = new List<string> { "FeedbackID", "CustomerID", "FeedbackSentence", "Rating" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"UPDATE Feedback SET {column} = @NewValue WHERE FeedbackID = @FeedbackID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRow(string feedbackID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM Feedback WHERE FeedbackID = @FeedbackID";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Deletion failed. The entered FeedbackID was not found");
                    }
                }
            }
        }

        public string GetNewFeedbackID()
        {
            string previousFeedbackID;
            string newFeedbackID;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 FeedbackID
                    FROM Feedback 
                    ORDER BY CAST(SUBSTRING(FeedbackID, 3, LEN(FeedbackID)-1) AS INT) DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            previousFeedbackID = reader["FeedbackID"].ToString();
                            int previousFeedbackIDNum = Convert.ToInt32(previousFeedbackID.Substring(2));
                            int newFeedbackIDNum = previousFeedbackIDNum + 1;
                            newFeedbackID = $"FE{newFeedbackIDNum:D3}";

                            return newFeedbackID;
                        }
                        else
                        {
                            return $"FE001".ToUpper();
                        }
                    }
                }

            }
        }
    }
}
