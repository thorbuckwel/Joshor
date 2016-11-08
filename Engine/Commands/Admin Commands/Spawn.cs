using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Spawn
    {
        public static void WhatToSpawn()
        {
            string userInput;

            Console.WriteLine("What do you want to spawn?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Item, NPC, MOB, Weapon > ");
            Console.ForegroundColor = ConsoleColor.White;
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "item")
            {
                SpawnItem();
            }
            else if (userInput.ToLower() == "npc")
            {
                SpawnNPC();
            }
            else if (userInput.ToLower() == "mob")
            {
                SpawnMob();
            }
            else if (userInput.ToLower() == "weapon")
            {
                SpawnWeapon();
            }
        }

        #region Spawn Item
        public static void SpawnItem()
        {
            string userInput;
            bool exist = true;            

            Console.WriteLine("Name of Item to spawn.");
            userInput = CapWord.FirstCharToUpper(Console.ReadLine());

            foreach (Item item in World.Items.ToList())
            {
                if (item.Name != userInput)
                {
                    exist = false;                                   
                }
                else
                {
                    Player.CurrentLocation.RoomLoot.Add(new Item(item.ID, item.Name, item.NamePlural, item.Desc, item.Price, item.Equiptable));
                    exist = true;
                }                
            }

            if (exist == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Item does not exist, maybe create it first?");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        #endregion

        public static void SpawnNPC()
        {
            string userInput;
            bool exist = true;

            Console.WriteLine("Name of NPC to spawn.");
            userInput = CapWord.FirstCharToUpper(Console.ReadLine());

            foreach (NPC npc in World.NPCs.ToList())
            {
                if (npc.NPCName != userInput)
                {
                    exist = false;
                }
                else
                {
                    Player.CurrentLocation.RmNPC.Add(new NPC(npc.ID, npc.NPCName, npc.NPCClass, npc.NPCRace, npc.Gold, npc.CurrentHitPoints,
                                                    npc.MaximumHitPoints, npc.IsDead, npc.CanBeAttacked, npc.Factions));
                    exist = true;
                    break;
                }
            }

            if (exist == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Item does not exist, maybe create it first?");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void SpawnMob()
        {
            string userInput;
            bool exist = true;

            Console.WriteLine("Name of Mob to spawn.");
            userInput = CapWord.FirstCharToUpper(Console.ReadLine());

            foreach (Monster mob in World.Monsters.ToList())
            {
                if (mob.Name != userInput)
                {
                    exist = false;
                }
                else
                {
                    Player.CurrentLocation.RoomMob.Add(new Monster(mob.ID, mob.Name, mob.Experiance, mob.Gold, mob.AC, mob.Damage,
                                                    mob.BaseAttack, mob.CurrentHitPoints, mob.MaximumHitPoints, mob.Image, mob.IsDead, mob.CanBeAttacked, mob.Factions));
                    exist = true;
                    break;
                }
            }

            if (exist == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Mob does not exist, maybe create it first?");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public static void SpawnWeapon()
        {
            string userInput;
            bool exist = true;

            Console.WriteLine("Name of weapon to spawn.");
            userInput = CapWord.FirstCharToUpper(Console.ReadLine());

            foreach (Weapon weapon in World.Weapons.ToList())
            {
                if (weapon.Name != userInput)
                {
                    exist = false;
                }
                else
                {
                    Player.CurrentLocation.RoomLoot.Add(new Weapon(weapon.ID, weapon.Name, weapon.NamePlural, weapon.Desc, weapon.Price, weapon.Damage,
                                                        weapon.DamageType, weapon.Equiptable));
                    exist = true;
                }
            }
        }
    }    
}
