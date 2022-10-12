using System;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Programs using Regex");
            Console.WriteLine("Note: First name starts with Cap and has minimun 3 characters");

            Console.WriteLine("Enter the first name = ");
            string firstName = Console.ReadLine();

            UserGegistration userRegistration = new UserGegistration();
            Console.WriteLine(userRegistration.validateFirstName(firstName));
        }
    }
}
