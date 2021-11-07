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
                        World.message.SetMessage("You must enter the name of the weapon to equip");
                    }
                    else
                    {
                        IWeapon weaponToEquip =
                            World.Weapons.SingleOrDefault(
                                x => x.Name.ToLower() == noun || x.NamePlural.ToLower() == noun);

                        if (weaponToEquip == null)
                        {
                            World.message.SetMessage($"You do not have the weapon: {weaponToEquip}");
                        }
                        else
                        {
                            _player.Inventory.Add(new InventoryItem(_player.Equipt, 1));
                            _player.Equipt = (Weapon)weaponToEquip;
                            _player.RemoveItemFromInventory((Weapon)weaponToEquip, 1);
                            World.message.SetMessage($"You equip your {weaponToEquip.Name.ToString()}");
                        }
                    }
                }
                else
                {
                    World.message.SetMessage("No such weapon in inventory");
                }
            }
        }
    }    
}
