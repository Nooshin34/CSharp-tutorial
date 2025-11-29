namespace _005___method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert first number");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("please insert second number");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine(sum(firstNum, secondNum));
        }


        //we use this code to add documentation for our method
        /// <summary>
        /// sum of two numbers.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>It will return sum of two numbers.</returns>
        static int sum(int a, int b)
        {
            return (a + b);
        }
        //method with optional parameter
        static int sum(int a, int b, int c = 0)
        {
            return (a + b + c);
        }

    }
}
