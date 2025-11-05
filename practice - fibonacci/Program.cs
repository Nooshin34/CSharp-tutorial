namespace practice___fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter your fibonacci sequence number:");
                int num = 0;
                string input = Console.ReadLine();

                if (int.TryParse(input, out num))
                {
                    int x = 1;
                    List<int> list = new List<int>();
                    while (x <= num)
                    {
                        if (x == 1)
                            list.Add(0);
                        else if (x == 2)
                        {
                            list.Add(1);
                        }
                        else
                        {
                            list.Add(list[x - 2] + list[x - 3]);

                        }
                        x++;
                    }
                    Console.WriteLine(string.Join(", ", list));
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
}
