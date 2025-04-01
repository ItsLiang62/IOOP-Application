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
            currentAdmin = admin;


        }
        private string connectionString = ConfigurationManager.ConnectionStrings["FoodleDBConnection"].ConnectionString;
        private void UserManagement_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();

        }

        private void LoadEmployeeData()
        {
            try
            {
                EmployeeTable empTable = new EmployeeTable();
                List<object> empIDs = empTable.GetColumnValues("EmployeeID");

                DataTable dt = new DataTable();
                dt.Columns.Add("ID");
                dt.Columns.Add("Name");
                dt.Columns.Add("Position");
                dt.Columns.Add("Gender");
                dt.Columns.Add("Email");
                dt.Columns.Add("Phone");
                dt.Columns.Add("DOB");

                foreach (var empIdObj in empIDs)
                {
                    string id = empIdObj.ToString();
                    List<object> row = empTable.GetRowValues(id);
                    dt.Rows.Add(row.Take(7).ToArray()); // Exclude password
                }

                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
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
                adminPage = new AdminHomePage(currentAdmin); // In case it was closed
                adminPage.Show();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser AddUserForm = new AddUser(currentAdmin);
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
