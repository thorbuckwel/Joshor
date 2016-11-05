using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class DiceRoll
    {
        #region Fields
        private int _numDice;       // To hold how many of that dice to roll
        private int _diceSize;      // To hold the number of size of the die
        private int _diceResult;    // To hold the result of the Roll method
        Random rand = new Random();
        #endregion

        // Create the Class Properties
        #region Properties
        public int NumDice { get { return _numDice; } set { _numDice = value; } }
        public int DiceSize { get { return _diceSize; } set { _diceSize = value; } }
        public int DiceResult { get { Roll(); return _diceResult; } }
        #endregion

        #region Constructors
        public DiceRoll(string typeDice)
        {
            string[] dice = typeDice.Split('D');
            int num = Convert.ToInt32(dice[0]);
            int die = Convert.ToInt32(dice[1]);
            NumDice = num;
            DiceSize = die;
        }

        public DiceRoll(int Num, int Size)
        {
            NumDice = Num;
            DiceSize = Size;
        }
        #endregion

        public int Roll()
        {
            int sum = 0;

            for (int i = 0; i < _numDice; i++)
            {
                sum += rand.Next(_diceSize + 1);
            }

            return sum;
        }
    }
}
