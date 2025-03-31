using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodle_Point_Management_System
{
    class CartItem
    {

        public string ItemNumber { get; private set; }
        public string ItemName { get; private set; }
        public decimal Price { get; private set; } 

        public CartItem(string itemNumber, string itemName, decimal price)
        {
            ItemNumber = itemNumber;
            ItemName = itemName;
            Price = price;
        }

        // Method to add an item to the cart
        public static void AddToCart(DataGridView dgvCart, CartItem cartItem)
        {
            dgvCart.Rows.Add(cartItem.ItemNumber, cartItem.ItemName, cartItem.Price);
        }

        // Method to edit an item in the cart
        public static void EditCartItem(DataGridView dgvCart, int rowIndex, CartItem newItem)
        {
            dgvCart.Rows[rowIndex].Cells["ItemNumber"].Value = newItem.ItemNumber;
            dgvCart.Rows[rowIndex].Cells["ItemName"].Value = newItem.ItemName;
            dgvCart.Rows[rowIndex].Cells["Price"].Value = newItem.Price;
        }

        // Method to remove an item from the cart
        public static void RemoveFromCart(DataGridView dgvCart, int rowIndex)
        {
            dgvCart.Rows.RemoveAt(rowIndex);
        }
    }
}
