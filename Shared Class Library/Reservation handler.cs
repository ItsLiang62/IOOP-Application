// Badr

using System;
using System.Collections;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

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

            string reservationID = new HallReservationTable().GetNewReservationID();
            string hallNumber = "";
            try
            {
                hallNumber = GetAvailableHalls(_expectedPeople)[0];
            }
            catch (Exception)
            {
                MessageBox.Show("No halls available");
            }
            string reservationStatus = "Pending";
            string requestResponse = "";

            // Database connection string
            string connectionString = "Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

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
                        new HallTable().UpdateValue(hallNumber, "IsAvailable", false);
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

        private List<string> GetAvailableHalls(int expectedCount)
        {
            HallTable hallTable = new HallTable();

            List<string> suitableHalls = new List<string>();

            List<object> hallNumbers = hallTable.GetColumnValues("HallNumber");

            foreach (object hallNumber in hallNumbers)
            {
                bool isAvailable = Convert.ToBoolean(hallTable.GetValue(hallNumber.ToString(), "IsAvailable"));
                int capacity = Convert.ToInt32(hallTable.GetValue(hallNumber.ToString(), "Capacity"));

                if (isAvailable && capacity >= expectedCount)
                {
                    suitableHalls.Add(hallNumber.ToString());
                }
            }

            return suitableHalls;
        }
    }
}
