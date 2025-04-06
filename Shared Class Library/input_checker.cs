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
        public bool IsTextOnly(string input, out string errorMessage, string inputTitle = "Input")
        {
            if (this.IsEmptyInput(input, out errorMessage, inputTitle))
            {
                return false;
            }

            if (!Regex.IsMatch(input, @"^[A-Za-z\s]+$"))
            {
                errorMessage = $"{inputTitle} must contain only alphabets";
                return false;
            }
            
            errorMessage = "No error";
                return true;
        }

        public bool IsDigitOnly(string input, out string errorMessage, string inputTitle = "Input")
        {
            if (this.IsEmptyInput(input, out errorMessage, inputTitle))
            {
                return false;
            }

            if (!Regex.IsMatch(input, @"^[0-9\s]+$"))
            {
                errorMessage = $"{inputTitle} must contain only digits";
                return false;
            }

            errorMessage = "No error";
            return true;
        }

        public bool IsValidPrice(string input, out string errorMessage)
        {
            if (this.IsEmptyInput(input, out errorMessage, "Price"))
            {
                return false;
            }

            if (!Regex.IsMatch(input, @"^[0-9\.]+$"))
            {
                errorMessage = "Invalid Price";
                return false;
            }

            errorMessage = "No error";
            return true;
        }

        public bool IsValidPhoneNumber(string input, out string errorMessage)
        {
            if (this.IsEmptyInput(input, out errorMessage, "Phone Number"))
            {
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

            if (input.Length < 10 || input.Length > 12)
            {
                    errorMessage = $"Phone number must be between 10 to 12 numbers long";
                    return false;
            }

            errorMessage = "No error";
            return true;
        }

        public bool IsValidDate(string input, out string errorMessage)
        {
            if (!DateTime.TryParseExact(input, "d/M/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime tempDate))
            {
                errorMessage = "Invalid date. Make sure the date follows format d/M/yyyy. (E.g. 9/9/2005)";
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

        public bool IsEmptyInput(string input, out string errorMessage, string inputTitle = "Input")
        {
            if (String.IsNullOrEmpty(input))
            {
                errorMessage = $"{inputTitle} cannot be empty";
                return true;
            }
            else
            {
                errorMessage = "No error";
                return false;
            }
        }
    }
}
