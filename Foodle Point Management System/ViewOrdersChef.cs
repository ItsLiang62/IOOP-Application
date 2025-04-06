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
using System.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    public partial class ViewOrdersChef : Form
    {

        private string connectionString = @"Data Source=10.101.55.129,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public ViewOrdersChef()
        {
            InitializeComponent();
            LoadOrders();
        }

        private void LoadOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT OrderID, TableNumber, DishName, Status FROM Orders";
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
            var mainForm = new frmChefMain();
            mainForm.Show();
        }

        private void ViewOrdersChef_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
