namespace _3___casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            string inputAge = Console.ReadLine();
            int age1 = 0;
            //first method of casting (from string to int)
            int age = int.Parse(inputAge);
            bool ageConversion = int.TryParse(inputAge, out age1);
            int age2 = Convert.ToInt32(inputAge);
            //second method of casting (from int to string)
            inputAge = age.ToString();






            short shortNumber = 5;
            int intNumber = 15;
            //this line of code doesn't give me error because int type is greater than short type
            //third method of casting (from int to string)
            intNumber = shortNumber;
            //4
            shortNumber = (short)intNumber;


            //we use TryParse when we consider probable inputAgeTry is not int
            string inputAgeTry = Console.ReadLine();
            int ageTry = 0;
            int.TryParse(inputAgeTry, out ageTry);
        }
    }
}
