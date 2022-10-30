using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegistrationCheck
    {
        private string message;
        UserRegistration1 userRegistration = new UserRegistration1();
        public RegistrationCheck()
        {
        }
        public RegistrationCheck(string message)
        {
            this.message = message;
        }
        public string CheckForFirstName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string CheckForLastName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string CheckForEmail()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string CheckForPhoneNumber()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string CheckForPassword()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        public string CheckMultipleEntriesOfEmail(string email1, string email2, string email3, string email4, string email5)
        {
            UserRegistration1 userRegistration = new UserRegistration1();
            bool emailForEntry1 = userRegistration.ValidateEmail(email1);
            bool emailForEntry2 = userRegistration.ValidateEmail(email2);
            bool emailForEntry3 = userRegistration.ValidateEmail(email3);
            bool emailForEntry4 = userRegistration.ValidateEmail(email4);
            bool emailForEntry5 = userRegistration.ValidateEmail(email5);
            if (emailForEntry1 && emailForEntry2 && emailForEntry3 && emailForEntry4 && emailForEntry5)
                return "Entry is successful";
            else
                return "Entry is not successful";
        }

        public void CheckFirstName(string firstName)
        {
            if (userRegistration.ValidateFirstName(firstName))
            {
                Console.WriteLine("First Name is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name Format");
            }
        }
        public void CheckLastName(string lastName)
        {
            if (userRegistration.ValidateLastName(lastName))
            {
                Console.WriteLine("Last Name is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name Format");
            }
        }
        public void CheckEmail(string email)
        {
            if (userRegistration.ValidateEmail(email))
            {
                Console.WriteLine("email is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid Email Format");
            }
        }
        public void CheckMobile(string phoneNumber)
        {
            if (userRegistration.ValidateMobileNoFormat(phoneNumber))
            {
                Console.WriteLine("mobileNo format is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Mobile Number Format");
            }
        }
        public void CheckPassword(string Password)
        {
            if (userRegistration.ValidatePassword(Password))
            {
                Console.WriteLine("password format is valid");
            }
            else
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password Format");
            }
        }
    }
}