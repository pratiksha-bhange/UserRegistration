using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class UserRegistration1
    {
        public static string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAIL_PATTERN = @"^[A-Za-z0-9]{3,}([\.\-\+][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2,})?$";
        public static string MOBILENOFORMAT_PATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORD_PATTERN = "^[A-Z]{1}[a-z]{3,}[@][0-9]{1,}";

        public bool ValidateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, NAME_PATTERN);
        }

        public bool ValidateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, NAME_PATTERN);
        }

        public bool ValidateEmail(String email)
        {
            return Regex.IsMatch(email, EMAIL_PATTERN);
        }

        public bool ValidateMobileNoFormat(String phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, MOBILENOFORMAT_PATTERN);
        }

        public bool ValidatePassword(String password)
        {
            return Regex.IsMatch(password, PASSWORD_PATTERN);
        }
    }
}