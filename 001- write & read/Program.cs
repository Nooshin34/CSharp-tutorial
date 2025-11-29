namespace _001__write___read
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            //variable is a container that has type
            //type variableName = initialValue;
            string lName = "Nikzad";


            //use var for declare variable
            //type of this variable specify by it's value
            var firstName = "Nooshin";
            Console.WriteLine(firstName);
            var lastName = Console.ReadLine();




            //to write on console
            Console.WriteLine("What is your name?");
            //to insert data in console
            string name = Console.ReadLine() ?? "";//?? "" if Console.ReadLine() is null then the name should be ""
        }
    }
}
