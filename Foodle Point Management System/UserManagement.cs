// Mohammad

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
       private SystemAdministrator currentAdmin;



        public UserManagement(SystemAdministrator admin)
        {
            InitializeComponent();
            if (admin == null)
            {
                MessageBox.Show("Admin object is null in UserManagement!");
                return;  // Prevent form from loading if admin is null
            }

            currentAdmin = admin;  // Correct assignment of admin
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();


        }

        private void LoadEmployeeData()
        {
            try
            {
                // Create an instance of EmployeeTable to fetch data
                EmployeeTable empTable = new EmployeeTable();

                // Get all Employee IDs from the database
                List<object> empIDs = empTable.GetColumnValues("EmployeeID");

                // Create a DataTable to hold the employee data for display
                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Position");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Email");
                dt.Columns.Add("Phone");
                dt.Columns.Add("DOB");
                dt.Columns.Add("AccountPassword");


                // Loop through each EmployeeID and retrieve their details
                foreach (var empIdObj in empIDs)
                {
                    string id = empIdObj.ToString();
                    List<object> row = empTable.GetRowValues(id);

                    // Ensure row data is valid (expecting 7 columns for ID, Name, Position, etc.)
                    if (row.Count == 8)
                    {
                        dt.Rows.Add(row.ToArray()); // Add all 8 values

                        // Add the data to the DataTable

                        //dt.Rows.Add(row.Take(8).ToArray());  // Exclude password and other irrelevant fields
                    }
                    else
                    {
                        // Optional: Show a message if data is invalid
                        MessageBox.Show($"Invalid data for employee {id}. Skipping.");
                    }
                }

                dgvUsers.DataSource = dt;
                // Hide the "AccountPassword" column in the DataGridView
                dgvUsers.Columns["AccountPassword"].Visible = false;


                // Bind the DataTable to the DataGridView (dgvUsers)
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                // Display an error message if something goes wrong
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide ManageUsers
            AdminHomePage adminPage = new AdminHomePage(currentAdmin);

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



        private void btnAddUser_Click(object sender, EventArgs e)
        {
            // Create and show AddUser form in a modal way
            AddUser addUserForm = new AddUser(currentAdmin);
            addUserForm.Show(); // This pauses here until AddUser is closed

            // After closing the AddUser form, reload the data in UserManagement
            LoadEmployeeData(); // Refresh the DataGridView with new user data

        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                string selectedID = dgvUsers.SelectedRows[0].Cells["ID"].Value.ToString();
                EditUser editForm = new EditUser(currentAdmin, selectedID);
                editForm.Show();
                LoadEmployeeData(); // Refresh grid after editing
            }
            else
            {
                MessageBox.Show("Please select a user to edit.");
            }
        }


        private void UserManagement_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }





        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Get the EmployeeID of the selected row
                string selectedID = dgvUsers.SelectedRows[0].Cells["ID"].Value.ToString();

                // Ask for confirmation
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete Employee ID {selectedID}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        // Create a new EmployeeTable instance to access methods
                        EmployeeTable empTable = new EmployeeTable();
                        // Delete the row from the database using the Employee ID
                        empTable.DeleteRow(selectedID);  // Make sure this method is implemented correctly

                        // Display success message
                        MessageBox.Show("User deleted successfully!");

                        // Reload the data in DataGridView to refresh the UI
                        LoadEmployeeData();
                    }
                    catch (Exception ex)
                    {
                        // Display error message if deletion fails
                        MessageBox.Show($"Error deleting user: {ex.Message}");
                    }
                }
            }
            else
            {
                // If no row is selected, show an alert message
                MessageBox.Show("Please select a user to delete.");
            }
        }
    }
}
