using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Get
    {
        public static void GetCommand(string verb, Player _player)
        {
            if (string.IsNullOrEmpty(verb))
            {
                Console.WriteLine("You must enter the name of the item to get");
            }
            else
            {
                if (verb != null)
                {
                    foreach (Item item in Player.CurrentLocation.RoomLoot.ToList())
                    {
                        if (item.Name.ToLower() == verb)
                        {
                            if (item.ID > 200 && item.ID <= 300)
                            {
                                _player.Inventory.Add(new InventoryItem(item, 1));
                                Player.CurrentLocation.RoomLoot.Remove(item);
                            }
                            else if (item.ID > 100 && item.ID <= 200)
                            {
                                IWeapon weaponToGet =
                                    World.Weapons.SingleOrDefault(x => x.ID == item.ID);

                                _player.Inventory.Add(new InventoryItem(new Weapon(weaponToGet.ID, weaponToGet.Name, weaponToGet.NamePlural, weaponToGet.Desc,
                                                        weaponToGet.Price, weaponToGet.Damage, weaponToGet.DamageType, weaponToGet.Equiptable, weaponToGet.WearLocation), 1));
                                Player.CurrentLocation.RoomLoot.Remove(item);
                            }
                        }
                    }
                }
            }
        }
    }
}
