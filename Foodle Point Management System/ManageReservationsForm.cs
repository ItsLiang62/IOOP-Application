using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
        private HallTable hallTable = new HallTable();

        public ManageReservationsForm(ResvCoordinator ResvCoordinatorUser)
        {
            InitializeComponent();
            this.ResvCoordinatorUser = ResvCoordinatorUser;
            InitializeReservationListView();
            LoadReservations();
        }

        private void InitializeReservationListView()
        {
            lvReservations.Columns.Clear();
            lvReservations.Items.Clear();

            lvReservations.Columns.Add("Reservation ID", 100);
            lvReservations.Columns.Add("Hall Number", 80);
            lvReservations.Columns.Add("Customer ID", 100);
            lvReservations.Columns.Add("Event Type", 120);
            lvReservations.Columns.Add("Event Date", 100);
            lvReservations.Columns.Add("Expected Count", 90);
            lvReservations.Columns.Add("Status", 80);
            lvReservations.Columns.Add("Response", 150);
            lvReservations.Columns.Add("Remarks", 200);

            lvReservations.View = View.Details;
            lvReservations.FullRowSelect = true;
            lvReservations.GridLines = true;
        }
        private void LoadReservations()
        {
            lvReservations.Items.Clear();

            var reservationIDs = reservationTable.GetColumnValues("ReservationID");

            foreach (string id in reservationIDs)
            {
                var rowValues = reservationTable.GetRowValues(id.ToString());

                ListViewItem item = new ListViewItem(rowValues[0].ToString()); 
                item.SubItems.Add(rowValues[1].ToString()); 
                item.SubItems.Add(rowValues[2].ToString()); 
                item.SubItems.Add(rowValues[3].ToString()); 
                item.SubItems.Add(rowValues[4].ToString()); 
                item.SubItems.Add(rowValues[5].ToString()); 
                item.SubItems.Add(rowValues[6].ToString()); 
                item.SubItems.Add(rowValues[7]?.ToString() ?? ""); 
                item.SubItems.Add(rowValues[8]?.ToString() ?? ""); 

                lvReservations.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add_Reservation addForm = new Add_Reservation(ResvCoordinatorUser);
            addForm.Show();
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
                editForm.Show();
                LoadReservations();
            }
            else
            {
                MessageBox.Show("Please select a reservation to edit.");
            }
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
                        string hallNumber = lvReservations.SelectedItems[0].SubItems[1].Text;
                        reservationTable.DeleteRow(reservationID);
                        hallTable.UpdateValue(hallNumber, "IsAvailable", true);
                        MessageBox.Show("Reservation deleted successfully!");
                        LoadReservations();
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

        private List<string> GetAvailableHalls(int expectedCount)
        {
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

        private void btnAssignHall_Click(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count > 0)
            {
                string reservationID = lvReservations.SelectedItems[0].Text;
                int expectedCount = int.Parse(lvReservations.SelectedItems[0].SubItems[5].Text);

                try
                {
                    var availableHalls = GetAvailableHalls(expectedCount);

                    if (availableHalls.Count > 0)
                    {
                        string selectedHall = availableHalls[0];

                        reservationTable.UpdateValue(reservationID, "HallNumber", selectedHall);
                        hallTable.UpdateValue(selectedHall, "IsAvailable", false);

                        MessageBox.Show($"Automatically assigned to {selectedHall}");
                        LoadReservations();
                    }
                    else
                    {
                        MessageBox.Show("No available halls");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                    return;
                }
            }
        }

        private void ManageReservationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
