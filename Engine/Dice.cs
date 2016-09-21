using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Dice
    { 
        private int _diceSize;      // To hold the number of size of the die
        private int _diceResult;    // To hold the result of the Roll method

        // Create the Class Properties
        public int DiceSize
        {
            get { return _diceSize; }
            set { _diceSize = value; }
        }

        public int DiceResult
        {
            get
            {
                Roll();
                return _diceResult;
            }
        }

        // Create Constructor
        public Dice()
        {
            DiceSize = 6;
        }

        public Dice(int Size)
        {
            DiceSize = Size;
        }


        // Create random object
        Random rand = new Random();

        // Method to determine a random number for the die.
        private void Roll()
        {
            _diceResult = rand.Next(_diceSize) + 1;
        }
    }
}
