using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Shared_Class_Library;



namespace Shared_Class_Library
{
    public class SalesCalculation : Table
    {
        public decimal CalculateTotalSales(string year, string month)
        {
            decimal totalSales = 0;

            ItemTable itemTable = new ItemTable();

            string query = @"
            SELECT io.OrderID, io.ItemNumber 
            FROM ItemOrder io
            WHERE YEAR(io.DateOfOrder) = @Year AND MONTH(io.DateOfOrder) = @Month AND io.OrderStatus = 'Completed'";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Year", year);
                        cmd.Parameters.AddWithValue("@Month", month);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string itemID = reader["ItemNumber"].ToString();

                                // Retrieve the price of the item using ItemTable
                                var priceValue = itemTable.GetValue(itemID, "Price");

                                if (priceValue != null)
                                {
                                    decimal price;
                                    // Ensure that the value can be converted to decimal
                                    if (decimal.TryParse(priceValue.ToString(), out price))
                                    {
                                        totalSales += price; // Accumulate the total sales value
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception or handle error
                Console.WriteLine("Error calculating total sales: " + ex.Message);
            }

            return totalSales;
        }
    }
}
