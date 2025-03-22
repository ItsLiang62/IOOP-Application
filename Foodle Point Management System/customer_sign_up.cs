using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Shared_Class_Library;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Foodle_Point_Management_System
{
    public partial class frmCustomerSignUp: Form
    {
        private string InputFullName
        { get; set; }

        private string InputGender
        { get; set; }

        private string InputPhoneNum
        { get; set; }

        private string InputEmail
        { get; set; }

        private string CustomerID
        { get; set; }

        private string FullName
        { get; set; }

        private string Gender
        { get; set; }

        private string PhoneNum
        { get; set; }

        private string Email
        { get; set; }

        public frmCustomerSignUp()
        {
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.Show();
            this.Hide();
        }

        private void customer_sign_up_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            CustomerTable myCustomerTable = new CustomerTable();
       
            InputFullName = txtName.Text;
            InputGender = cmbGender.Text;
            InputEmail = txtEmail.Text;
            InputPhoneNum = txtPhoneNum.Text;
            CustomerID = myCustomerTable.GetNewCustomerID();

            if (AllInputValid(out string messageBoxErrorMessage))
            {
                FullName = InputFullName;
                Gender = InputGender;
                Email = InputEmail;
                PhoneNum = InputPhoneNum;

                try
                {
                    myCustomerTable.InsertRow(CustomerID, FullName, Gender, Email, PhoneNum);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2601 || ex.Number == 2627)
                    {
                        MessageBox.Show("Email has been registered. Please enter another email");
                        return;
                    }
                    else
                    {
                        MessageBox.Show($"Unexpected error: {ex.Message}");
                        return;
                    }
                    
                }
                MessageBox.Show("Successfully signed up as customer");
            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }
        }

        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            InputChecker myChecker = new InputChecker();

            bool validName = myChecker.IsTextOnly(InputFullName, out string eName, "Full Name");
            bool validEmail = myChecker.IsValidEmail(InputEmail, out string eEmail);
            bool validPhoneNum = myChecker.IsValidPhoneNumber(InputPhoneNum, out string ePhoneNum);
            bool validGender = !myChecker.IsEmptyInput(InputGender, out string eGender, "Gender");

            messageBoxErrorMessage = String.Empty;

            foreach (string error in new string[] { eName, eEmail, ePhoneNum, eGender })
            {
                if (!error.Equals("No error"))
                {
                    messageBoxErrorMessage = messageBoxErrorMessage + error + "\n";
                }
            }

            if (messageBoxErrorMessage != String.Empty)
            { 
                return false;
            }
            else
            {
                messageBoxErrorMessage = "No error";
                return true;
            }
        }
    }
}
