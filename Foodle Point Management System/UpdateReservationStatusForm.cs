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
        public UpdateReservationStatusForm(ResvCoordinator myResvCoordinatorUser)
        {
            InitializeComponent();
            LoadReservations();
            ConfigureDataGridView();
        }
        private void LoadReservations()
        {
            try
            {
                var reservations = reservationTable.GetColumnValues("ReservationID");
                dgvReservations.DataSource = reservations;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading reservations: {ex.Message}");
            }
        }
        private void ConfigureDataGridView()
        {
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            if (dgvReservations.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a reservation");
                return;
            }

            string newStatus = cmbReservationStatus.Text;
            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Please select a status");
                return;
            }

            string reservationId = dgvReservations.SelectedRows[0].Cells[0].Value.ToString();

            try
            {
                reservationTable.UpdateValue(reservationId, "ReservationStatus", newStatus);
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
