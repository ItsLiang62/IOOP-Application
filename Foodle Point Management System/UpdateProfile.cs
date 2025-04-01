using Shared_Class_Library;
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
    public partial class UpdateProfile: Form
    {
        private SystemAdministrator currentAdmin;
        public UpdateProfile(SystemAdministrator admin)
        {
            InitializeComponent();
            currentAdmin = admin;
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide ManageUsers
            AdminHomePage adminPage = Application.OpenForms["AdminHomePage"] as AdminHomePage;

            if (adminPage != null)
            {
                adminPage.Show(); // Show existing AdminHomePage
            }
            else
            {
                adminPage = new AdminHomePage(currentAdmin); // In case it was closed
                adminPage.Show();
            }
        }

        private void btnUpdateProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
