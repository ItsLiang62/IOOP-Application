using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class frmManageWestern: Form
    {
        public frmManageWestern()
        {
            InitializeComponent();

            EmployeeTable myEmployeeTable = new EmployeeTable("Data Source = 10.101.47.36, 1433; Initial Catalog = ioop_db; User ID = anderson_login; Password = 123; Connect Timeout = 30; Encrypt = True; Trust Server Certificate = True; Application Intent = ReadWrite; Multi Subnet Failover = False");

            /*
            Panel pnlValue;
            Label lblValue;

            foreach (object employeeID in myEmployeeTable.GetColumnValues("EmployeeID"))
            {
                foreach (object value in myEmployeeTable.GetRowValues(employeeID.ToString()))
                {
                    pnlValue = new Panel
                    {
                        Size = new Size(150, 80),
                        BorderStyle = BorderStyle.FixedSingle,
                        BackColor = Color.LightGray
                    };

                    lblValue = new Label
                    {
                        Text = value.ToString(),
                        Location = new Point(10, 10),
                        Font = new Font("Arial>", 10, FontStyle.Bold)
                    };

                    pnlValue.Controls.Add(lblValue);
                    flpWesternItems.Controls.Add(pnlValue);
                }
            }
            */
            
        }

        private void frmManageWestern_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
