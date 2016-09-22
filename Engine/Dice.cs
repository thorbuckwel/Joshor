using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Dice
    { 
        public int NumberOfSides { get; private set; }

        public Dice(int sides)
        {
            NumberOfSides = sides;
        }

        public int Roll()
        {
            Random roll = new Random();
            //Random.Next(x, y): 
            //X is the inclusive lower bound
            //Y is exclusive - so add 1 to be able to roll this number
            return roll.Next(1, (NumberOfSides + 1));
        } 
    }
}
