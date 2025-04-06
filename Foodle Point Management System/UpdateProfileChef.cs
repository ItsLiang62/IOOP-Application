using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    
    public partial class UpdateProfileChef : Form
    {

        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=Chef_T1;Trusted_Connection=True;";
        private int employeeId; // Assume this is set when the form is opened

        public UpdateProfileChef(int employeeId)
        {
            InitializeComponent();
            this.employeeId = employeeId;
            
        }

        public UpdateProfileChef()
        {
            InitializeComponent();
            
        }

        private void LoadProfile()
        {
             try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT FullName, Position, Gender, DOB, PhoneNumber, Email, Password FROM Employees WHERE EmployeeID = @EmployeeID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        lblEmployeeIDChef.Text = reader["employeeid"].ToString();
                        txtFullNameChef.Text = reader["FullName"].ToString();
                        lblPositionChef.Text = reader["Position"].ToString();
                        cmbGenderChef.SelectedItem = reader["Gender"].ToString();
                        txtDOBChef.Text = reader["DOB"].ToString();
                        txtPhoneNumberChef.Text = reader["PhoneNumber"].ToString();
                        txtEmailChef.Text = reader["Email"].ToString();
                        txtPasswordChef.Text = reader["Password"].ToString();
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }





        private void UpdateProfileChef_Load(object sender, EventArgs e)
        {
            LoadProfile();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new frmChefMain();
            mainForm.Show();
        }

        private void btnUpdateProfileChef_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Employees SET FullName = @FullName, Gender = @Gender, DOB = @DOB, PhoneNumber = @PhoneNumber, Email = @Email, Password = @Password WHERE EmployeeID = @EmployeeID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", txtFullNameChef.Text);
                    command.Parameters.AddWithValue("@Gender", cmbGenderChef.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@DOB", txtDOBChef.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", txtPhoneNumberChef.Text);
                    command.Parameters.AddWithValue("@Email", txtEmailChef.Text);
                    command.Parameters.AddWithValue("@Password", txtPasswordChef.Text);
                    command.Parameters.AddWithValue("@EmployeeID", employeeId);
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
    }
}
