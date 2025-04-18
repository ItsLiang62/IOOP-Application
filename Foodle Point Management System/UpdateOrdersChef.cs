﻿// Abdullah

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
using Shared_Class_Library;
using Microsoft.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    public partial class UpdateOrders : Form
    {
        private string connectionString = @"Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        Chef CurrentChef { get; set; }

        public UpdateOrders(Chef currentChef)
        {
            InitializeComponent();
            LoadOrders();
            CurrentChef = currentChef;
        }

        private void LoadOrders()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT OrderID, ItemID, CustomerID, DateOfOrder, OrderStatus FROM ItemOrder WHERE OrderStatus IN ('Pending', 'In Progress')";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewOrders.DataSource = dataTable;
            }
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            // Your code to handle the button click event
            UpdateOrderStatus("In Progress");
        }

        private void UpdateOrders_Load(object sender, EventArgs e)
        {

        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Completed");
        }

        private void UpdateOrderStatus(string status)
        {
            if (dataGridViewOrders.SelectedRows.Count > 0)
            {
                int orderId = (int)dataGridViewOrders.SelectedRows[0].Cells["OrderID"].Value;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE ItemOrder SET OrderStatus = @OrderStatus WHERE OrderID = @OrderID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@OrderStatus", status);
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                LoadOrders(); // Refresh the orders list
            }
            else
            {
                MessageBox.Show("Please select an order to update.");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new frmChefMain(CurrentChef);
            mainForm.Show();
        }

        private void UpdateOrders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
