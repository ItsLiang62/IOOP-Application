using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class Send_Reply : Form
    {
        private HallReservationTable reservationTable = new HallReservationTable();
        private string reservationID;
        private ResvCoordinator ResvCoordinatorUser;
        public Send_Reply(ResvCoordinator ResvCoordinatorUser, string reservationID, string currentResponse)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;
            this.reservationID = reservationID;
            txtReply.Text = currentResponse;
            // Initialize ListView columns
            InitializeReservationListView();

            // Load and display the selected reservation
            LoadReservationDetails();

            // Show current response if exists
            txtReply.Text = currentResponse;
        }
        private void InitializeReservationListView()
        {
            // Clear existing columns and items
            lvReservations.Columns.Clear();
            lvReservations.Items.Clear();

            // Add columns to ListView
            lvReservations.Columns.Add("Reservation ID", 100);
            lvReservations.Columns.Add("Hall Number", 80);
            lvReservations.Columns.Add("Customer ID", 100);
            lvReservations.Columns.Add("Event Type", 120);
            lvReservations.Columns.Add("Event Date", 100);
            lvReservations.Columns.Add("Expected Count", 90);
            lvReservations.Columns.Add("Status", 80);
            lvReservations.Columns.Add("Current Response", 200);
            lvReservations.Columns.Add("Remarks", 200);

            // Set view to show details
            lvReservations.View = View.Details;
            lvReservations.FullRowSelect = true;
        }
        private void LoadReservationDetails()
        {
            try
            {
                // Get reservation details from database
                var rowValues = reservationTable.GetRowValues(reservationID);

                // Clear any existing items
                lvReservations.Items.Clear();

                // Create new ListViewItem with reservation details
                ListViewItem item = new ListViewItem(rowValues[0].ToString()); // ReservationID
                item.SubItems.Add(rowValues[1].ToString()); // HallNumber
                item.SubItems.Add(rowValues[2].ToString()); // CustomerID
                item.SubItems.Add(rowValues[3].ToString()); // EventType
                item.SubItems.Add(rowValues[4].ToString()); // EventDate
                item.SubItems.Add(rowValues[5].ToString()); // ExpectedCount
                item.SubItems.Add(rowValues[6].ToString()); // Status
                item.SubItems.Add(rowValues[7]?.ToString() ?? ""); // RequestResponse
                item.SubItems.Add(rowValues[8]?.ToString() ?? ""); // Remarks

                // Add to ListView
                lvReservations.Items.Add(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservation details: {ex.Message}");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string response = txtReply.Text;

                if (string.IsNullOrWhiteSpace(response))
                {
                    MessageBox.Show("Please enter a reply message.");
                    return;
                }

                // Update the response in database
                reservationTable.UpdateValue(reservationID, "RequestResponse", response);

                // Update status to "Replied" if it was "Pending"
                string currentStatus = reservationTable.GetValue(reservationID, "ReservationStatus").ToString();
                if (currentStatus == "Pending")
                {
                    reservationTable.UpdateValue(reservationID, "ReservationStatus", "Replied");
                }

                MessageBox.Show("Reply sent successfully!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending reply: {ex.Message}");
            }
        }
    }
}
