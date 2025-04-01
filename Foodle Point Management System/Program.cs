using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared_Class_Library;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                SystemAdministrator tempAdmin = new SystemAdministrator("A001"); // must exist in DB
                Application.Run(new AdminHomePage(tempAdmin));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin: " + ex.Message);
            }

        }
    }
}