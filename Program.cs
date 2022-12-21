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

            //allows the input to only be one character
            char guess = Console.ReadKey().KeyChar;
            string g = Char.ToString( guess );
            
            //checks if the guess contains the matching element within it
            if (g.Contains(words[index], StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("That's a match!");
            }
        }
    }
}