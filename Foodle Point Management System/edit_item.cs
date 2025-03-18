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
    public partial class frmEditItem: Form
    {
        Manager ManagerUser
        { get; set; }

        string ItemIDToEdit
        { get; set; }

        public frmEditItem(Manager manager, string itemIDToEdit)
        {
            InitializeComponent();
            ManagerUser = manager;
            ItemIDToEdit = itemIDToEdit;
        }
    }
}
