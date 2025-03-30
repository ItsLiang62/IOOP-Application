using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class ViewOrdersForm : Form
    {
        private string _customerID = "C001";
        public ViewOrdersForm()
        {
            InitializeComponent();
            dgvReservations.AutoGenerateColumns = true;
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            LoadOrders();
            LoadReservations();
        }


        private void LoadOrders()
        {
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT 
                OrderID, 
                ItemNumber, 
                DateOfOrder, 
                CASE 
                    WHEN OrderStatus = 'Confirmed' THEN 'In Progress'
                    WHEN OrderStatus = 'Completed' THEN 'Completed'
                    ELSE OrderStatus
                END AS OrderStatus
            FROM ItemOrder 
            WHERE CustomerID = @CustomerID";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", _customerID);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvOrders.DataSource = dt; // ✅ Show only this customer's orders
            }
        }



        private void LoadReservations()

        {
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
              SELECT 
                 ReservationID, 
                 HallNumber, 
                EventType, 
                ReservationStatus, 
                 ISNULL(Remarks, 'No response yet') AS Remarks
                FROM HallReservation 
                WHERE CustomerID = @CustomerID";



                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", _customerID);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvReservations.DataSource = dt; // ✅ Show customer reservations with status & response
            }

        }

    }

}
