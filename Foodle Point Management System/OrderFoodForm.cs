using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    public partial class OrderFoodForm: Form
    {

        private void LoadMenuItems()
        {
            string connectionString = "Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;"; // Replace with your actual connection string
            List<MenuItem> menuItems = MenuItem.GetAllMenuItems(connectionString);

            dgvMenuItems.DataSource = menuItems; // Bind list to DataGridView
        }

        public OrderFoodForm()
        {
            InitializeComponent();
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
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Your cart is empty. Please add items before proceeding to payment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string customerID = "C001"; // Replace with actual logged-in customer ID
            List<CartItem> cartItems = new List<CartItem>();

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["ItemNumber"].Value == null) continue;
                cartItems.Add(new CartItem(
                    row.Cells["ItemNumber"].Value.ToString(),
                    row.Cells["ItemName"].Value.ToString(),
                    Convert.ToDecimal(row.Cells["Price"].Value)
                ));
            }

            Order order = new Order("Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True", customerID, cartItems);
            if (order.SaveOrder())
            {
                dgvCart.Rows.Clear();
                MessageBox.Show("Payment successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
