namespace _013___models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine("Please insert your firstName:");
            person.FirstName = Console.ReadLine();

            Console.WriteLine("Please insert your lastName:");
            person.LastName = Console.ReadLine();

            Console.WriteLine(person.GetFullName());

            Console.WriteLine("Please insert your age:");
            person.Age = int.Parse(Console.ReadLine());
            if (person.IsValidAge())
                Console.WriteLine("Age is not valid.");
        }
    }
}
