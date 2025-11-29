using System.Diagnostics;
using System.Linq.Expressions;

namespace _006___switchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Import a number for day of week:");
            string dayNum = Console.ReadLine();

            switch (dayNum)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;

                case "2":
                    Console.WriteLine("Tuesday");
                    break;

                case "3":
                    Console.WriteLine("Wednesday");
                    break;

                case "4":
                    Console.WriteLine("Thursday");
                    break;

                case "5":
                    Console.WriteLine("Friday");
                    break;

                case "6":
                    Console.WriteLine("Saturday");
                    break;

                case "7":
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid number. Please enter a value between 1 and 7.");
                    break;
            }
        }
    }
}
