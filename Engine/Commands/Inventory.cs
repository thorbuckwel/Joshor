﻿using System;
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
                World.message.SetMessage($"{inventoryItem.WeaponName}: {inventoryItem.Quantity}");
            }
        }
    }
}
