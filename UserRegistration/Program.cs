using System;
using UserRegistration;

namespace User_Registration_Using_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Programs using Regex");

            UserGegistration userRegistration = new UserGegistration();

            Console.WriteLine("\nNote: name starts with Cap and has minimun 3 characters");
            Console.WriteLine("\nEnter the first name = ");
            string firstName = Console.ReadLine();
            Console.WriteLine(userRegistration.validateFirstName(firstName));
            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine(userRegistration.validateLastName(lastName));
            Console.WriteLine("Enter the email = ");
            string email = Console.ReadLine();
            Console.WriteLine(userRegistration.validateEmail(email));
            
        }
    }
}
