using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Shared_Class_Library
{
    public class InputChecker
    {
        public bool IsTextOnly(string input, out string errorMessage)
        {
            if (input == "")
            {
                errorMessage = "Input must not be empty";
                return false;
            }

            foreach (char c in input)
            {
                if (!Char.IsLetter(c))
                {
                    errorMessage = "Input must contain only alphabets";
                    return false;
                }
            }

            errorMessage = "No error";
            return true;
        }

        public bool IsValidPhoneNumber(string input, out string errorMessage)
        {
            if (input == "")
            {
                errorMessage = "Phone number must be filled";
                return false;
            }

            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    errorMessage = "Phone number must contain only numbers";
                    return false;
                }
            }

            if (input.Length < 10 && input.Length > 12)
            {
                    errorMessage = $"Phone number must be between 10 to 12 numbers long";
                    return false;
            }

            errorMessage = "No error";
            return true;
        }

        public bool IsValidDate(string input, out string errorMessage)
        {
            DateTime tempDate;
            
            if (!DateTime.TryParseExact(input, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out tempDate))
            {
                errorMessage = "Invalid date. Make sure the date has no leading zeroes";
                return false;
            }

            errorMessage = "No error";
            return true;
        }

        public bool IsValidEmail(string input, out string errorMessage)
        {
            string pattern = @"^[a-zA-Z0-9]+@[a-zA-Z0-9]+\.[a-zA-Z]+$";

            if (!Regex.IsMatch(input, pattern))
            {
                errorMessage = "Invalid email";
                return false;
            }

            errorMessage = "No error";
            return true;
        }
    }
}
