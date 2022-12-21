namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "rabbit", "blanket", "glitter", "cranium" };

            var random = new Random();
            int index = random.Next(words.Count);

            //outputs a random element from the list index
            Console.WriteLine($"{words[index]}");

            string guess = Console.ReadLine();

            //checks if the guess contains the matching element within it
            if (guess.Contains(words[index], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("That's a match!");
            }
        }
    }
}