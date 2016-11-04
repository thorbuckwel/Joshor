using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class CurrentLocationClass
    {
        #region DisplayCurrentLocation
        public static void DisplayCurrentLocation()
        {
            Console.WriteLine("You are at: {0}", Player.CurrentLocation.RoomName);            

            if (Player.CurrentLocation.RoomDescript != "")
            {
                Console.WriteLine(Player.CurrentLocation.RoomDescript);
            }

            if (Player.CurrentLocation.RoomLoot != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (Item item in Player.CurrentLocation.RoomLoot)
                {
                    Console.WriteLine(item.Name);
                }
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (Player.CurrentLocation.RoomMob != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (Monster mob in Player.CurrentLocation.RoomMob)
                {
                    if (mob.ID != 5)
                    {

                        Player.CurrentMonster = mob;

                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" A " + mob.Name + " is wondering around here.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Player.CurrentMonster = mob;
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" A large " + mob.Name + " fills the room with its massive body.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        #endregion
    }
}
