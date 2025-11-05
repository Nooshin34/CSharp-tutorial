namespace _4___loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for loop
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(2 * i);
            }

            for (int i = 0; i > 10; i--)
            {
                Console.WriteLine(2 * i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    //The continue keyword skips the rest of the code in the current iteration and moves to the next iteration of the loop.
                    continue;
                }
                Console.WriteLine(2 * i);
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    //The break keyword immediately exits the loop, regardless of the condition.
                    break;
                }
                Console.WriteLine(2 * i);
            }

            //infinite loop
            for (; ; )
            {
                Console.WriteLine("This loop runs forever!");
            }
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //while loop

            int j = 0;
            while (j < 10)
            {
                Console.WriteLine(2 * j);
            }

        }
    }
}
