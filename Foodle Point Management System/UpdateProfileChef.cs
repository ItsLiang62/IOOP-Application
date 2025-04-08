// Abdullah

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Shared_Class_Library;
using Microsoft.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    
    public partial class UpdateProfileChef : Form
    {

        private string connectionString = @"Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private string employeeId; // Assume this is set when the form is opened
        private Chef CurrentChef { get; set; }

        public UpdateProfileChef(Chef chef)
        {
            InitializeComponent();
            CurrentChef = chef;
            
        }

        public UpdateProfileChef()
        {
            InitializeComponent();
            
        }

        private void LoadProfile()
        {
            txtFullNameChef.Text = CurrentChef.GetFullName();
            lblShowPositionChef.Text = CurrentChef.GetPosition();
            cmbGenderChef.SelectedItem = CurrentChef.GetGender();
            txtDOBChef.Text = CurrentChef.GetDOB();
            txtPhoneNumberChef.Text = CurrentChef.GetPhoneNum();
            txtEmailChef.Text = CurrentChef.GetEmail();
            txtPasswordChef.Text = CurrentChef.GetPassword();
        }





        private void UpdateProfileChef_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new frmChefMain(CurrentChef);
            mainForm.Show();
        }

        private void btnUpdateProfileChef_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Employee SET EmployeeName = @EmployeeName, Gender = @Gender, DOB = @DOB, PhoneNumber = @PhoneNumber, Email = @Email, AccountPassword = @AccountPassword WHERE EmployeeID = @EmployeeID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeName", txtFullNameChef.Text);
                    command.Parameters.AddWithValue("@Gender", cmbGenderChef.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DOB", txtDOBChef.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumberChef.Text);
                    command.Parameters.AddWithValue("@Email", txtEmailChef.Text);
                    command.Parameters.AddWithValue("@AccountPassword", txtPasswordChef.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Profile updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void UpdateProfileChef_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
