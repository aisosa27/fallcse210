using System;
using System.Collections.Generic;


namespace hilo_game
{
    
    public class Director
    {
        Card card1 = new Card();
        
        bool isPlaying = true;
        
        int score = 300;

        string guess = " ";

       
        /// Constructs a new instance of Director.
       
        public Director()
        {

        }

      
        public void StartGame()
        {
            while (isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Asks the user if they want to roll.
     
        public void GetInputs()
        {
            Console.WriteLine();
            Console.Write($"The Card is: {card1.value}.");
            Console.WriteLine();
            Console.Write("Higher or Lower? [h/l] ");
            Console.WriteLine();
            guess = Console.ReadLine();

            
        }

       
        /// Updates the player's score.
  
        public void DoUpdates()
        {

            Card card2 = new Card();
            Console.WriteLine();

            Console.Write($"The New Cards is: {card2.value}.");
            Console.WriteLine();

            if (guess == "h" && card2.value >= card1.value)
            {
                score += 100;
            }
            else if (guess == "l" && card2.value <= card1.value)
            {
                score += 100;
            }
            else { 
                score -= 75;
            }

           card1.value = card2.value;
        }
        
     
        /// Displays the dice and the score and asks the player if they want to roll again. 
      
        public void DoOutputs()

        {   
            Console.WriteLine();
            Console.Write($"The score is: {score}.");
            Console.WriteLine();

            Console.Write($"Do you want to play agian? [y/n]");
            Console.WriteLine();
            

            string answer = Console.ReadLine();

            if (answer == "n")
            {
                isPlaying = false;
            }
            
        }
    }
}
