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

        private static string[] GetNextLine(StreamReader reader)
        {
            string[] line = reader.ReadLine().Split(' ');
            return line;
        }

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
            #region Build Monster
            using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Monsters.txt"))
            {
                while (!reader.EndOfStream)
                {
                    //string line = reader.ReadLine();
                    //string[] properties = GetNextLine(reader);

                    int id = int.Parse(GetNextLine(reader)[1]);
                    
                    string name = GetNextLine(reader)[1];
                    
                    int xp = int.Parse(GetNextLine(reader)[1]);
                    
                    int armor = int.Parse(GetNextLine(reader)[1]);
                   
                    int gold = int.Parse(GetNextLine(reader)[1]);
                    
                    string damage = GetNextLine(reader)[1];
                    
                    int baseAttack = int.Parse(GetNextLine(reader)[1]);
                    
                    int currentHitpoints = int.Parse(GetNextLine(reader)[1]);
                    
                    int maxHitpoints = int.Parse(GetNextLine(reader)[1]);

                    string image = GetNextLine(reader)[1];

                    bool isDead = bool.Parse(GetNextLine(reader)[1]);

                    bool canBeattacked = bool.Parse(GetNextLine(reader)[1]);

                    Factions faction = (Factions)Enum.Parse(typeof(Factions), GetNextLine(reader)[1], true);

                    World.Monsters.Add(new Monster(id, name, xp, gold, armor, damage, baseAttack, currentHitpoints, maxHitpoints, image, isDead, canBeattacked, faction));
                }
            }
            #endregion

            /**
             * We need to build each object to go into the NPC List. First we use the StreamReader
             * to open the NPC text file that stores all the information that is need to create
             * the monsters. This file is formated to be in a certain order. Then we use the while loop
             * to assign the value to the variables one line at a time until we reach the end of the
             * text file. After we have assigned values to the variables we then pass the variables
             * to create the NPC object that is then stored in the Monster List.
             */
            #region Build NPC
            using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/NPCs.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    string npcName = reader.ReadLine();
                    string npcClass = reader.ReadLine();
                    string npcRace = reader.ReadLine();
                    int gold = int.Parse(reader.ReadLine());
                    int currentHitpoints = int.Parse(reader.ReadLine());
                    int maxHitpoints = int.Parse(reader.ReadLine());
                    bool isDead = bool.Parse(reader.ReadLine());                    
                    bool canBeattacked = bool.Parse(reader.ReadLine());
                    Factions faction = (Factions)Enum.Parse(typeof(Factions), reader.ReadLine(), true); 
                    World.NPCs.Add(new NPC(id, npcName, npcClass, npcRace, gold, currentHitpoints, maxHitpoints, isDead, canBeattacked, faction));
                }
            }
            #endregion

            /**
             * We need to build each object to go into the Weapon List. First we use the StreamReader
             * to open the Monsters text file that stores all the information that is need to create
             * the weaponss. This file is formated to be in a certain order. Then we use the while loop
             * to assign the value to the variables one line at a time until we reach the end of the
             * text file. After we have assigned values to the variables we then pass the variables
             * to create the weapon object that is then stored in the Weapon List.
             */
            #region Build Weapon
            using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Weapon.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    string name = reader.ReadLine();
                    string namePluarl = reader.ReadLine();
                    string desc = reader.ReadLine();
                    int cost = int.Parse(reader.ReadLine());
                    string damage = reader.ReadLine();
                    string type = reader.ReadLine();
                    bool equiptable = bool.Parse(reader.ReadLine());
                    int wearLocation = int.Parse(reader.ReadLine());

                    World.Weapons.Add(new Weapon(id, name, namePluarl, desc, cost, damage, type, equiptable, wearLocation));
                }
            }
            #endregion

            /**
             * We need to build each object to go into the Room List. First we use the StreamReader
             * to open the Monsters text file that stores all the information that is need to create
             * the rooms. This file is formated to be in a certain order. Then we use the while loop
             * to assign the value to the variables one line at a time until we reach the end of the
             * text file. After we have assigned values to the variables we then pass the variables
             * to create the room object that is then stored in the Rooms List.
             */
            #region Build Room
            using (StreamReader reader = File.OpenText(@"../../../Engine/Docs/Room.txt"))
            {
                while (!reader.EndOfStream)
                {
                    int id = int.Parse(reader.ReadLine());
                    string name = reader.ReadLine();
                    string descript = reader.ReadLine();
                    int exit1 = int.Parse(reader.ReadLine());
                    int exit2 = int.Parse(reader.ReadLine());
                    int exit3 = int.Parse(reader.ReadLine());
                    int exit4 = int.Parse(reader.ReadLine());
                    int idMonster = int.Parse(reader.ReadLine());
                    int idRmLoot = int.Parse(reader.ReadLine());
                    int idRoomNPC = int.Parse(reader.ReadLine());

                    World.Location.Add(new Room(id, name, descript, exit1, exit2, exit3, exit4, idMonster, idRmLoot, idRoomNPC));
                }
            }
            #endregion

            /**
             * We need to build each object to go into the Items List. First we use the StreamReader
             * to open the Items text file that stores all the information that is need to create
             * the monsters. This file is formated to be in a certain order. Then we use the while loop
             * to assign the value to the variables one line at a time until we reach the end of the
             * text file. After we have assigned values to the variables we then pass the variables
             * to create the monster object that is then stored in the Monster List.
             */
            #region Build Item
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
            #endregion

        }
    }
}
