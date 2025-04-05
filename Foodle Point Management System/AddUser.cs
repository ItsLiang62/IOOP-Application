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
    public partial class AddUser : Form
    {
        private SystemAdministrator currentAdmin;

        public AddUser(SystemAdministrator admin)
        {
            InitializeComponent();
            currentAdmin = admin;
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
                userManagementForm = new UserManagement(currentAdmin); // If closed, create a new instance
                userManagementForm.Show();
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            
        }

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtEmplyeeName.Text) ||
                string.IsNullOrWhiteSpace(cmbPosition1.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGender.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            try
            {
                string position = cmbPosition1.SelectedItem.ToString();
                EmployeeTable empTable = new EmployeeTable();
                string newEmployeeID = empTable.GetNewEmployeeID(position);

                string employeeName = txtEmplyeeName.Text;
                string gender = comboBoxGender.SelectedItem.ToString();  // Get gender from ComboBox
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string dob = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string password = txtPassword.Text;

                empTable.InsertRow(newEmployeeID, employeeName, position, gender, email, phone, dob, password);

                MessageBox.Show("New user added successfully!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding user: {ex.Message}");
            }
        }
    }
}
