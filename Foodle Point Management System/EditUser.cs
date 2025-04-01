using Shared_Class_Library;
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
    public partial class EditUser: Form
    {
        private SystemAdministrator currentAdmin;

        public EditUser(SystemAdministrator admin)
        {
            InitializeComponent();
            currentAdmin = admin;  // Store the passed admin object
        }

        private void EditUser_Load(object sender, EventArgs e)
        {

        }

        private void txtUsernameE_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
