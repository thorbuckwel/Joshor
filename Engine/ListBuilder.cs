using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine
{
    public static class ListBuilder
    {

        public static void Build()
        {
            using (StreamReader reader = File.OpenText(@"C:\Users\thorb_000\Desktop\Monsters.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    String name = reader.ReadLine();
                    int xp = int.Parse(reader.ReadLine());
                    int gold = int.Parse(reader.ReadLine());
                    int armor = int.Parse(reader.ReadLine());
                    int damage = int.Parse(reader.ReadLine());
                    int baseAttack = int.Parse(reader.ReadLine());
                    World.Monsters.Add(new Monster(id, name, xp, gold, armor, damage, baseAttack));
                }
            }

            using (StreamReader reader = File.OpenText(@"C:\Users\thorb_000\Desktop\Weapons.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    String name = reader.ReadLine();
                    int cost = int.Parse(reader.ReadLine());
                    int damage = int.Parse(reader.ReadLine());
                    String type = reader.ReadLine();
                   
                    World.Weapons.Add(new Weapon(id, name, cost, damage, type));
                }
            }

        }
    }
}
