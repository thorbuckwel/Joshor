using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Equipt
    {
        public static void Equip(string noun, Player _player)
        {
            foreach (InventoryItem item in _player.Inventory.ToList())
            {
                if (item.Details.Name.ToLower() == noun.ToString())
                {
                    if (string.IsNullOrEmpty(noun))
                    {
                        Console.WriteLine("You must enter the name of the weapon to equip");
                    }
                    else
                    {
                        IWeapon weaponToEquip =
                            World.Weapons.SingleOrDefault(
                                x => x.Name.ToLower() == noun || x.NamePlural.ToLower() == noun);

                        if (weaponToEquip == null)
                        {
                            Console.WriteLine("You do not have the weapon: {0}", weaponToEquip);
                        }
                        else
                        {
                            _player.Inventory.Add(new InventoryItem(_player.Equipt, 1));
                            _player.Equipt = (Weapon)weaponToEquip;
                            _player.RemoveItemFromInventory((Weapon)weaponToEquip, 1);
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
