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
            /**
             * We need to build each object to go into the Monster List. First we use the StreamReader
             * to open the Monsters text file that stores all the information that is need to create
             * the monsters. This file is formated to be in a certain order. Then we use the while loop
             * to assign the value to the variables one line at a time until we reach the end of the
             * text file. After we have assigned values to the variables we then pass the variables
             * to create the monster object that is then stored in the Monster List.
             */
            using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Monsters.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    String name = reader.ReadLine();
                    int xp = int.Parse(reader.ReadLine());                    
                    int armor = int.Parse(reader.ReadLine());
                    int gold = int.Parse(reader.ReadLine());
                    int damage = int.Parse(reader.ReadLine());
                    int baseAttack = int.Parse(reader.ReadLine());
                    int currentHitpoints = int.Parse(reader.ReadLine());
                    int maxHitpoints = int.Parse(reader.ReadLine());                    
                    String image = reader.ReadLine();
                    bool isDead = bool.Parse(reader.ReadLine());
                    World.Monsters.Add(new Monster(id, name, xp, gold, armor, damage, baseAttack, currentHitpoints, maxHitpoints, image, isDead));
                }
            }

            /**
             * We need to build each object to go into the Weapon List. First we use the StreamReader
             * to open the Monsters text file that stores all the information that is need to create
             * the weaponss. This file is formated to be in a certain order. Then we use the while loop
             * to assign the value to the variables one line at a time until we reach the end of the
             * text file. After we have assigned values to the variables we then pass the variables
             * to create the weapon object that is then stored in the Weapon List.
             */
            using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Weapon.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    String name = reader.ReadLine();
                    String namePluarl = reader.ReadLine();
                    String desc = reader.ReadLine();
                    int cost = int.Parse(reader.ReadLine());
                    int damage = int.Parse(reader.ReadLine());
                    String type = reader.ReadLine();
                    bool equiptable = bool.Parse(reader.ReadLine());

                    World.Weapons.Add(new Weapon(id, name, namePluarl, desc, cost, damage, type, equiptable));
                }
            }

            /**
             * We need to build each object to go into the Room List. First we use the StreamReader
             * to open the Monsters text file that stores all the information that is need to create
             * the rooms. This file is formated to be in a certain order. Then we use the while loop
             * to assign the value to the variables one line at a time until we reach the end of the
             * text file. After we have assigned values to the variables we then pass the variables
             * to create the room object that is then stored in the Rooms List.
             */
            using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Room.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    String name = reader.ReadLine();
                    String descript = reader.ReadLine();
                    int exit1 = int.Parse(reader.ReadLine());
                    int exit2 = int.Parse(reader.ReadLine());
                    int exit3 = int.Parse(reader.ReadLine());
                    int exit4 = int.Parse(reader.ReadLine());
                    int idMonster = int.Parse(reader.ReadLine());

                    World.Location.Add(new Room(id, name, descript, exit1, exit2, exit3, exit4, idMonster));
                }
            }

            /**
             * We need to build each object to go into the Items List. First we use the StreamReader
             * to open the Items text file that stores all the information that is need to create
             * the monsters. This file is formated to be in a certain order. Then we use the while loop
             * to assign the value to the variables one line at a time until we reach the end of the
             * text file. After we have assigned values to the variables we then pass the variables
             * to create the monster object that is then stored in the Monster List.
             */
            using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Items.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    String name = reader.ReadLine();
                    String namePluarl = reader.ReadLine();
                    String desc = reader.ReadLine();
                    int cost = int.Parse(reader.ReadLine());
                    bool equiptable = bool.Parse(reader.ReadLine());

                    World.Items.Add(new Item(id, name, namePluarl, desc, cost, equiptable));
                }
            }

        }
    }    
}
