using System.Linq;

namespace Hangman
{
    internal class Program
    {
        const int ATTEMPTS = 8;
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "rabbit", "blanket", "glitter", "cranium" };

            //selects random element from the list
            var random = new Random();

            while (true)
            {
                int index = random.Next(words.Count);

                //variables that track the game state
                int guessesLeft = ATTEMPTS;
                int gameOver = 0;

                string word = words[index];
                string hiddenWord = "";

                Console.WriteLine($"Welcome to Hangman! You must guess the word in {ATTEMPTS} attempts to win.\nEnter a character for your guess: \n");

                //loop that sets the hiddenWord string length to the same as the chosen element
                for (int i = 0; i < word.Length; i++)
                {
                    hiddenWord += "_";
                }

                //displays the length and correctly guessed letters of the chosen word to the user
                Console.WriteLine($"\n{hiddenWord}\n");

                List<string> guessesMade = new List<string>();

                //main game loop
                while (true)
                {
                    //makes the input one character only
                    char guess = Console.ReadKey(true).KeyChar;
                    /*
                    //check if the guess has already been made
                    if (guessesMade.Contains(guess.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("You have already made this guess, enter a different character:");
                        continue;
                    }
                    */
                    //checks if the guess character is not present in the element
                    if (!word.Contains(guess, StringComparison.OrdinalIgnoreCase))
                    {
                        guessesLeft--;
                        Console.Clear();
                        Console.WriteLine("That is incorrect!\n");
                        Console.WriteLine($"You have {guessesLeft} guesses left. Try again!");
                    }

                    //if guess character is present in the element
                    else
                    {
                        //loops through each character in the element
                        for (int i = 0; i < word.Length; i++)
                        {
                            //comparison check to see if the element character matches the guess character
                            if (word[i] == guess)
                            {
                                //updates the hiddenWord string to remove the character at the same position of the correctly guessed letter in the element and inserts the correct letter
                                hiddenWord = hiddenWord.Remove(i, 1).Insert(i, guess.ToString());
                            }
                        }
                        Console.Clear();
                        Console.WriteLine("That is correct, keep guessing!\n");
                    }

                    //stores the guess in a list
                    string guessesStored = (char.ToString(guess));
                    guessesMade.Add(guessesStored);
                    Console.Write("Letters guessed: ");
                    //displays all guesses made
                    for (int i = 0; i < guessesMade.Count; i++)
                    {
                        Console.Write($"{guessesMade[i]},");
                    }

                    Console.WriteLine($"\n\n{hiddenWord}\n");

                    //game over check
                    if (guessesLeft <= gameOver)
                    {
                        Console.Clear();
                        Console.WriteLine($"\nGame over! The word was {word}\n\nIf you would like to play again press Y or press any other key to exit");
                        break;
                    }

                    //game won check
                    if (hiddenWord == word)
                    {
                        Console.WriteLine("\nYou guessed the word!\n\nIf you would like to play again press Y or press any other key to exit");
                        break;
                    }
                }

                //prompts user to restart or exit game
                char endGame = Console.ReadKey().KeyChar;

                if (endGame == 'Y')
                {
                    Console.Clear();
                }
                else return;
            }
        }
    }
}