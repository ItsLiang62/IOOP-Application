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
    public partial class ManageReservationsForm: Form
    {
        private ResvCoordinator ResvCoordinatorUser
        { get; set; }
        private HallReservationTable reservationTable = new HallReservationTable();
        public ManageReservationsForm(ResvCoordinator ResvCoordinatorUser)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;
            LoadReservations();
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
                item.SubItems.Add(rowValues[6].ToString()); // ReservationStatus
                item.SubItems.Add(rowValues[7]?.ToString() ?? ""); // RequestResponse
                item.SubItems.Add(rowValues[8]?.ToString() ?? ""); // Remarks

                lvReservations.Items.Add(item);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Reservation addForm = new Add_Reservation(ResvCoordinatorUser);
            addForm.ShowDialog();
            LoadReservations();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page(ResvCoordinatorUser).Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count > 0)
            {
                string reservationID = lvReservations.SelectedItems[0].Text;
                Edit_Reservation editForm = new Edit_Reservation(ResvCoordinatorUser, reservationID);
                editForm.ShowDialog();
                LoadReservations();
            }
            else
            {
                MessageBox.Show("Please select a reservation to edit.");
            }
        }

        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count > 0)
            {
                string reservationID = lvReservations.SelectedItems[0].Text;

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this reservation?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        reservationTable.DeleteRow(reservationID);
                        LoadReservations();
                        MessageBox.Show("Reservation deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting reservation: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a reservation to delete.");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
