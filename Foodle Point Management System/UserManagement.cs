using System;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class UserManagement : Form
    {
        public UserManagement()
        {
            InitializeComponent();
        }

        private void UserManagement_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide UserManagement instead of closing

            // Check if AdminHomePage form is already open
            Form adminHome = Application.OpenForms["AdminHomePage"];
            if (adminHome == null)
            {
                adminHome = new frmManagerMain(); // Create new instance if not found
                adminHome.Show();
            }
            else
            {
                adminHome.Show(); // Show the existing instance
            }

        }
    }
}
