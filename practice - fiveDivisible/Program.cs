namespace practice___fiveDivisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your number:");
                int num = 0;
                string input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {

                    if (num % 5 == 0)
                    {
                        Console.WriteLine("Your number is divisible by 5...");
                    }
                    else
                    {
                        Console.WriteLine("Your number is not divisible by 5!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
}
