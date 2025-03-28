using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Class_Library
{
     public class Reservation_handler
    {

        private string _connectionString;
        private string _customerID;
        private string _eventType;
        private DateTime _eventDate;
        private int _expectedPeople;
        private string _additionalThings;

        // Constructor for initializing the reservation handler object
        public   Reservation_handler(string connectionString, string customerID, string eventType, DateTime eventDate, int expectedPeople, string additionalThings)
        {
            _connectionString = connectionString;
            _customerID = customerID;
            _eventType = eventType;
            _eventDate = eventDate;
            _expectedPeople = expectedPeople;
            _additionalThings = additionalThings;
        }

        // Method to validate if the required fields are filled
        public bool ValidateFields()
        {
            // Check if the required fields are filled: EventType, EventDate, and ExpectedPeople
            if (string.IsNullOrWhiteSpace(_eventType) || _expectedPeople <= 0 || _eventDate == DateTime.MinValue)
            {
                MessageBox.Show("Please fill in all required fields: Event Type, Event Date, and Expected Number of People.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Method to save the reservation data into the database (simplified for demonstration purposes)
        public bool SaveReservation()
        {
            // Check if the fields are valid
            if (!ValidateFields())
            {
                return false;  // Don't proceed if fields are invalid
            }

            // SQL query for inserting the reservation
            string query = @"INSERT INTO HallReservation 
                         (ReservationID, HallNumber, CustomerID, EventType, EventDate, ReservationStatus, Remarks, RequestResponse, ExpectedCount)
                         VALUES 
                         (@ReservationID, @HallNumber, @CustomerID, @EventType, @EventDate, @ReservationStatus, @Remarks, @RequestResponse, @ExpectedCount)";

            string reservationID = Guid.NewGuid().ToString("N");
            string hallNumber = "TBD";
            string reservationStatus = "Pending";
            string requestResponse = "";

            // Database connection string
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    // Add parameters to the query
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);
                    cmd.Parameters.AddWithValue("@HallNumber", hallNumber);
                    cmd.Parameters.AddWithValue("@CustomerID", _customerID);
                    cmd.Parameters.AddWithValue("@EventType", _eventType);
                    cmd.Parameters.AddWithValue("@EventDate", _eventDate);
                    cmd.Parameters.AddWithValue("@ReservationStatus", reservationStatus);
                    cmd.Parameters.AddWithValue("@Remarks", _additionalThings);
                    cmd.Parameters.AddWithValue("@RequestResponse", requestResponse);
                    cmd.Parameters.AddWithValue("@ExpectedCount", _expectedPeople);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true; // Successfully saved the reservation
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving reservation: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }
        }
    }
}
