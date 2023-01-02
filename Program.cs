namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "rabbit", "blanket", "glitter", "cranium" };

            var random = new Random();
            int index = random.Next(words.Count);
            char guess;

            //outputs a random element from the list index (for testing)
            Console.WriteLine($"{words[index]}");

            for (int i = 0; i < words[index].Length; i++)
            {
                //allows the input to only be one character
                guess = Console.ReadKey().KeyChar;

                //checks if the guess contains the matching element within it
                if (words[index][i] == guess)
                {
                    Console.WriteLine("\nThat is a match!");

                }
                else
                {
                    Console.WriteLine("\nThat is not a match");
                }
            }
        }
    }
}