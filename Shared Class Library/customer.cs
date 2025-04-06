// Wang Liang Xuan

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Class_Library
{
    public class Customer
    {
        private CustomerTable myCustomerTable = new CustomerTable();

        private string CustomerID
        { get; set; }

        private string FullName
        { get; set; }

        private string Gender
        { get; set; }

        private string PhoneNum
        { get; set; }

        private string Email
        { get; set; }

        public Customer(string customerID)
        {
            CustomerID = customerID;
            FullName = myCustomerTable.GetValue(customerID, "CustomerName").ToString();
            Gender = myCustomerTable.GetValue(customerID, "Gender").ToString();
            Email = myCustomerTable.GetValue(customerID, "Email").ToString();
            PhoneNum = myCustomerTable.GetValue(customerID, "PhoneNumber").ToString();
        }

        public void Refresh()
        {
            FullName = myCustomerTable.GetValue(CustomerID, "CustomerName").ToString();
            Gender = myCustomerTable.GetValue(CustomerID, "Gender").ToString();
            Email = myCustomerTable.GetValue(CustomerID, "Email").ToString();
            PhoneNum = myCustomerTable.GetValue(CustomerID, "PhoneNumber").ToString();
        }

        public string GetCustomerID()
        {
            return CustomerID;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetGender()
        {
            return Gender;
        }

        public string GetPhoneNum()
        {
            return PhoneNum;
        }

        public string GetEmail()
        {
            return Email;
        }
    }
}
