// Badr

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;
using Microsoft.Data.SqlClient;

namespace Foodle_Point_Management_System
{
    public partial class OrderFoodForm: Form

    {
        private Customer _currentCustomer;
        private decimal totalPrice = 0m;
        private List<MenuItemCartItem> allMenuItems = new List<MenuItemCartItem>(); // List for MenuItemCartItem 
        private void LoadMenuItems()
        {
            string connectionString = "Data Source=172.18.48.1,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";
            allMenuItems = MenuItemCartItem.GetAllMenuItems(connectionString); // Load items into the list
            dgvMenuItems.DataSource = new BindingList<MenuItemCartItem>(allMenuItems); // Bind to DataGridView
            LoadCategories(); // Load categories into ComboBoxdView
        }

        public OrderFoodForm(Customer customerID)
        {
            InitializeComponent();
            _currentCustomer = customerID;
            dgvCart.AutoGenerateColumns = false;
            lblTotalPrice.Text = "Total: $0.00";
        }


        private void OrderFoodForm_Load(object sender, EventArgs e)
        {
            
            LoadMenuItems();
            if (dgvCart.Columns.Count == 0)
            {
                dgvCart.Columns.Add("ItemNumber", "Item Number");
                dgvCart.Columns.Add("ItemName", "Item Name");
                dgvCart.Columns.Add("Price", "Price");
                
                
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvMenuItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a menu item to add to the cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string itemNumber = dgvMenuItems.SelectedRows[0].Cells["ItemNumber"].Value.ToString();
            string itemName = dgvMenuItems.SelectedRows[0].Cells["ItemName"].Value.ToString();
            decimal price = Convert.ToDecimal(dgvMenuItems.SelectedRows[0].Cells["Price"].Value);

            MenuItemCartItem cartItem = new MenuItemCartItem(itemNumber, itemName, price);
            MenuItemCartItem.AddToCart(dgvCart, cartItem);
            totalPrice += price;
            lblTotalPrice.Text = $"Total: {totalPrice:C}";
        }

        private void btnEditCart_Click(object sender, EventArgs e)
        {
           if(dgvCart.SelectedRows.Count == 0 || dgvMenuItems.SelectedRows.Count == 0)
    {
                MessageBox.Show("Please select an item from both the cart and menu.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedCartIndex = dgvCart.SelectedRows[0].Index;
            string newItemNumber = dgvMenuItems.SelectedRows[0].Cells["ItemNumber"].Value.ToString();
            string newItemName = dgvMenuItems.SelectedRows[0].Cells["ItemName"].Value.ToString();
            decimal newPrice = Convert.ToDecimal(dgvMenuItems.SelectedRows[0].Cells["Price"].Value);

            MenuItemCartItem newCartItem = new MenuItemCartItem(newItemNumber, newItemName, newPrice);
            MenuItemCartItem.EditCartItem(dgvCart, selectedCartIndex, newCartItem);
            // Update the total price after editing
            UpdateTotalPrice();
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {

            // Ensure the cart is not empty
            if (dgvCart.Rows.Count == 0 || dgvCart.Rows[0].IsNewRow)
            {
                MessageBox.Show("You can not  pay without ordering.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method if the cart is empty
            }

            // Get the CustomerID of the logged-in customer
            string customerID = _currentCustomer.GetCustomerID();  // Get the CustomerID from the logged-in customer

            // Create a list to hold the CartItems
            List<MenuItemCartItem> cartItems = new List<MenuItemCartItem>();

            // Loop through each row in the cart to create CartItem objects
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow) continue;  // Skip the empty row (new row placeholder)

                string itemNumber = row.Cells["ItemNumber"].Value?.ToString() ?? string.Empty;
                string itemName = row.Cells["ItemName"].Value?.ToString() ?? string.Empty;
                decimal price = row.Cells["Price"].Value != null ? Convert.ToDecimal(row.Cells["Price"].Value) : 0m;

                // Add the CartItem to the list
                cartItems.Add(new MenuItemCartItem(itemNumber, itemName, price));
            }
            // Get the current date and time
            DateTime currentDate = DateTime.Now;
            // Create the Order object
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            Order order = new Order(connectionString, customerID, cartItems, currentDate);

            // Save the order to the database
            bool orderSaved = order.SaveOrder();

            if (orderSaved)
            {
                MessageBox.Show("Payment successful. Your order has been placed!");
                dgvCart.Rows.Clear();
                lblTotalPrice.Text = "Total: $0.00";// Clear the cart after successful payment
            }
            else
            {
                MessageBox.Show("An error occurred while processing your payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            // Check if any row is selected
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item from the cart to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if the selected row is an empty row (placeholder)
            if (dgvCart.SelectedRows[0].IsNewRow)
            {
                MessageBox.Show("You cannot remove an empty row.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If a valid row is selected, proceed with removing the item
            string itemName = dgvCart.SelectedRows[0].Cells["ItemName"].Value.ToString();
            decimal itemPrice = Convert.ToDecimal(dgvCart.SelectedRows[0].Cells["Price"].Value);

            // Confirm removal action from the user
            DialogResult result = MessageBox.Show($"Are you sure you want to remove this {itemName} from the cart?",
                                                  "Confirm Removal",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            // If user clicks 'Yes', remove the item
            if (result == DialogResult.Yes)
            {
                
                MenuItemCartItem.RemoveFromCart(dgvCart, dgvCart.SelectedRows[0].Index);

                // Recalculate the total price
                totalPrice -= itemPrice;
                lblTotalPrice.Text = $"Total: {totalPrice:C}";  // Update the total price label

                // Show success message
                MessageBox.Show("Item removed from the cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // If 'No' is selected, do nothing
                MessageBox.Show("Item removal canceled.", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateTotalPrice()
        {
            totalPrice = 0m;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (!row.IsNewRow)  // Skip the new row
                {
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                    totalPrice += price;
                }
            }

            // Update the label to show the new total price
            lblTotalPrice.Text = $"Total: {totalPrice:C}";
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void ApplyFilters()
        {
            string searchText = txtSearch.Text.ToLower();
            string selectedCategory = cmbCategory.SelectedItem?.ToString();

            var filteredItems = allMenuItems
                .Where(item => (string.IsNullOrEmpty(searchText) || item.ItemName.ToLower().Contains(searchText)) &&
                               (string.IsNullOrEmpty(selectedCategory) || selectedCategory == "All" || item.Category == selectedCategory))
                .ToList();

            dgvMenuItems.DataSource = new BindingList<MenuItemCartItem>(filteredItems);
        }

        private void LoadCategories()
        {
            List<string> categories = allMenuItems.Select(item => item.Category).Distinct().ToList();
            categories.Insert(0, "All"); // Add "All" option to show all items

            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0; // Default selection: "All"
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            CustomerDashboard mainpage = new CustomerDashboard(_currentCustomer);
            mainpage.Show();
            this.Hide();
        }

        private void OrderFoodForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
