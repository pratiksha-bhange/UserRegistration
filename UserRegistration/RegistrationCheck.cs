using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class RegistrationCheck
    {
        private string message;
        public RegistrationCheck()
        {
        }
        public RegistrationCheck(string message)
        {
            this.message = message;
        }
        public string checkForFirstName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForLastName()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForEmail()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForMobile()
        {
            if (message.Contains("Happy"))
                return "Entry is successful";
            else
                return "Entry is not successful";
        }
        public string checkForPassword()
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
    }
}