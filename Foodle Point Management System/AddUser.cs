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
    public partial class AddUser: Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide AddUser form

            // Check if UserManagement is already open
            UserManagement userManagementForm = Application.OpenForms["UserManagement"] as UserManagement;

            if (userManagementForm != null)
            {
                userManagementForm.Show(); // Show existing UserManagement form
            }
            else
            {
                userManagementForm = new UserManagement(); // If closed, create a new instance
                userManagementForm.Show();
            }
        }
    }
}
