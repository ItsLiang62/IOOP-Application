using System;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class ViewCustomerFeedback : Form
    {
        public ViewCustomerFeedback()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form instead of closing

            // Check if AdminHomePage is already open
            Form adminHome = Application.OpenForms["AdminHomePage"];
            if (adminHome == null)
            {
                adminHome = new frmManagerMain();
                adminHome.Show();
            }
            else
            {
                adminHome.Show();
            }
        }
    }
}
