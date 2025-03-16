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
    public partial class frmManageMenu: Form
    {
        public frmManageMenu()
        {
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
