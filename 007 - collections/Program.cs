using System.Collections;

namespace _007___collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //list
            List<string> names = new List<string>();
            names.Add("Nooshin");
            names.Add("Amir");

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //array
            string[] colors = { "Red", "Green", "Blue" };

            for (int i = 0; i < colors.Length; i++)
            {
                Console.WriteLine(colors[i]);
            }

            //arrayList
            ArrayList items = new ArrayList();
            items.Add(10);
            items.Add("salam");
            items.Add(3.14);

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

        }
    }
}
