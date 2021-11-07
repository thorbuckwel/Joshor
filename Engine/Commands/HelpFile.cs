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
            World.message.SetMessage("Available commands");
            World.message.SetMessage("====================================");
            World.message.SetMessage("Stats - Display player information");
            World.message.SetMessage("Score - Display player information");
            World.message.SetMessage("Look - Get the description of your location");
            World.message.SetMessage("Inventory - Display your inventory");
            World.message.SetMessage("Quests - Display your quests");
            World.message.SetMessage("Attack - Fight the monster");
            World.message.SetMessage("Equip <weapon name> - Set your current weapon");
            World.message.SetMessage("Drink <potion name> - Drink a potion");
            World.message.SetMessage("Trade - display your inventory and vendor's inventory");
            World.message.SetMessage("Buy <item name> - Buy an item from a vendor");
            World.message.SetMessage("Sell <item name> - Sell an item to a vendor");
            World.message.SetMessage("Drop <item name> - Drop an item");
            World.message.SetMessage("North - Move North");
            World.message.SetMessage("South - Move South");
            World.message.SetMessage("East - Move East");
            World.message.SetMessage("West - Move West");
            World.message.SetMessage("Exit - Save the game and exit");
        }
    }
}
