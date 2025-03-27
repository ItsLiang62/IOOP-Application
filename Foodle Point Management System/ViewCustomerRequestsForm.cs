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
    public partial class ViewCustomerRequestsForm : Form
    {
        private ResvCoordinator ResvCoordinatorUser
        { get; set; }
        private HallReservationTable reservationTable = new HallReservationTable();
        public ViewCustomerRequestsForm(ResvCoordinator myResvCoordinatorUser)
        {
            ResvCoordinatorUser = myResvCoordinatorUser;
            InitializeComponent();
            LoadRequests();
            ConfigureDataGridView();
        }
        private void LoadRequests()
        {
            try
            {
                var requests = reservationTable.GetColumnValues("ReservationID");
                dgvReservations.DataSource = requests;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading requests: {ex.Message}");
            }
        }
        private void ConfigureDataGridView()
        {
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page(ResvCoordinatorUser).Show();
        }

        private void btnSendReply_Click(object sender, EventArgs e)
        {
            if (dgvReservations.SelectedRows.Count > 0)
            {
                string requestId = dgvReservations.SelectedRows[0].Cells[0].Value.ToString();
                new Send_Reply(requestId).ShowDialog();
                LoadRequests();
            }
            else
            {
                MessageBox.Show("Please select a request");
            }
        }
    }
}
