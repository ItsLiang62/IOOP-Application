using Shared_Class_Library;
using System;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class AdminHomePage : Form
    {
        private Manager ManagerUser
        { get; set; }

        public AdminHomePage(Manager manager)
        {
            ManagerUser = manager;

            if (ManagerUser.GetGender() == "Male")
            {
                lblWelcomeManager.Text = $"Welcome, Mr. {ManagerUser.GetFullName()}!";
            }
            else if (ManagerUser.GetGender() == "Female")
            {
                lblWelcomeManager.Text = $"Welcome, Mrs. {ManagerUser.GetFullName()}!";
            }
        }

        private void frmManagerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcomeManager_Resize(object sender, EventArgs e)
        {
            lblWelcomeManager.Left = (this.ClientSize.Width - lblWelcomeManager.Width) / 2;
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            frmManageMenu manageMenuPage = new frmManageMenu(ManagerUser);
            manageMenuPage.Show();
            this.Hide();
        }

        private void btnManageHall_Click(object sender, EventArgs e)
        {
            frmManageHallDetails manageHallDetailsPage = new frmManageHallDetails();
            manageHallDetailsPage.Show();
            this.Hide();
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            frmViewHallReservations viewHallReservationsPage = new frmViewHallReservations();
            viewHallReservationsPage.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            frmUpdateManagerProfile updateManagerProfilePage = new frmUpdateManagerProfile();
            updateManagerProfilePage.Show();
            this.Hide();
        }

        private void frmManagerMain_Load(object sender, EventArgs e)
        {

        }
    }
}
