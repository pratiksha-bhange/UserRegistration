using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Programs using Regex");

            Console.WriteLine("Enter the first name = ");
            Console.WriteLine("\nNote: First name starts with Cap and has minimun 3 characters");
            string firstName = Console.ReadLine();

            UserGegistration userRegistration = new UserGegistration();
            Console.WriteLine(userRegistration.validateFirstName(firstName));
            Console.WriteLine("Enter the last name = ");
            string lastName = Console.ReadLine();
            Console.WriteLine(userRegistration.validateLastName(lastName));
        }
    }
}
