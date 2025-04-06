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
        public class SalesReportRecord
        {
            public string OrderID { get; set; }

            public string ItemName { get; set; }

            public string Category { get; set; }

            public double Price { get; set; }

            public string ChefEmployeeID { get; set; }

            public DateTime DateOfOrder { get; set; }
            public string OrderStatus { get; set; }
        }
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

        public List<SalesReportRecord> GetSalesByMonthYear(int month, int year)
        {
            var salesList = new List<SalesReportRecord>();

            string query = @"
            SELECT io.OrderID, i.ItemName, i.Category, i.Price, io.ChefEmployeeID, io.DateOfOrder, io.OrderStatus
            FROM ItemOrder io
            INNER JOIN Item i ON io.ItemNumber = i.ItemID
            WHERE MONTH(CONVERT(date, io.DateOfOrder, 103)) = @Month
            AND YEAR(CONVERT(date, io.DateOfOrder, 103)) = @Year";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Month", month);
                        cmd.Parameters.AddWithValue("@Year", year);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                salesList.Add(new SalesReportRecord
                                {
                                    OrderID = reader["OrderID"].ToString(),
                                    ItemName = reader["ItemName"].ToString(),
                                    Category = reader["Category"].ToString(),
                                    Price = Convert.ToDouble(reader["Price"]),
                                    ChefEmployeeID = reader["ChefEmployeeID"].ToString(),
                                    DateOfOrder = DateTime.Parse(reader["DateOfOrder"].ToString()),
                                    OrderStatus = reader["OrderStatus"].ToString()
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log exception or handle error
                Console.WriteLine("Error retrieving sales records: " + ex.Message);
            }

            return salesList;
        }
    }
}
