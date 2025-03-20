using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared_Class_Library
{
    public class Manager
    {
        private EmployeeTable myEmployeeTable = new EmployeeTable();
        
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

            EmployeeID = employeeID;
            FullName = myEmployeeTable.GetValue(employeeID, "EmployeeName").ToString();
            Position = myEmployeeTable.GetValue(employeeID, "Position").ToString();
            Gender = myEmployeeTable.GetValue(employeeID, "Gender").ToString();
            Email = myEmployeeTable.GetValue(employeeID, "Email").ToString();
            PhoneNum = myEmployeeTable.GetValue(employeeID, "PhoneNumber").ToString();
            DOB = myEmployeeTable.GetValue(employeeID, "DOB").ToString();
            Password = myEmployeeTable.GetValue(employeeID, "AccountPassword").ToString();
        }

        public string GetEmployeeID()
        {
            return EmployeeID;
        }

        public string GetFullName()
        {
            return FullName;
        }

        public string GetPosition()
        {
            return Position;
        }

        public string GetDOB()
        {
            return DOB;
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
        
        public string GetPassword()
        {
            return Password;
        }
    }
}
