namespace _012___practice5___wordGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //set the size of the console buffer
            Console.SetBufferSize(200, 200);

            //change text color in console
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Yellow;

            //add title to the console
            Console.Title = "Game";

            List<string> mainWords = new List<string>()
            {
                "apple", "book", "cat", "dog", "egg",
                "fish", "girl", "hat", "ice", "jam",
                "kite", "lion", "moon", "nose", "owl",
                "pen", "queen", "rat", "sun", "tree",
                "umbrella", "van", "water", "xray", "yarn",
                "zebra", "ball", "car", "door", "ear",
                "frog", "goat", "house", "ink", "juice",
                "key", "leaf", "milk", "nest", "orange",
                "pig", "quill", "ring", "star", "top",
                "unit", "vase", "wall", "yak", "zip"
            };
            while (true)
            {
                Random random = new Random();
                int randomNumber = random.Next(0, 50);
                string randomWord = mainWords[randomNumber];
                char firstChar = randomWord[0];
                string word = firstChar.ToString();


                for (int i = 1; i < randomWord.Length; i++)
                {
                    word = word + "_";
                }
                Console.WriteLine($"please guess {word}");
                string guessedWord = Console.ReadLine();

                if (guessedWord == randomWord)
                    Console.WriteLine("You win");
                else
                    Console.WriteLine("You loose");

            }
        }
    }
}
