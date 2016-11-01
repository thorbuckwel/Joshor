using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine
{

    public static class World
    {
        public static readonly List<Monster> Monsters = new List<Monster>();    // To hold objects of Mobs
        public static readonly List<Weapon> Weapons = new List<Weapon>();       // To hold objects of weapons
        public static readonly List<Item> Items = new List<Item>();              // To hold objects of Items
        public static readonly List<Room> Location = new List<Room>();          // To hold objects of rooms 
                           


        public static Item ItemByID(int id)
        {
            return Items.SingleOrDefault(x => x.ID == id);
        }

        public static Monster MonsterByID(int id)
        {
            return Monsters.SingleOrDefault(x => x.ID == id);
        }
        public static Weapon WeaponByID(int id)
        {
            return Weapons.SingleOrDefault(x => x.ID == id);
        }
        public static Weapon WeaponByName(string name)
        {
            return Weapons.SingleOrDefault(x => x.Name == name);
        }

        public static Room LocationByID(int id)
        {
            foreach (Room location in Location)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }

   
}
