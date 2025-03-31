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
    public partial class Resv_Main_Page : Form
    {
        public Resv_Main_Page()
        {
            InitializeComponent();
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            ManageReservationsForm manageForm = new ManageReservationsForm();
            manageForm.Show(); 
        }

        private void btnUpdateReservationStatus_Click(object sender, EventArgs e)
        {
            UpdateReservationStatusForm updateForm = new UpdateReservationStatusForm();
            updateForm.Show();
        }

        private void btnViewCustomerRequests_Click(object sender, EventArgs e)
        {
            ViewCustomerRequestsForm requestForm = new ViewCustomerRequestsForm();
            requestForm.Show();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfileForm profileForm = new UpdateProfileForm();
            profileForm.Show();
        }

        private void Resv_Main_Page_Load(object sender, EventArgs e)
        {

        }

        private void btnManageReservations_Click_1(object sender, EventArgs e)
        {

        }
    }
}