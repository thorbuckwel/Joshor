using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Dice
    {
        private Random rollSeed;
        public int NumberOfSides { get; private set; }

        public Dice(int sides)
        {
            NumberOfSides = sides;
            rollSeed = new Random();
        }

        public int Roll()
        {
            //Random.Next(x, y): 
            //X is the inclusive lower bound
            //Y is exclusive - so add 1 to be able to roll this number
            return rollSeed.Next(1, (NumberOfSides + 1));
        } 
    }
}
