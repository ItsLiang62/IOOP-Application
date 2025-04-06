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
using Microsoft.Data.SqlClient;
using static Shared_Class_Library.ItemOrderTable;
using static Shared_Class_Library.SalesCalculation;
using DocumentFormat.OpenXml.Drawing.Charts;


namespace Foodle_Point_Management_System
{
    public partial class ViewSales: Form
    {
        private SystemAdministrator currentAdmin;

        public ViewSales(SystemAdministrator admin)
        {
            InitializeComponent();
            currentAdmin = admin;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide ManageUsers
            AdminHomePage adminPage = Application.OpenForms["AdminHomePage"] as AdminHomePage;

            if (adminPage != null)
            {
                adminPage.Show(); // Show existing AdminHomePage
            }
            else
            {
                adminPage = new AdminHomePage(currentAdmin); // In case it was closed
                adminPage.Show();
            }
        }

        private void dataGridViewSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewSales_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
            
        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void ViewSales_Load(object sender, EventArgs e)
        {

        }

        private void btnGR_Click(object sender, EventArgs e)
        {
            int month = cmbMonth.SelectedIndex + 1;
            int year = int.Parse(comboBoxYear.SelectedItem.ToString());

            SalesCalculation salesCalculation = new SalesCalculation();
            List<Shared_Class_Library.SalesCalculation.SalesReportRecord> salesRecords = salesCalculation.GetSalesByMonthYear(month, year);


            if (salesRecords.Any())
                dgvSales.DataSource = salesRecords;
            else
                MessageBox.Show("No records found for the selected month and year.");
            // Total Sales Calculation
            double total = salesRecords.Sum(item => item.Price);
            lblTotalSales.Text = $"Total Sales: RM {total:F2}";
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cmbMonth.SelectedIndex = -1;
            comboBoxYear.SelectedIndex = -1;
            dgvSales.DataSource = null;
            lblTotalSales.Text = "Total Sales: RM 0.00";
        }
    }
}
