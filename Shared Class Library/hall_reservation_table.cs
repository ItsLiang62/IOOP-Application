using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    class HallReservationTable : Table
    {
        public HallReservationTable(string connectionString) : base(connectionString)
        {
        }

        public void InsertRow(string reservationID, string hallNumber, string customerID, string eventType, string reservationStatus, string remarks)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO HallReservation (ReservationID, HallNumber, CustomerID, EventType, ReservationStatus, Remarks) " +
                               "VALUES (@ReservationID, @HallNumber, @CustomerID, @EventType, @ReservatioinStatus, @Remarks)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@HallNumber", hallNumber);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@EventType", eventType);
                    cmd.Parameters.AddWithValue("@ReservationStatus", reservationStatus);
                    cmd.Parameters.AddWithValue("@Remarks", remarks);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public object GetValue(string reservationID, string column)
        {
            List<string> allowedColumns = new List<string> { "ReservatonID, HallNumber, CustomerID, EventType, ReservationStatus, Remarks" };

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

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "ReservatonID, HallNumber, CustomerID, EventType, ReservationStatus, Remarks" };

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
                            rowValues.Add(reader["ReservationStatus"]);
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
            List<string> allowedColumns = new List<string> { "ReservatonID, HallNumber, CustomerID, EventType, ReservationStatus, Remarks" };

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

                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Update failed. The entered ReservationID or column name was not found.");
                    }
                }
            }
        }

        public void DeleteRow(string reservationID)
        {
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "DELETE * FROM HallReservation WHERE ReservationID = @ReservationID";


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
    }
}
