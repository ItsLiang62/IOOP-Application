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
        public ViewCustomerRequestsForm(ResvCoordinator ResvCoordinatorUser)
        {
            this.ResvCoordinatorUser = ResvCoordinatorUser;
            InitializeComponent();
            InitializeReservationListView();
            LoadPendingRequests();
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
            lvReservations.Columns.Add("Current Response", 200);
            lvReservations.Columns.Add("Remarks", 200);

            lvReservations.View = View.Details;
            lvReservations.FullRowSelect = true;
        }
        private void LoadPendingRequests()
        {
            lvReservations.Items.Clear();

            var reservationIDs = reservationTable.GetColumnValues("ReservationID");

            foreach (string id in reservationIDs)
            {
                var rowValues = reservationTable.GetRowValues(id.ToString());

                ListViewItem item = new ListViewItem(rowValues[0].ToString()); 
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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page(ResvCoordinatorUser).Show();
        }

        private void btnSendReply_Click(object sender, EventArgs e)
        {
            if (lvReservations.SelectedItems.Count > 0)
            {
                string reservationID = lvReservations.SelectedItems[0].Text;
                string currentResponse = lvReservations.SelectedItems[0].SubItems[7].Text;

                Send_Reply replyForm = new Send_Reply(ResvCoordinatorUser, reservationID, currentResponse);
                replyForm.ShowDialog();
                LoadPendingRequests();
            }
            else
            {
                MessageBox.Show("Please select a request to reply to.");
            }
        }

        private void ViewCustomerRequestsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
