namespace DotNetFundamentalNotTopLevel
{
    internal class Program
    {
        static void Main(string[] args)
        {
      

            

            Console.WriteLine("What is your father name?");
            string fatherName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(fatherName))
                {
                    Console.WriteLine("Invalid fatherName");
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("How old are you?");
            //1
            string inputAge = Console.ReadLine();
            int age1 = 0;
            int age = int.Parse(inputAge);
            bool ageConversion = int.TryParse(inputAge, out age1);
            int age2 = Convert.ToInt32(Console.ReadLine());
            //2
            string ageStr = age.ToString();



            
            //////////////////////////////////////////////////////////////////////////////////
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                { 
                    continue;
                }
                Console.WriteLine(2*i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine(i * i);
            }
            //loop binahayat
            for (;;)
            {
                Console.WriteLine("hi");
            }

            int j = 0;
            while (j<10)
            {
                Console.WriteLine(2 * j);
            }

            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k * k);
            }

            while (true)
            {
                Console.WriteLine("hi");
            }

        }
    }
}
