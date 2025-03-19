using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Class_Library
{
    public class CustomerClass1
    {
        public string CustomerID { get; set; }
        private string CustomerName { get; set; }
        private string Gender { get; set; }
        private string Email { get; set; }
        private string PhoneNumber { get; set; }

        public CustomerClass1(string customerID)
        {
            CustomerTable myCustomerTable = new CustomerTable("Data Source=LAPTOP-5R9MHA5V\\MSSQLSERVER1;Initial Catalog=customer;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            {

                CustomerID = customerID;
                CustomerName = myCustomerTable.GetValue(customerID, "CustomerName").ToString();
                Gender = myCustomerTable.GetValue(customerID, "Gender").ToString();
                Email = myCustomerTable.GetValue(customerID, "Email").ToString();
                PhoneNumber = myCustomerTable.GetValue(customerID, "PhoneNumber").ToString();
            }

        }




        public string GetCustomerName()
        {
            return CustomerName;
        }

        public string GetEmail()
        {
            return Email;
        }

    }
}
