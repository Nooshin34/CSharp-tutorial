namespace _010___practice___primeNumbers
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
                    int x = 2;
                    int count = 0;
                    while (x < num)
                    {
                        if (num % x == 0)
                            count++;

                        x++;
                    }


                    if (num <= 1)
                        Console.WriteLine("Your number is not prime number!!!");
                    else if (count == 0)
                    {
                        Console.WriteLine("Your number is prime number...");
                    }
                    else
                    {
                        Console.WriteLine("Your number is not prime number!!!");
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
