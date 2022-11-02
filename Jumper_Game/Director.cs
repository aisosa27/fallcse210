using System;

namespace Jumper_Game
{
    class Director
    {
        private bool playing = true;
        private Word word = new Word();
        private Jumper jumper = new Jumper();
        private Interface face = new Interface();
        private int fails;
        private bool going = true;
        private bool wrong;

        private bool haveWord;
        public Director()
        {
            
        }

    /// This runs the Game loop.
        public void start()
        {
            while (playing)
            {
                word.FindRandoNum();
                word.setWord();
                word.setGuess();
                if (jumper.getParachute().Count == 0)
                {
                    jumper.setParachute();
                }
                fails = 0;

                while (jumper.getAlive())
                {
                    Display();
                    UserInterfacing();
                    Updating();
                    if (haveWord)
                    {
                        break;
                    }
                }
                Display();
                if (haveWord)
                {
                    Console.WriteLine("Congrates for guessing right!!");
                }
                else
                {
                    Console.WriteLine($"Sorry, but the word was {word.getWord()}");
                }
                Console.Write($"Do you want to play again? [y/n] ");
                string playAgain = Console.ReadLine()??"";
                if (playAgain == "y")
                {
                    jumper.setAlive(true);
                    word.deleteGuess();
                }
                else if(playAgain != "y")
                {
                    playing = false;
                }
            }
            Console.WriteLine($"\nThank you for Playing!");
        }
    /// Displays the Jumper and prompts.
        public void Display()
        {
            word.Display();
            jumper.display();
        }

    /// User interaction will be handeled here.
        public void UserInterfacing()
        {
            if (!jumper.getAlive())
            {
                return;
            }
            iFace.letterChecker();
            checkWord(iFace.getGuess());
            gotWord();

   
            if (wrong == false)
            {
                jumper.removeParachute();
                fails += 1;
            }
            
        }
    
    /// Asks player if they are still playing, and updating game.
        public void Updating()
        {
            if (jumper.getAlive() == false)
            {
                return;
            }
            isAlive();
            // isPlaying = jumper.getAlive();
        }

        // Check if the Jumper is alive.
        public void isAlive()
        {
            if (fails < 5)
            {
                jumper.setAlive(true);
            }
            else
            {
                jumper.setAlive(false);
            }
        }

        // This Checks each letter of the word to see if it matches the guessed letter.
        public void checkWord(string UserGuess)
        {
            wrong = false;
            for (int i = 0; i < word.getWordCount(); i++)
            {
               
                if (word.getWord()[i] == UserGuess[0])
                {
                    word.SetGuess(i, UserGuess);
                    wrong = true;
                }
            }
        }

        public void gotWord()
        {
            haveWord = false;
            string guessedWord = "";
            for (int i = 0; i < word.getGuess().Count; i++)
            {
                guessedWord += word.getGuess()[i];
            }
            if (guessedWord == word.getWord())
            {
                haveWord = true;
            }
        }

    }
}
