using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLoginEmployee_Click(object sender, EventArgs e)
        {
            frmEmployeeLogin employeeLoginPage = new frmEmployeeLogin();
            employeeLoginPage.Show();
            this.Hide();
        }


        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            frmCustomerLogin customerLoginPage = new frmCustomerLogin();
            customerLoginPage.Show();
            this.Hide();
        }

        private void llblSignUpEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployeeSignUp employeeSignUpPage = new frmEmployeeSignUp();
            employeeSignUpPage.Show();
            this.Hide();
        }

        private void llblSignUpCustomer_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCustomerSignUp customerSignUpPage = new frmCustomerSignUp();
            customerSignUpPage.Show();
            this.Hide();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
