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

namespace Foodle_Point_Management_System
{
    public partial class frmChefMain : Form
    {
        public frmChefMain()
        {
            InitializeComponent();
            btnViewOrders.Click += btnViewOrders_Click;
            btnUpdateOrders.Click += btnUpdateOrders_Click;
            btnManageInventory.Click += btnManageInventory_Click;
            btnUpdateProfile.Click += btnUpdateProfile_Click;
        }

        private void frmChefMain_Load(object sender, EventArgs e)
        {

        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            OpenForm(new ViewOrdersChef());
        }

        private void OpenForm(Form form)
        {
            form.Show();
            this.Hide(); // Hide the main form when opening another form
        }

        private void btnUpdateOrders_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateOrders());
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            OpenForm(new ManageInventoryChef());
        }

        private void BtnUpdateProfileChef_Click(object sender, EventArgs e)
        {
            OpenForm(form: new UpdateProfileChef());
        }
    }
}
