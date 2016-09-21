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
        public static readonly List<Item> Item = new List<Item>();              // To hold objects of Items
        public static readonly List<Room> Location = new List<Room>();          // To hold objects of rooms                    
    }
}
