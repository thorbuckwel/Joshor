using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class PlayerMove
    {
        public static void MoveTo(string verb)
        {
            Move.MoveToNew(verb);
            CurrentLocationClass.DisplayCurrentLocation();
            if (Move.canGo == false)
            {
                Console.WriteLine("You can not go " + verb);
            }
        }
    }    
}
