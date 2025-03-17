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
    public partial class frmManageMenu: Form
    {
        private Manager ManagerUser
        { get; set; }

        public frmManageMenu(Manager manager)
        {
            ManagerUser = manager;
            InitializeComponent();
        }

        private void btnWestern_Click(object sender, EventArgs e)
        {
            frmManageWestern manageWesternPage = new frmManageWestern();
            manageWesternPage.Show();
            this.Hide();
        }

        private void frmManageMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
