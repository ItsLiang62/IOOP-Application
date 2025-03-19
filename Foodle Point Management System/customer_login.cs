using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmCustomerLogin: Form
    {
       
        private string CustomerID
        { get; set; }

        private string InputEmail
        { get; set; }

        public frmCustomerLogin()
        {
            InitializeComponent();
        }

        private void btnReturnMain_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.Show();
            this.Hide();
        }

        private void frmCustomerLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string messageBoxErrorMessage;

            CustomerTable myCustomerTable = new CustomerTable("Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

            InputEmail = txtEmail.Text;

            try
            {
                CustomerID = myCustomerTable.GetCustomerIDWithEmail(InputEmail);
            }
            catch (Exception ex)
            {
                messageBoxErrorMessage = ex.Message;
                MessageBox.Show(messageBoxErrorMessage);
                return;
            }
            
            CustomerDashboard customerMainPage = new CustomerDashboard(new CustomerClass1(CustomerID));
            customerMainPage.Show();
            this.Hide();

            MessageBox.Show("Login successful"); 
        }
    }
}
