using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
namespace Foodle_Point_Management_System
{
    public class DatabaseHelper
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ReservationDB"].ConnectionString;

        // Reservation Methods
        public DataTable GetReservations()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Reservations", conn))
            {
                conn.Open();
                dt.Load(cmd.ExecuteReader());
            }
            return dt;
        }

        public int AddReservation(string reservationId, string customerId, string hallNumber,
                                string eventType, int capacity, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "INSERT INTO Reservations VALUES (@ReservationID, @CustomerID, @HallNumber, @EventType, @Capacity, @Status)", conn))
            {
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@HallNumber", hallNumber);
                cmd.Parameters.AddWithValue("@EventType", eventType);
                cmd.Parameters.AddWithValue("@Capacity", capacity);
                cmd.Parameters.AddWithValue("@Status", status);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int UpdateReservation(string reservationId, string customerId, string hallNumber,
                                   string eventType, int capacity, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE Reservations SET CustomerID=@CustomerID, HallNumber=@HallNumber, " +
                "EventType=@EventType, Capacity=@Capacity, Status=@Status " +
                "WHERE ReservationID=@ReservationID", conn))
            {
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                cmd.Parameters.AddWithValue("@CustomerID", customerId);
                cmd.Parameters.AddWithValue("@HallNumber", hallNumber);
                cmd.Parameters.AddWithValue("@EventType", eventType);
                cmd.Parameters.AddWithValue("@Capacity", capacity);
                cmd.Parameters.AddWithValue("@Status", status);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        public int DeleteReservation(string reservationId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "DELETE FROM Reservations WHERE ReservationID=@ReservationID", conn))
            {
                cmd.Parameters.AddWithValue("@ReservationID", reservationId);
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        // Customer Requests Methods
        public DataTable GetCustomerRequests()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT * FROM CustomerRequests", conn))
            {
                conn.Open();
                dt.Load(cmd.ExecuteReader());
            }
            return dt;
        }

        // Profile Methods
        public DataTable GetCoordinatorProfile()
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "SELECT * FROM CoordinatorProfile WHERE ID=1", conn))
            {
                conn.Open();
                dt.Load(cmd.ExecuteReader());
            }
            return dt;
        }

        public int UpdateCoordinatorProfile(string fullName, string dob,
                                          string email, string phone, string address)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(
                "UPDATE CoordinatorProfile SET FullName=@FullName, DateOfBirth=@DOB, " +
                "BusinessEmail=@Email, PhoneNumber=@Phone, Address=@Address " +
                "WHERE ID=1", conn))
            {
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@DOB", dob);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Address", address);

                conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}