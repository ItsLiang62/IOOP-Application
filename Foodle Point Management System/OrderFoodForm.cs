using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared_Class_Library;

namespace Foodle_Point_Management_System
{
    public partial class OrderFoodForm: Form

    {
        private CustomerClass1 _currentCustomer;

        private List<MenuItem> allMenuItems = new List<MenuItem>(); 
        private void LoadMenuItems()
        {
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            allMenuItems = MenuItem.GetAllMenuItems(connectionString); // Load items into the list

            dgvMenuItems.DataSource = new BindingList<MenuItem>(allMenuItems); // Bind to DataGridView
            LoadCategories(); // Load categories into ComboBoxdView
        }

        public OrderFoodForm(CustomerClass1 customerID)
        {
            InitializeComponent();
            _currentCustomer = customerID;
            dgvCart.AutoGenerateColumns = false;
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

            CartItem cartItem = new CartItem(itemNumber, itemName, price);
            CartItem.AddToCart(dgvCart, cartItem);
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

            CartItem newCartItem = new CartItem(newItemNumber, newItemName, newPrice);
            CartItem.EditCartItem(dgvCart, selectedCartIndex, newCartItem);
        }

        private void btnProceedToPayment_Click(object sender, EventArgs e)
        {

            // Ensure the cart is not empty
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items before proceeding to payment.");
                return;
            }

            // Get the CustomerID of the logged-in customer
            string customerID = _currentCustomer.CustomerID;  // Get the CustomerID from the logged-in customer

            // Create a list to hold the CartItems
            List<CartItem> cartItems = new List<CartItem>();

            // Loop through each row in the cart to create CartItem objects
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                string itemNumber = row.Cells["ItemNumber"].Value?.ToString() ?? string.Empty;
                string itemName = row.Cells["ItemName"].Value?.ToString() ?? string.Empty;
                decimal price = row.Cells["Price"].Value != null ? Convert.ToDecimal(row.Cells["Price"].Value) : 0m;

                // Add the CartItem to the list
                cartItems.Add(new CartItem(itemNumber, itemName, price));
            }

            // Create the Order object
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";
            Order order = new Order(connectionString, customerID, cartItems);

            // Save the order to the database
            bool orderSaved = order.SaveOrder();

            if (orderSaved)
            {
                MessageBox.Show("Payment successful. Your order has been placed!");
                dgvCart.Rows.Clear();  // Clear the cart after successful payment
            }
            else
            {
                MessageBox.Show("An error occurred while processing your payment.");
            }
        }

        private void btnRemoveCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item from the cart to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Step 2: Remove the selected row from the cart
            dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);

            // Step 3: Show success message
            MessageBox.Show("Item removed from the cart.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
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

            dgvMenuItems.DataSource = new BindingList<MenuItem>(filteredItems);
        }

        private void LoadCategories()
        {
            List<string> categories = allMenuItems.Select(item => item.Category).Distinct().ToList();
            categories.Insert(0, "All"); // Add "All" option to show all items

            cmbCategory.DataSource = categories;
            cmbCategory.SelectedIndex = 0; // Default selection: "All"
        }
    }
}
