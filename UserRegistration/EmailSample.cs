using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class EmailSample
    {
        public void validateEmail()
        {
            //valid emails
            var emails = new ArrayList();
            emails.Add("abc@yahoo.com");
            emails.Add("abc-100@yahoo.com");
            emails.Add("abc.100@yahoo.com");
            emails.Add("abc111@abc.com");
            emails.Add("abc - 100@abc.net");
            emails.Add("abc.100@abc.com.au");
            emails.Add("abc@1.com");
            emails.Add("abc@gmail.com.com");
            emails.Add("abc+100@gmail.com");
            //Invalid emails
            emails.Add("abc");
            emails.Add("abc@.com.my");
            emails.Add("abc123@gmail.a");
            emails.Add("abc123@.com");
            emails.Add("abc123@.com.com");
            emails.Add(".abc@abc.com");
            emails.Add("abc()*@gmail.com");
            emails.Add("abc@%*.com");
            emails.Add("abc..2002@gmail.com");
            emails.Add("abc.@gmail.com");
            emails.Add("abc@abc@gmail.com");
            String regex = @"^[A-Za-z0-9]{3,}([\.\-\+][A-Za-z0-9]{3,})?[@][a-zA-Z0-9]{1,}[.][a-zA-Z]{2,}([.][a-zA-Z]{2,})?$";
            Regex emailPattern = new Regex(regex);
            foreach (string samples in emails)
            {
                Console.WriteLine(samples + " = " + emailPattern.IsMatch(samples));
            }
        }
    }
}
    

