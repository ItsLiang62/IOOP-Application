using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Class_Library
{
    public class Manager
    {
        private string EmployeeID
        { get; set; }

        private string FullName
        { get; set; }

        private string Position
        { get; set; }

        private string Gender
        { get; set; }

        private string DOB
        { get; set; }

        private string PhoneNum
        { get; set; }

        private string Email
        { get; set; }

        private string Password
        { get; set; }

        public Manager(string employeeID)
        {
            EmployeeTable myEmployeeTable = new EmployeeTable("Data Source=10.101.47.36,1433;User ID=anderson_login;Password=123;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

            EmployeeID = employeeID;
            FullName = myEmployeeTable.GetValue(employeeID, "EmployeeName").ToString();
            Position = myEmployeeTable.GetValue(employeeID, "Position").ToString();
            Gender = myEmployeeTable.GetValue(employeeID, "Gender").ToString();
            Email = myEmployeeTable.GetValue(employeeID, "Email").ToString();
            PhoneNum = myEmployeeTable.GetValue(employeeID, "PhoneNumber").ToString();
            DOB = myEmployeeTable.GetValue(employeeID, "DOB").ToString();
            Password = myEmployeeTable.GetValue(employeeID, "AccountPassword").ToString();
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetGender()
        {
            return Gender;
        }
    }
}
