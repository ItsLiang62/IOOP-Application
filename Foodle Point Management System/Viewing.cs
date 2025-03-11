﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace new_customer
{
    public partial class Viewing : Form
    {
        public Viewing()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        
            
        {
            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";
            string customerId = "CUST001"; // Replace with actual logged-in customer ID

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT h.HallName, hr.EventType, hr.ReservationStatus
            FROM HallReservation hr
            JOIN Hall h ON hr.HallNumber = h.HallNumber
            WHERE hr.CustomerID = @customerId
            ORDER BY hr.ReservationStatus DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        lstReservations.Items.Clear(); // Clear previous data
                        while (reader.Read())
                        {
                            string hallName = reader["HallName"].ToString();
                            string eventType = reader["EventType"].ToString();
                            string status = reader["ReservationStatus"].ToString();

                            lstReservations.Items.Add($"Hall: {hallName} | Event: {eventType} | Status: {status}");
                        }
                    }
                }
            }
        }

        

        private void btnCheckOrderStatu_Click(object sender, EventArgs e)
        {
        
            

            string connectionString = "Server=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Database=customer;Integrated Security=True;";
            string customerId = "CUST001"; // Replace with actual logged-in customer ID

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
            SELECT i.ItemName, io.DateOfOrder, io.OrderStatus
            FROM ItemOrder io
            JOIN Item i ON io.ItemNumber = i.ItemNumber
            WHERE io.CustomerID = @customerId
            ORDER BY io.DateOfOrder DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@customerId", customerId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        lstOrders.Items.Clear(); // Clear previous data

                        while (reader.Read())
                        {
                            string itemName = reader["ItemName"].ToString();

                            // Check if DateOfOrder is NULL before converting
                            string dateOfOrder = reader["DateOfOrder"] != DBNull.Value
                                ? Convert.ToDateTime(reader["DateOfOrder"]).ToString("yyyy-MM-dd")
                                : "No Date";

                            string status = reader["OrderStatus"].ToString();

                            lstOrders.Items.Add($"Item: {itemName} | Date: {dateOfOrder} | Status: {status}");
                        }
                    }
                }
            }
        }

        private void Viewing_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

