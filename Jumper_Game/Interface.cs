using System;

namespace Jumper_Game
{
    class Interface
    {
        private string guessLetter = "";
        public Interface()
        {
            
        }

// Ask user what letter they guess.
        public void askUser()
        {
            Console.Write($"Guess a Letter [a-z]: ");
            guessLetter = Console.ReadLine()??"";
        }
        
// Getter for Guess

        public string getGuess()
        {
            return guessLetter;
        }

        //letter checker
        public void letterChecker()
        {
            do
            {
                askUser();
            } while (guessLetter.Length != 1 );
        }
    }
}