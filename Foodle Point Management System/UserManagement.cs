using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;
using Microsoft.IdentityModel.Protocols;

namespace Foodle_Point_Management_System
{
    public partial class UserManagement: Form
    {
        // Change the access modifier of EmployeeDataLoader to public
        public class EmployeeDataLoader
        {
            private EmployeeTable myEmployeeTable;
            public void LoadEmployeeData(DataGridView dgv)
            {
                // Implementation of the method
                // Example: Load data from myEmployeeTable to the DataGridView
                dgv.DataSource = myEmployeeTable.GetColumnValues("employeeID"); // Assuming you want to load employee IDs
            }
        }


        public UserManagement()
        {
            InitializeComponent();

        }
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodleDBConnection"].ConnectionString;
        private void UserManagement_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // Hide ManageUsers
            AdminHomePage adminPage = Application.OpenForms["AdminHomePage"] as AdminHomePage;

            if (adminPage != null)
            {
                adminPage.Show(); // Show existing AdminHomePage
            }
            else
            {
                adminPage = new AdminHomePage(); // In case it was closed
                adminPage.Show();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser AddUserForm = new AddUser();
            this.Hide(); // Hide AdminHomePage
            AddUserForm.ShowDialog(); // Open in modal mode (prevents external window behavior)
            this.Show(); // Show AdminHomePage again when ManageUsers closes
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
