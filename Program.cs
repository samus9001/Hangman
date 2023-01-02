namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "rabbit", "blanket", "glitter", "cranium" };

            //selects random element from the list
            var random = new Random();
            int index = random.Next(words.Count);
            string word = words[index];
            string hiddenWord = "";

            //variables that track the game state
            char guess;
            int incorrectGuess = 0;
            bool correctGuess = false;
            bool gameWon = false;


            Console.WriteLine("Welcome to Hangman. You must guess the word in 8 tries.\nEnter a character for your guess: \n");

            //outputs the chosen word (for testing)
            Console.WriteLine(word);
            Console.WriteLine(word.Length);

            for (int i = 0; i < word.Length; i++)
            {
                hiddenWord += "_";
            }

            Console.WriteLine(hiddenWord);  // Output: "xxxxx"

            //main game loop
            while (true)
            {
                //makes the input one character only
                guess = Console.ReadKey().KeyChar;

                //loops through each character in the element
                for (int i = 0; i < word.Length; i++)
                {
                    //comparison check to see if the element character matches the guess character
                    if (word[i] == guess)
                    {
                        Console.WriteLine("\nThat is a match!\n");
                        hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guess.ToString());
                    }
                }

                Console.WriteLine(hiddenWord);

                //checks if the guess character is not present in the element
                if (!word.Contains(guess, StringComparison.OrdinalIgnoreCase))
                {
                    incorrectGuess++;
                    //outputs the number of incorrect guesses (for testing)
                    Console.WriteLine("\nincorrect guess = " + incorrectGuess);
                    Console.WriteLine("\nThat is not a match\n");
                }

                if (gameWon)
                {
                    Console.WriteLine("\nYou won!\n");
                    break;
                }

                if (incorrectGuess >= 8)
                {
                    Console.WriteLine("\nGame over");
                    break;
                }
            }
        }
    }
}