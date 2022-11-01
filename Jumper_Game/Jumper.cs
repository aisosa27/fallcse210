using System;
using System.Collections.Generic;

namespace Jumper_Game
{
    class Jumper
    {
        private List<string> parachute = new List<string>();
        private string aliveLilman = ("  O \n /|\\ \n / \\ \n");
        private string deadLilman = ("   X \n  /|\\ \n  / \\ \n");
        private bool alive = true;
        public Jumper()
        {
            
        }

    /// This function displays the Jumper.
        public void display()
        {
            // Placeholder output for displaying word
            

            for (int i = 0; i < parachute.Count; i++)
            {
                Console.WriteLine(parachute[i]);
            }

            if (alive)
            {
                Console.Write($"{aliveLilman}");  
            } 
            else
            {
                Console.Write($"{deadLilman}");
            }
            Console.Write("^^^^^^^^\n");

        }
        
// Setter for Alive

        public void setAlive(bool nowAlive)
        {
            alive = nowAlive;
        }

        public void setParachute()
        {
            parachute.Add(" ____");
            parachute.Add("/    \\");
            parachute.Add(" ---- ");
            parachute.Add("\\    /");
            parachute.Add(" \\  /");
        }
        public List<string> getParachute()
        {
            return parachute;
        }

// Getter for Alive

        public bool getAlive()
        {
            return alive;
        }

        public void removeParachute()
        {
            parachute.Remove(parachute[0]);
        }

        
    }
}