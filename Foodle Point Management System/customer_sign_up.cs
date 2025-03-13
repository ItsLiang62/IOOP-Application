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
            string messageBoxErrorMessage;

            CustomerTable myCustomerTable = new CustomerTable("Data Source=10.101.63.254,1433;Initial Catalog=ioop_db;User ID=anderson_login;Password=123;Encrypt=True;Trust Server Certificate=True");

            FullName = txtName.Text;
            Gender = cmbGender.Text;
            Email = txtEmail.Text;
            PhoneNum = txtPhoneNum.Text;
            CustomerID = myCustomerTable.GetNewCustomerID();

            if (AllInputValid(out messageBoxErrorMessage))
            {
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
                    }
                    
                }
            }
            else
            {
                MessageBox.Show(messageBoxErrorMessage);
            }
        }

        private bool AllInputValid(out string messageBoxErrorMessage)
        {
            InputChecker myChecker = new InputChecker();

            string eName;
            string eEmail;
            string ePhoneNum;
            string eGender;

            bool validName = myChecker.IsTextOnly(FullName, out eName);
            bool validEmail = myChecker.IsValidEmail(Email, out eEmail);
            bool validPhoneNum = myChecker.IsValidPhoneNumber(PhoneNum, out ePhoneNum);
            bool validGender = !myChecker.IsEmptyInput(Gender, out eGender);

            messageBoxErrorMessage = "";

            if (!(validName && validEmail && validPhoneNum && validGender))
            {

                foreach (string error in new string[] { eName, eEmail, ePhoneNum, eGender })
                {
                    if (!error.Equals("No error"))
                    {
                        messageBoxErrorMessage = messageBoxErrorMessage + error + "\n";
                    }
                }

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
