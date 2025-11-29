namespace _008___practice___calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("please enter your first number");
                int num1 = 0;
                int.TryParse(Console.ReadLine(), out num1);

                Console.WriteLine("please enter your operator");
                string operate = Console.ReadLine();

                Console.WriteLine("please enter your second number");
                int num2 = 0;
                int.TryParse(Console.ReadLine(), out num2);

                int result = 0;

                if (operate == "+")
                {
                    result = num1 + num2;
                    Console.WriteLine(result);
                }
                else if (operate == "-")
                {
                    result = num1 - num2;
                    Console.WriteLine(result);
                }
                else if (operate == "*")
                {
                    result = num1 * num2;
                    Console.WriteLine(result);
                }
                else if (operate == "/")
                {
                    result = num1 / num2;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("This is not a valid operator!!!");
                }
            }

        }
    }
}
