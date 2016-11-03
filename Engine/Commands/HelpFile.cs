using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class HelpFile
    {
        public static void HelpInfo()
        {
            Console.WriteLine("Available commands");
            Console.WriteLine("====================================");
            Console.WriteLine("Stats - Display player information");
            Console.WriteLine("Score - Display player information");
            Console.WriteLine("Look - Get the description of your location");
            Console.WriteLine("Inventory - Display your inventory");
            Console.WriteLine("Quests - Display your quests");
            Console.WriteLine("Attack - Fight the monster");
            Console.WriteLine("Equip <weapon name> - Set your current weapon");
            Console.WriteLine("Drink <potion name> - Drink a potion");
            Console.WriteLine("Trade - display your inventory and vendor's inventory");
            Console.WriteLine("Buy <item name> - Buy an item from a vendor");
            Console.WriteLine("Sell <item name> - Sell an item to a vendor");
            Console.WriteLine("Drop <item name> - Drop an item");
            Console.WriteLine("North - Move North");
            Console.WriteLine("South - Move South");
            Console.WriteLine("East - Move East");
            Console.WriteLine("West - Move West");
            Console.WriteLine("Exit - Save the game and exit");
        }
    }
}
