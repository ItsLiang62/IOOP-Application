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
        private HallReservationTable reservationTable = new HallReservationTable();
        public ManageReservationsForm()
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new Add_Reservation();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadReservations();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page().Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                string reservationId = dgvReservations.SelectedRows[0].Cells[0].Value.ToString();
                var editForm = new Edit_Reservation(reservationId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    LoadReservations();
                }
            }
        }

        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                string reservationId = dgvReservations.SelectedRows[0].Cells[0].Value.ToString();
                if (MessageBox.Show("Delete this reservation?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        reservationTable.DeleteRow(reservationId);
                        LoadReservations();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting reservation: {ex.Message}");
                    }
                }
            }
        }
    }
}
