﻿namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>() { "rabbit", "blanket", "glitter", "cranium" };

            //selects random element from the list
            var random = new Random();
            int index = random.Next(words.Count);

            //variables that track the game state
            char guess;
            int incorrectGuess = 0;
            const int ATTEMPTS = 8;
            bool correctGuess = false; //not implemented yet
            bool gameWon = false; //not implemented yet

            string word = words[index];
            string hiddenWord = "";


            Console.WriteLine("Welcome to Hangman. You must guess the word in 8 attempts.\nEnter a character for your guess: \n");

            //loop that sets the hiddenWord string length to the same as the chosen element
            for (int i = 0; i < word.Length; i++)
            {
                hiddenWord += "_";
            }

            //displays the length and correclty guessed letters of the chosen word to the user
            Console.WriteLine($"\n{hiddenWord}\n");

            //main game loop
            while (true)
            {
                Console.WriteLine(); //new line
                //makes the input one character only
                guess = Console.ReadKey().KeyChar;
                Console.WriteLine(); //new line

                //checks if the guess character is not present in the element
                if (!word.Contains(guess, StringComparison.OrdinalIgnoreCase))
                {
                    incorrectGuess++;
                    Console.WriteLine("That is incorrect!\n");
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
                }
                Console.WriteLine($"\n{hiddenWord}\n");

                if (incorrectGuess >= ATTEMPTS)
                {
                    Console.WriteLine("\nGame over!");
                    break;
                }

                if (gameWon) //not implemented yet
                {
                    Console.WriteLine("\nYou won!\n");
                    break;
                }
            }
        }
    }
}