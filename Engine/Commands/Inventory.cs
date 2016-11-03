using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Inventory
    {
        public static void Inv(Player _player)
        {
            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                Console.WriteLine("{0}: {1}", inventoryItem.Description, inventoryItem.Quantity);
            }
        }
    }
}
