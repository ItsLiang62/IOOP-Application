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

namespace Foodle_Point_Management_System
{
    public partial class ManageInventoryChef : Form
    {
        private string connectionString = @"Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
        private string[] popularIngredients = { "Salt", "Sugar", "Flour", "Eggs", "Milk" };


        public ManageInventoryChef()
        {
            InitializeComponent();
            LoadInventory();
            DisplayPopularIngredients();
        }

        private void DisplayPopularIngredients()
        {
            listBoxPopularIngredients.Items.Clear();
            foreach (string ingredient in popularIngredients)
            {
                listBoxPopularIngredients.Items.Add(ingredient);
            }
        }

        private void LoadInventory()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IngredientID, IngredientName, Quantity FROM Inventory";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewInventory.DataSource = dataTable;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ingredientName = txtIngredientName.Text;
            int quantity = int.Parse(txtQuantity.Text);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Inventory (IngredientName, Quantity) VALUES (@IngredientName, @Quantity)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IngredientName", ingredientName);
                command.Parameters.AddWithValue("@Quantity", quantity);
                connection.Open();
                command.ExecuteNonQuery();
            }
            LoadInventory(); // Refresh the inventory list
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                int ingredientId = (int)dataGridViewInventory.SelectedRows[0].Cells["IngredientID"].Value;
                string ingredientName = txtIngredientName.Text;
                int quantity = int.Parse(txtQuantity.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Inventory SET IngredientName = @IngredientName, Quantity = @Quantity WHERE IngredientID = @IngredientID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IngredientName", ingredientName);
                    command.Parameters.AddWithValue("@Quantity", quantity);
                    command.Parameters.AddWithValue("@IngredientID", ingredientId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                LoadInventory(); // Refresh the inventory list
            }
            else
            {
                MessageBox.Show("Please select an ingredient to edit.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewInventory.SelectedRows.Count > 0)
            {
                int ingredientId = (int)dataGridViewInventory.SelectedRows[0].Cells["IngredientID"].Value;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Inventory WHERE IngredientID = @IngredientID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IngredientID", ingredientId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                LoadInventory(); // Refresh the inventory list
            }
            else
            {
                MessageBox.Show("Please select an ingredient to delete.");
            }


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT IngredientID, IngredientName, Quantity FROM Inventory WHERE IngredientName LIKE @SearchTerm";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewInventory.DataSource = dataTable;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mainForm = new frmChefMain();
            mainForm.Show();
        }

        private void ManageInventoryChef_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
