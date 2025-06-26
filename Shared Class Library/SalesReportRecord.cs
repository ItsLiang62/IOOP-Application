// Mohammad

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Shared_Class_Library;


namespace Shared_Class_Library
{
    public class SalesReportRecord
     // SalesReportRecord class for storing sales report data
    {
        public string OrderID { get; set; }
        public string ItemName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string ChefEmployeeID { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string OrderStatus { get; set; }

        
    }
}
