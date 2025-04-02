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
    public partial class dashboard_customer: Form
    {
        public dashboard_customer()
        {
            InitializeComponent();
        }

        private void dashboard_customer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
