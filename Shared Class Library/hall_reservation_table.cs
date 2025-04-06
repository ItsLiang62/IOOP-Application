using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    public class HallReservationTable : Table
    {
        public HallReservationTable() : base()
        {
        }

        public void InsertRow(string reservationID, string hallNumber, string customerID, string eventType, string eventDate, int expectedCount, string reservationStatus, string requestResponse, string remarks)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO HallReservation (ReservationID, HallNumber, CustomerID, EventType, EventDate, ExpectedCount, ReservationStatus, RequestResponse, Remarks) " +
                               "VALUES (@ReservationID, @HallNumber, @CustomerID, @EventType, @EventDate, @ExpectedCount, @ReservationStatus, @RequestResponse, @Remarks)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@HallNumber", hallNumber);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@EventType", eventType);
                    cmd.Parameters.AddWithValue("@EventDate", DateTime.ParseExact(eventDate, "d/M/yyyy", CultureInfo.InvariantCulture));
                    cmd.Parameters.AddWithValue("@ExpectedCount", expectedCount);
                    cmd.Parameters.AddWithValue("@ReservationStatus", reservationStatus);
                    cmd.Parameters.AddWithValue("@RequestResponse", requestResponse);
                    cmd.Parameters.AddWithValue("@Remarks", remarks);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public object GetValue(string reservationID, string column)
        {
            List<string> allowedColumns = new List<string> { "ReservationID", "HallNumber", "CustomerID", "EventType", "EventDate", "ExpectedCount", "ReservationStatus", "RequestResponse", "Remarks" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM HallReservation WHERE ReservationID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (column == "Event Date")
                        {
                            if (reader.Read())
                            {
                                return ((DateTime)reader[column]).ToString("dd/MM/yyyy");
                            }
                            else
                            {
                                throw new Exception("Cannot find data. Are you sure you entered the ReservationID correctly?");
                            }
                        }
                        else
                        {
                            if (reader.Read())
                            {
                                return reader[column];
                            }
                            else
                            {
                                throw new Exception("Cannot find data. Are you sure you entered the ReservationID correctly?");
                            }
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "ReservationID", "HallNumber", "CustomerID", "EventType", "EventDate", "ExpectedCount", "ReservationStatus", "RequestResponse", "Remarks" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            List<object> columnValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM HallReservation";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (column == "EventDate")
                        {
                            while (reader.Read())
                            {
                                columnValues.Add(((DateTime)reader[column]).ToString("dd/MM/yyyy"));
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

        public List<object> GetRowValues(string reservationID)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM HallReservation WHERE ReservationID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["ReservationID"]);
                            rowValues.Add(reader["HallNumber"]);
                            rowValues.Add(reader["CustomerID"]);
                            rowValues.Add(reader["EventType"]);
                            rowValues.Add(((DateTime)reader["EventDate"]).ToString("dd/MM/yyyy"));
                            rowValues.Add(reader["ExpectedCount"]);
                            rowValues.Add(reader["ReservationStatus"]);
                            rowValues.Add(reader["RequestResponse"]);
                            rowValues.Add(reader["Remarks"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered ReservationID correctly?");
                        }
                    }
                }

            }
        }

        public void UpdateValue(string reservationID, string column, object newValue)
        {
            List<string> allowedColumns = new List<string> { "ReservationID", "HallNumber", "CustomerID", "EventType", "EventDate", "ExpectedCount", "ReservationStatus", "RequestResponse", "Remarks" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = $"UPDATE HallReservation SET {column} = @NewValue WHERE ReservationID = @ReservationID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NewValue", newValue);
                    cmd.Parameters.AddWithValue("@reservationID", reservationID);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteRow(string reservationID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE FROM HallReservation WHERE ReservationID = @ReservationID";


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Deletion failed. The entered ReservationID was not found");
                    }
                }
            }
        }

        public string GetNewReservationID()
        {
            string previousCustomerID;
            string newCustomerID;

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = @"
                    SELECT TOP 1 ReservationID
                    FROM HallReservation
                    ORDER BY CAST(SUBSTRING(ReservationID, 3, LEN(ReservationID)-1) AS INT) DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            previousCustomerID = reader["ReservationID"].ToString();
                            int previousCustomerIDNum = Convert.ToInt32(previousCustomerID.Substring(2));
                            int newCustomerIDNum = previousCustomerIDNum + 1;
                            newCustomerID = $"RE{newCustomerIDNum:D3}";

                            return newCustomerID;
                        }
                        else
                        {
                            return $"RE001".ToUpper();
                        }
                    }
                }

            }
        }
    }
}
