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

    public static Item(int id)
    {
        return _items.SingleOrDefault(x => x.ID == id);
    }

    public static Monster MonsterByID(int id)
    {
        return _monsters.SingleOrDefault(x => x.ID == id);
    }

    public static Quest QuestByID(int id)
    {
        return _quests.SingleOrDefault(x => x.ID == id);
    }

    public static Location LocationByID(int id)
    {
        return _locations.SingleOrDefault(x => x.ID == id);
    }
}
