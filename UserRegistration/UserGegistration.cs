using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class UserGegistration
    {
        public static string NAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        public static string EMAIL_PATTERN = @"^[A-Za-z0-9]{3,}([\.\-\+][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2,})?$";
        public static string MOBILENOFORMAT_PATTERN = "^[0-9]{2}[ ][0-9]{10}$";
        public static string PASSWORD_PATTERN = "^[A-Z]{1}[a-z]{3,}[@][0-9]{1,}";
        public bool validateFirstName(String firstName)
        {
            return Regex.IsMatch(firstName, NAME_PATTERN);
        }
        public bool validateLastName(String lastName)
        {
            return Regex.IsMatch(lastName, NAME_PATTERN);
        }
        public bool validateEmail(String email)
        {
            return Regex.IsMatch(email, EMAIL_PATTERN);
        }
        public bool validateMobileNoFormat(String mobileNoFormat)
        {
            return Regex.IsMatch(mobileNoFormat, MOBILENOFORMAT_PATTERN);
        }
        public bool validatePassword(String password)
        {
            return Regex.IsMatch(password, PASSWORD_PATTERN);
        }
    }
}

