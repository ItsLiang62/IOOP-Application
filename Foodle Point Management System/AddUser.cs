using System;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            AdminHomePage adminHome = new frmManagerMain(); // Create instance of AdminHomePage
            adminHome.Show();  // Show the AdminHomePage form
            this.Close();  // Close the current UserManagement form
        }
    }
}
