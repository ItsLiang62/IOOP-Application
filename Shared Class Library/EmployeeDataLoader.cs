using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shared_Class_Library
{
    class EmployeeDataLoader
    {
        private EmployeeTable myEmployeeTable;

        public EmployeeDataLoader()
        {
            myEmployeeTable = new EmployeeTable();  // Initialize EmployeeTable
        }

        // Method to load employee data into a DataGridView
        public void LoadEmployeeData(DataGridView dgv)
        {
            try
            {
                // Clear any existing data in the DataGridView
                dgv.Rows.Clear();

                // Get a list of all EmployeeIDs (or any other necessary column)
                var employeeIDs = myEmployeeTable.GetColumnValues("EmployeeID");

                // Loop through each EmployeeID and get their row values
                foreach (var employeeID in employeeIDs)
                {
                    var employeeData = myEmployeeTable.GetRowValues(employeeID.ToString());

                    // Create a new row for each employee and add it to the DataGridView
                    dgv.Rows.Add(employeeData.ToArray());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
