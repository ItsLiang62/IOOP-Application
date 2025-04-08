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
using System.Data.SqlClient;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmChefMain : Form
    {
        Chef CurrentChef { get; set; }

        public frmChefMain(Chef chef)
        {
            InitializeComponent();
            btnViewOrders.Click += btnViewOrders_Click;
            btnUpdateOrders.Click += btnUpdateOrders_Click;
            btnManageInventory.Click += btnManageInventory_Click;
            btnUpdateProfile.Click += btnUpdateProfile_Click_1;
            CurrentChef = chef;
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            OpenForm(new ViewOrdersChef(CurrentChef));
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide(); // Hide the main form when opening another form
        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateOrders(CurrentChef));
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            OpenForm(new ManageInventoryChef(CurrentChef));
        }

        private void btnUpdateProfile_Click_1(object sender, EventArgs e)
        {
            
            OpenForm(new UpdateProfileChef(CurrentChef));

        }

        private void frmChefMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain mainPage = new frmMain();
            mainPage.Show();
            this.Hide();
        }
    }
}
