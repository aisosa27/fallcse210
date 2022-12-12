namespace Greed.Game.Casting
{
    
    public class Gem : Actor
    {
        private int points = 5;

        
        public Gem()
        {
        }

        
        public int GetPoints()
        {
            return points;
        }

        
        public int SetScore(int total)
        {
            total += points;
            return total;
        }
    }
}