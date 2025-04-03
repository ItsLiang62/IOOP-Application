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

        //Get Sales 
        public List<SalesReportRecord> GetSalesByMonthYear(int month, int year)
        {
            var salesList = new List<SalesReportRecord>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = @"
            SELECT io.OrderID, i.ItemName, i.Category, i.Price, io.ChefEmployeeID, io.DateOfOrder, io.OrderStatus
            FROM ItemOrder io
            INNER JOIN Item i ON io.ItemNumber = i.ItemID
            WHERE MONTH(CONVERT(date, io.DateOfOrder, 103)) = @Month
              AND YEAR(CONVERT(date, io.DateOfOrder, 103)) = @Year";

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

            return salesList;
        }

    }
}
