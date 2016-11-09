using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using JosherConsole;


namespace Engine
{
    public class Create
    {        
        public static void WhatToCreate()
        {
            string userInput;

            Console.WriteLine("What do you want to create?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Item, NPC, MOB, Weapon, Room > ");
            Console.ForegroundColor = ConsoleColor.White;
            //CreateScreen createForm = new CreateScreen();
            //createForm.Show();
            userInput = Console.ReadLine();



            if (userInput.ToLower() == "item")
            {
                CreateItem();
            }
            else if (userInput.ToLower() == "npc")
            {
                CreateNPC();
            }
            else if (userInput.ToLower() == "mob")
            {
                CreateMob();
            }
            else if (userInput.ToLower() == "weapon")
            {
                CreateWeapon();
            }
            else if (userInput.ToLower() == "room")
            {
                CreateRoom();
            }
        }

        #region CreateItem
        public static void CreateItem()
        {
            CreateScreen createItem = new CreateScreen();
            //This gives the newly instantiated copy of the form
            //focus, instead of the console window    
            createItem.Show();
            createItem.Activate();
            Application.Run(createItem);
           
        }
        #endregion

        #region Create NPC
        public static void CreateNPC()
        {
            CreateNPC createNpc = new CreateNPC();
            //This gives the newly instantiated copy of the form
            //focus, instead of the console window    
            createNpc.Show();
            createNpc.Activate();
            Application.Run(createNpc);


            //    World.NPCs.Add(new NPC(id, npcName, npcClass, npcRace, gold, currentHP, maxHP, false, canBeAttacked, faction));

            //    if (File.Exists(@"../../../Engine/Docs/NPCs.txt"))
            //    {
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", "" + Environment.NewLine);
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", id.ToString() + Environment.NewLine);
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", npcName + Environment.NewLine);
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", npcClass + Environment.NewLine);
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", npcRace + Environment.NewLine);
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", gold + Environment.NewLine);
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", currentHP.ToString() + Environment.NewLine);
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", maxHP.ToString());
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", isDead.ToString());
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", canBeAttacked.ToString());
            //        File.AppendAllText(@"../../../Engine/Docs/NPCs.txt", faction.ToString());
            //    }

            //    exist = true;
            //}
        }
        #endregion

        #region Create Mob
        public static void CreateMob()
        {
            CreateMob createMob = new CreateMob();
            //This gives the newly instantiated copy of the form
            //focus, instead of the console window    
            createMob.Show();
            createMob.Activate();
            Application.Run(createMob); 
        }
        #endregion

        #region Create Weapon
        public static void CreateWeapon()
        {
            CreateWeapon createWeapon = new CreateWeapon();
            Application.Run(createWeapon);
        }
        #endregion

        #region Create Room
        public static void CreateRoom()
        {
            string userInput;
            int id;
            string name;
            string descript;
            int exit1;
            int exit2;
            int exit3;
            int exit4;
            int idMonster;
            int idRmLoot;
            int idRoomNPC;
            bool exist = false;

            while (exist == false)
            {
                Console.WriteLine("What is the room's ID?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("401 - 500 >");
                Console.ForegroundColor = ConsoleColor.White;
                userInput = Console.ReadLine();

                if (userInput != null)
                {
                    id = Convert.ToInt32(userInput);
                    if (id > 400 && id <= 500)
                    {
                        foreach (Room room in World.Location.ToList())
                        {
                            if (room.ID == id)
                            {
                                Console.WriteLine("That room already exist");
                            }
                        }


                        Console.WriteLine("Name of the room.");
                        name = Console.ReadLine();

                        Console.WriteLine("Give it a description.");
                        descript = Console.ReadLine();

                        Console.WriteLine("If exit to north give that rooms id, else -1.");
                        exit1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("If exit to east give that rooms id, else -1.");
                        exit2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("If exit to south give that rooms id, else -1.");
                        exit3 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("If exit to west give that rooms id, else -1.");
                        exit4 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Id of Mob here, else -1.");
                        idMonster = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Id of item in the room, else -1.");
                        idRmLoot = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Id of NPC in the room, else -1.");
                        idRoomNPC = Convert.ToInt32(Console.ReadLine());


                        World.Location.Add(new Room(id, name, descript, exit1, exit2, exit3, exit4, idMonster, idRmLoot, idRoomNPC));

                        if (File.Exists(@"../../../Engine/Docs/Room.txt"))
                        {
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", "" + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", id.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", name + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", descript + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", exit1.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", exit2.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", exit3.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", exit4.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", idMonster.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", idRmLoot.ToString() + Environment.NewLine);
                            File.AppendAllText(@"../../../Engine/Docs/Room.txt", idRoomNPC .ToString());
                        }

                        exist = true;
                    }

                }
            }
        }
        #endregion
    }
}
