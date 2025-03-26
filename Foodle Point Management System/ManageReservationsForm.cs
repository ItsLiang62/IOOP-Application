using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class ManageReservationsForm: Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public ManageReservationsForm()
        {
            InitializeComponent();
            LoadReservations();
        }
        private void LoadReservations()
        {
            dgvReservations.DataSource = db.GetReservations();
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ConfigureDataGridView()
        {
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvReservations.Columns["ReservationID"].HeaderText = "Reservation ID";
            dgvReservations.Columns["CustomerID"].HeaderText = "Customer ID";
            dgvReservations.Columns["HallNumber"].HeaderText = "Hall Number";
            dgvReservations.Columns["EventType"].HeaderText = "Event Type";
            dgvReservations.Columns["Capacity"].HeaderText = "Capacity";
            dgvReservations.Columns["Status"].HeaderText = "Status";
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
                DataRowView row = (DataRowView)dgvReservations.SelectedRows[0].DataBoundItem;
                var editForm = new Edit_Reservation(row);
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
                string id = dgvReservations.SelectedRows[0].Cells["ReservationID"].Value.ToString();
                if (MessageBox.Show("Delete this reservation?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int result = db.DeleteReservation(id);
                    if (result > 0)
                    {
                        MessageBox.Show("Reservation deleted!");
                        LoadReservations();
                    }
                }
            }
        }
    }
}
