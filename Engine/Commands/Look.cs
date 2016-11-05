using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Look
    {
        public static void Looking(string noun)
        {
            string CapNoun = FirstCharToUpper(noun);
            determineVerbType(CapNoun);
        }

        public static void Looking()
        {
            CurrentLocationClass.DisplayCurrentLocation();
        }

        public static void determineVerbType(string noun)
        {
            Item itemToLook = World.ItemByName(noun);
            Weapon weaponToLook = World.WeaponByName(noun);
            Monster monsterToLook = World.MonsterByName(noun);
            NPC NpcToLook = World.NPCByName(noun);

            #region Item to look
            if (itemToLook != null)
            { 
                foreach (InventoryItem item in Player._player.Inventory.ToList())
                {
                    if (item.Details.Name.ToLower() == itemToLook.ToString())
                    {
                        LookAtItem(item);
                    }
                    else
                    {
                        foreach (Item rmitem in Player.CurrentLocation.RoomLoot.ToList())
                        {
                            if (item.Details.Name.ToLower() == itemToLook.ToString())
                            {
                                LookAtItem(item);
                            }
                        }
                    }                    
                }           
            }
            #endregion

            #region Weapon to look
            else if (weaponToLook != null)
            {
                foreach (InventoryItem weapon in Player._player.Inventory.ToList())
                {
                    if (weapon.Details.Name == weaponToLook.Name)
                    {
                        LookAtWeapon(weapon);
                    }
                }
               
                foreach (Weapon rmWeapon in Player.CurrentLocation.RoomLoot.ToList())
                {
                    if (rmWeapon.Name == weaponToLook.Name)
                    {
                        LookAtWeapon(rmWeapon);
                    }
                }
                
            }
            #endregion

            #region Monster to look
            else if (monsterToLook != null)
            {
                foreach (Monster mob in Player.CurrentLocation.RoomMob.ToList())
                {
                    if (mob.Name == monsterToLook.Name)
                    {
                        LookAtMonster(mob);
                    }                   
                }
            }
            #endregion

            #region Npc to look
            else if (NpcToLook != null)
            {
                foreach (NPC npc in Player.CurrentLocation.RmNPC.ToList())
                {
                    if (npc.NPCName == NpcToLook.NPCName)
                    {
                        LookAtNpc(npc);
                    }
                }               
            }
            #endregion
        }

        public static void LookAtItem(InventoryItem itemToLook)
        {
            Console.WriteLine("Item Name: " + itemToLook.Details);
            Console.WriteLine("Description: " + itemToLook.Details);
            Console.WriteLine("Item Price: " + itemToLook.Price);            
        }

        #region Weapon
        public static void LookAtWeapon(InventoryItem weaponToLook)
        {
            Console.WriteLine("Weapon Name: " + weaponToLook.Details.Name);
            Console.WriteLine("Description: " + weaponToLook.Details.Desc);
            //Console.WriteLine("Damage: " + weaponToLook.Description.);
            //Console.WriteLine("Damage Type", weaponToLook.DamageType);
            //Console.WriteLine("Price: ", weaponToLook.Price.ToString());
        }
        public static void LookAtWeapon(Weapon weaponToLook)
        {
            Console.WriteLine("Weapon Name: " + weaponToLook.Name);
            Console.WriteLine("Description: " + weaponToLook.Desc);
            Console.WriteLine("Damage: " + weaponToLook.Damage);
            Console.WriteLine("Damage Type", weaponToLook.DamageType.ToString());
            Console.WriteLine("Price: ", weaponToLook.Price.ToString());
        }
        #endregion

        public static void LookAtMonster(Monster monsterToLook)
        {
            Console.WriteLine("Name: " + monsterToLook.Name);
            Console.WriteLine("Armor Class: " + monsterToLook.AC);
            Console.WriteLine("Current Hitpoints: " + monsterToLook.CurrentHitPoints);            
        }

        public static void LookAtNpc(NPC npcToLook)
        {
            Console.WriteLine("Name: " + npcToLook.NPCName);
            Console.WriteLine("Class: " + npcToLook.NPCClass);
            Console.WriteLine("Race: " + npcToLook.NPCRace);            
        }

        public static string FirstCharToUpper(string input)
        {
            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("ARGH!");
            return input.First().ToString().ToUpper() + input.Substring(1);
        }

    }
}
