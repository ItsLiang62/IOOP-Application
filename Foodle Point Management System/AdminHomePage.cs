using System;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class AdminHomePage : Form
    {
        public AdminHomePage()
        {
        }

        private void AdminHomePage_Load(object sender, EventArgs e)
        {
        }

        private void BtnManageUser_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form instead of closing

            // Check if UserManagement form is already open
            Form userManagement = Application.OpenForms["UserManagement"];
            if (userManagement == null)
            {
                userManagement = new UserManagement(); // Create new instance if not found
                userManagement.Show();
            }
            else
            {
                userManagement.Show(); // Show the existing instance
            }
        }

        private void BtnViewSalesReport_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form instead of closing

            // Check if ViewSalesReport form is already open
            Form salesReport = Application.OpenForms["ViewSales"];
            if (salesReport == null)
            {
                salesReport = new ViewSales();
                salesReport.Show();
            }
            else
            {
                salesReport.Show(); // Show the existing instance
            }
        }

        private void BtnViewFeedback_Click(object sender, EventArgs e)
        {
            ViewCustomerFeedback feedbackForm = new ViewCustomerFeedback();
            feedbackForm.Show();
        }

        private void BtnUpdateProfile_Click(object sender, EventArgs e)
        {
            UpdateProfile updateProfileForm = new UpdateProfile();
            updateProfileForm.Show();
        }
    }
}
