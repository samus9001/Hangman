namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "rabbit", "blanket", "glitter", "cranium" };

            var random = new Random();
            int index = random.Next(words.Count);

            //Console.WriteLine($"LIST 1: {words[0]}");

            //outputs a random element from the list index
            Console.WriteLine($"{words[index]}");

            string guess = Console.ReadLine();
        }
    }
}