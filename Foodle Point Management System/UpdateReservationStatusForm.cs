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
    public partial class UpdateReservationStatusForm : Form

    {
        private HallReservationTable reservationTable = new HallReservationTable();
        private ResvCoordinator ResvCoordinatorUser
        { get; set; }
        public UpdateReservationStatusForm(ResvCoordinator ResvCoordinatorUser)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;
            InitializeReservationListView();
            LoadReservations();
            cmbReservationStatus.Items.AddRange(new string[] { "Pending", "Confirmed", "Completed", "Rejected" });
        }
        private void InitializeReservationListView()
        {
            lvReservations.Columns.Clear();
            lvReservations.Items.Clear();

            // Add all columns including ExpectedCount and Remarks
            lvReservations.Columns.Add("Reservation ID", 100);
            lvReservations.Columns.Add("Hall Number", 80);
            lvReservations.Columns.Add("Customer ID", 100);
            lvReservations.Columns.Add("Event Type", 120);
            lvReservations.Columns.Add("Event Date", 100);
            lvReservations.Columns.Add("Expected Count", 90);
            lvReservations.Columns.Add("Status", 80);
            lvReservations.Columns.Add("RequestResponse", 200);
            lvReservations.Columns.Add("Remarks", 200);

            lvReservations.View = View.Details;
            lvReservations.FullRowSelect = true;
        }
        private void LoadReservations()
        {
            lvReservations.Items.Clear();

            // Get all reservation IDs
            var reservationIDs = reservationTable.GetColumnValues("ReservationID");

            foreach (string id in reservationIDs)
            {
                var rowValues = reservationTable.GetRowValues(id.ToString());

                ListViewItem item = new ListViewItem(rowValues[0].ToString()); // ReservationID
                item.SubItems.Add(rowValues[1].ToString()); // HallNumber
                item.SubItems.Add(rowValues[2].ToString()); // CustomerID
                item.SubItems.Add(rowValues[3].ToString()); // EventType
                item.SubItems.Add(rowValues[4].ToString()); // EventDate
                item.SubItems.Add(rowValues[5].ToString()); // ExpectedCount
                item.SubItems.Add(rowValues[6].ToString());
                item.SubItems.Add(rowValues[7]?.ToString() ?? "");// Status
                item.SubItems.Add(rowValues[8]?.ToString() ?? ""); // Remarks

                lvReservations.Items.Add(item);
            }
        }
        private void lvReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count > 0)
            {
                string currentStatus = lvReservations.SelectedItems[0].SubItems[5].Text;
                cmbReservationStatus.SelectedItem = currentStatus;
            }
        }
        private void chkPending_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkRejected_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page(ResvCoordinatorUser).Show();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a reservation to update.");
                return;
            }

            if (cmbReservationStatus.SelectedItem == null)
            {
                MessageBox.Show("Please select a status.");
                return;
            }

            string reservationID = lvReservations.SelectedItems[0].Text;
            string newStatus = cmbReservationStatus.SelectedItem.ToString();

            try
            {
                reservationTable.UpdateValue(reservationID, "ReservationStatus", newStatus);
                MessageBox.Show("Status updated successfully!");
                LoadReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating status: {ex.Message}");
            }
        }

    }
}
