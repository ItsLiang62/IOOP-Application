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
    public partial class Resv_Main_Page : Form
    {
        private ResvCoordinator ResvCoordinatorUser
        { get; set; }

        public Resv_Main_Page(ResvCoordinator myResvCoordinatorUser)
        {
            ResvCoordinatorUser = myResvCoordinatorUser;
            InitializeComponent();
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            ManageReservationsForm manageForm = new ManageReservationsForm();
            manageForm.Show();
            this.Hide();
        }

        private void btnUpdateReservationStatus_Click(object sender, EventArgs e)
        {
            UpdateReservationStatusForm updateForm = new UpdateReservationStatusForm();
            updateForm.Show();
            this.Hide();
        }

        private void btnViewCustomerRequests_Click(object sender, EventArgs e)
        {
            ViewCustomerRequestsForm requestForm = new ViewCustomerRequestsForm();
            requestForm.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfileForm profileForm = new UpdateProfileForm();
            profileForm.Show();
            this.Hide();
        }

        private void Resv_Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void Resv_Main_Page_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.Show();
            this.Hide();
        }
    }
}