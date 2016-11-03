using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Equipt
    {
        public static void Equip(string verb, Player _player)
        {
            foreach (InventoryItem item in _player.Inventory.ToList())
            {
                if (item.Details.Name.ToLower() == verb.ToString())
                {
                    if (string.IsNullOrEmpty(verb))
                    {
                        Console.WriteLine("You must enter the name of the weapon to equip");
                    }
                    else
                    {
                        Weapon weaponToEquip =
                            World.Weapons.SingleOrDefault(
                                x => x.Name.ToLower() == verb || x.NamePlural.ToLower() == verb);

                        if (weaponToEquip == null)
                        {
                            Console.WriteLine("You do not have the weapon: {0}", weaponToEquip);
                        }
                        else
                        {
                            _player.Inventory.Add(new InventoryItem(_player.Equipt, 1));
                            _player.Equipt = weaponToEquip;
                            _player.RemoveItemFromInventory(weaponToEquip, 1);
                            Console.WriteLine("You equip your {0}", weaponToEquip.Name.ToString());
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No such weapon in inventory");
                }
            }
        }
    }    
}
