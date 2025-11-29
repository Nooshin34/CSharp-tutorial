using System.Xml.Linq;

namespace _002___condition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine() ?? "";
            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine() ?? "";
            
            //we use if/else for conditons
            //when we have || if the first condition is true then the condition after || doesnt check
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                Console.WriteLine("Invalid name or lastName");
            }
            else
            {
                Console.WriteLine($"your name is {firstName} {lastName}");
            }
        }
    }
}
