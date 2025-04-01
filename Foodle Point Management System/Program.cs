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

            // Temporary admin object (use real ID if you have it)
            SystemAdministrator tempAdmin = new SystemAdministrator("A001");
            Application.Run(new AdminHomePage(tempAdmin)); // Pass admin object to AdminHomePage
        }
    }
}
