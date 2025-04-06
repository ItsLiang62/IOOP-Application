// Wang Liang Xuan

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
                lblWelcome.Text = $"Welcome, Mr. {ManagerUser.GetFullName()}! What would you like to do today?";
            }
            else if (ManagerUser.GetGender() == "Female")
            {
                lblWelcome.Text = $"Welcome, Mrs. {ManagerUser.GetFullName()}! What would you like to do today?";
            }
        }

        private void frmManagerMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblWelcomeManager_Resize(object sender, EventArgs e)
        {
            lblWelcome.Left = (this.ClientSize.Width - lblWelcome.Width) / 2;
        }

        private void btnManageMenu_Click(object sender, EventArgs e)
        {
            frmManageMenu manageMenuPage = new frmManageMenu(ManagerUser);
            manageMenuPage.Show();
            this.Hide();
        }

        private void btnManageHall_Click(object sender, EventArgs e)
        {
            frmManageHallDetails manageHallDetailsPage = new frmManageHallDetails(ManagerUser);
            manageHallDetailsPage.Show();
            this.Hide();
        }

        private void btnViewReservation_Click(object sender, EventArgs e)
        {
            frmViewHallReservations viewHallReservationsPage = new frmViewHallReservations(ManagerUser);
            viewHallReservationsPage.Show();
            this.Hide();
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            frmUpdateManagerProfile updateManagerProfilePage = new frmUpdateManagerProfile(ManagerUser);
            updateManagerProfilePage.Show();
            this.Hide();
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.Show();
            this.Hide();
        }
    }
}
