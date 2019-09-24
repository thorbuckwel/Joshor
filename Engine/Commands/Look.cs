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
            string CapNoun = CapWord.FirstCharToUpper(noun);
            determineVerbType(CapNoun);
        }

        public static void Looking()
        {
            CurrentLocationClass.DisplayCurrentLocation();
        }

        public static void determineVerbType(string noun)
        {
            Item itemToLook = World.ItemByName(noun);
            IWeapon weaponToLook = World.WeaponByName(noun);
            Monster monsterToLook = World.MonsterByName(noun);
            NPC NpcToLook = World.NPCByName(noun);

            #region Item to look
            if (itemToLook != null)
            { 
                foreach (InventoryItem item in Player._player.Inventory.ToList())
                {
                    if (item.Details.Name == itemToLook.ToString())
                    {
                        LookAtItem(item);
                    }                                      
                }

                foreach (Item rmItem in Player.CurrentLocation.RoomLoot.ToList())
                {
                    if (rmItem.Name == itemToLook.Name)
                    {
                        LookAtItem(rmItem);
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

        #region Item
        public static void LookAtItem(InventoryItem itemToLook)
        {
            Console.WriteLine("Item Name: " + itemToLook.Details);
            Console.WriteLine("Description: " + itemToLook.Details);
            Console.WriteLine("Item Price: " + itemToLook.Price);            
        }
        public static void LookAtItem(Item itemToLook)
        {
            Console.WriteLine("Item Name: " + itemToLook.Name);
            Console.WriteLine("Description: " + itemToLook.Desc);
            Console.WriteLine("Item Price: " + itemToLook.Price);
        }
        #endregion

        #region Weapon
        public static void LookAtWeapon(InventoryItem weaponToLook)
        {
            Console.WriteLine("Weapon Name: " + weaponToLook.WeaponName);
            Console.WriteLine("Description: " + weaponToLook.WeaponDesc);
            Console.WriteLine("Damage: " + weaponToLook.WeaponDamage);
            Console.WriteLine("Damage Type", weaponToLook.WeaponDamageType);
            Console.WriteLine("Price: ", weaponToLook.WeaponPrice.ToString());
        }
        public static void LookAtWeapon(Weapon weaponToLook)
        {
            Console.WriteLine("Weapon Name: " + weaponToLook.Name);
            Console.WriteLine("Description: " + weaponToLook.Desc);
            Console.WriteLine("Damage: " + weaponToLook.Damage);
            Console.WriteLine("Damage Type", weaponToLook.DamageType);
            Console.WriteLine("Price: ", weaponToLook.Price.ToString());
        }
        #endregion

        #region Monster
        public static void LookAtMonster(Monster monsterToLook)
        {
            Console.WriteLine("Name: " + monsterToLook.Name);
            Console.WriteLine("Armor Class: " + monsterToLook.AC);
            Console.WriteLine("Current Hitpoints: " + monsterToLook.CurrentHitPoints);            
        }
        #endregion

        #region NPC
        public static void LookAtNpc(NPC npcToLook)
        {
            Console.WriteLine("Name: " + npcToLook.NPCName);
            Console.WriteLine("Class: " + npcToLook.NPCClass);
            Console.WriteLine("Race: " + npcToLook.NPCRace);            
        }
        #endregion
    }
}
