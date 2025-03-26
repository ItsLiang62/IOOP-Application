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
    public partial class UpdateProfileForm : Form
    {
        private DatabaseHelper db = new DatabaseHelper();
        public UpdateProfileForm()
        {
            InitializeComponent();
            LoadProfile();
        }
        private void LoadProfile()
        {
            DataTable dt = db.GetCoordinatorProfile();
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtReservationCoordinatorID.Text = row["ID"].ToString();
                txtFullName.Text = row["FullName"].ToString();
                txtDateOfBirth.Text = row["DateOfBirth"].ToString();
                txtBusinessEmail.Text = row["BusinessEmail"].ToString();
                txtPhoneNumber.Text = row["PhoneNumber"].ToString();
                txtAddres.Text = row["Address"].ToString();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Resv_Main_Page().Show();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                    string.IsNullOrWhiteSpace(txtDateOfBirth.Text) ||
                    string.IsNullOrWhiteSpace(txtBusinessEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtAddres.Text))
                {
                    MessageBox.Show("Please fill in all fields");
                    return;
                }

                int result = db.UpdateCoordinatorProfile(
                    txtFullName.Text,
                    txtDateOfBirth.Text,
                    txtBusinessEmail.Text,
                    txtPhoneNumber.Text,
                    txtAddres.Text);

                if (result > 0)
                {
                    MessageBox.Show("Profile updated successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
