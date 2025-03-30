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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Foodle_Point_Management_System
{
    public partial class frmManagerMain: Form
    {
        private Manager ManagerUser
        { get; set; }

        public frmManagerMain(Manager manager)
        {
            ManagerUser = manager;
            InitializeComponent();

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
    }
}
