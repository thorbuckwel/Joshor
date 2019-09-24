using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class ItemDrop
    {
        public static void Drop(string verb, Player _player)
        {
            if (string.IsNullOrEmpty(verb))
            {
                Console.WriteLine("You must enter the name of the item to drop");
            }
            else
            {
                Item itemToDrop = World.Items.SingleOrDefault(
                                   x => x.Name.ToLower() == verb || x.NamePlural.ToLower() == verb);
                IWeapon weaponToDrop = World.Weapons.SingleOrDefault(
                                   x => x.Name.ToLower() == verb || x.NamePlural.ToLower() == verb);

                foreach (InventoryItem item in _player.Inventory.ToList())
                {
                    if (item.Details.Name.ToLower() == verb.ToString())
                    {
                        if (itemToDrop != null)
                        {
                            _player.RemoveItemFromInventory(itemToDrop, 1);
                            Player.CurrentLocation.RoomLoot.Add(itemToDrop);
                            Console.WriteLine("You drop {0}", verb);
                        }
                        else if (weaponToDrop != null)
                        {
                            _player.RemoveItemFromInventory((Weapon)weaponToDrop, 1);
                            Player.CurrentLocation.RoomLoot.Add((Weapon)weaponToDrop);
                            Console.WriteLine("You drop {0}", verb);
                        }
                    }
                    else if (item.Details.Name == null)
                    {
                        Console.WriteLine("You do not have the item {0}", verb);
                    }
                }
            }
        }
    }
}
