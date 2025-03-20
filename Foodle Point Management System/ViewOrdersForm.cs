using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class ViewOrdersForm : Form
    {
        private CustomerClass1 _currentCustomer;
        private ItemOrderTable _itemOrderTable;
        private HallReservationTable _hallReservationTable;

        public ViewOrdersForm(CustomerClass1 customer)
        {
            InitializeComponent();
            _currentCustomer = customer;
            _itemOrderTable = new ItemOrderTable();
            _hallReservationTable = new HallReservationTable();
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            dgvOrders.Columns.Clear(); // Clear any existing columns

            // Adding new columns
            dgvOrders.Columns.Add("OrderID", "Order ID");
            dgvOrders.Columns.Add("ItemNumber", "Item Number");
            dgvOrders.Columns.Add("ItemName", "Item Name"); // Add ItemName column
            dgvOrders.Columns.Add("DateOfOrder", "Date of Order");
            dgvOrders.Columns.Add("OrderStatus", "Order Status");

            LoadCustomerOrders();
            dgvReservations.Columns.Clear(); // Clear any existing columns

            // Adding new columns
            dgvReservations.Columns.Add("ReservationID", "Reservation ID");
            dgvReservations.Columns.Add("HallName", "Hall Name"); // Add HallName column
            dgvReservations.Columns.Add("EventType", "Event Type");
            dgvReservations.Columns.Add("EventDate", "Event Date");
            dgvReservations.Columns.Add("ReservationStatus", "Reservation Status");

            LoadCustomerReservations();
        }

        private void LoadCustomerOrders()
        {
            string customerID = _currentCustomer.CustomerID;

            // Modify the query to join Item and ItemOrder tables
            string query = @"SELECT o.OrderID, o.ItemNumber, i.ItemName, o.DateOfOrder, o.OrderStatus 
                     FROM ItemOrder o
                     JOIN Item i ON o.ItemNumber = i.ItemNumber
                     WHERE o.CustomerID = @CustomerID";

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming dgvOrders is your DataGridView to show orders
                            dgvOrders.Rows.Add(reader["OrderID"], reader["ItemNumber"], reader["ItemName"], reader["DateOfOrder"], reader["OrderStatus"]);
                        }
                    }
                }
            }
        }



        private void LoadCustomerReservations()
        {
            string customerID = _currentCustomer.CustomerID;

            // SQL query to get reservations along with the HallName
            string query = @"SELECT r.ReservationID, h.HallName, r.EventType, r.EventDate, r.ReservationStatus 
                     FROM HallReservation r
                     JOIN Hall h ON r.HallNumber = h.HallNumber
                     WHERE r.CustomerID = @CustomerID";

            using (SqlConnection conn = new SqlConnection("Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming dgvReservations is your DataGridView for reservations
                            dgvReservations.Rows.Add(reader["ReservationID"], reader["HallName"], reader["EventType"], reader["EventDate"], reader["ReservationStatus"]);
                        }
                    }
                }
            }
        }
    }
}
