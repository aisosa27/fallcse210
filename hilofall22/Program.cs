using hilo;


namespace hilo_game
{
    
    /// The program's entry point.
    
    class Program
    {
        
        /// Starts the program using the given arguments.
      
        static int Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
            return 0;
        }
    }
}
