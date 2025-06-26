// Abdullah

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class ViewOrdersChef : Form
    {

        private string connectionString = @"Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        Chef CurrentChef { get; set; }

        public ViewOrdersChef(Chef chef)
        {
            InitializeComponent();
            LoadOrders();
            CurrentChef = chef;
        }

        private void LoadOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT OrderID, ItemID, CustomerID, ChefEmployeeID, DateOfOrder, OrderStatus FROM ItemOrder";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewOrders.DataSource = dataTable;
            }
        }

        private void ViewOrdersChef_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new frmChefMain(CurrentChef);
            mainForm.Show();
        }

        private void ViewOrdersChef_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
