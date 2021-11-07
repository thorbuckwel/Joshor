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
            World.message.SetMessage($"Item Name: {itemToLook.Details}");
            World.message.SetMessage($"Description: {itemToLook.Details}");
            World.message.SetMessage($"Item Price: {itemToLook.Price}");
        }
        public static void LookAtItem(Item itemToLook)
        {
            World.message.SetMessage($"Item Name: {itemToLook.Name}");
            World.message.SetMessage($"Description: {itemToLook.Desc }");
            World.message.SetMessage($"Item Price: {itemToLook.Price }");
        }
        #endregion

        #region Weapon
        public static void LookAtWeapon(InventoryItem weaponToLook)
        {
            World.message.SetMessage($"Weapon Name: {weaponToLook.WeaponName}");
            World.message.SetMessage($"Description: {weaponToLook.WeaponDesc}");
            World.message.SetMessage($"Damage: {weaponToLook.WeaponDamage}");
            World.message.SetMessage($"Damage Type: {weaponToLook.WeaponDamageType}");
            World.message.SetMessage($"Price: {weaponToLook.WeaponPrice.ToString()}");
        }
        public static void LookAtWeapon(Weapon weaponToLook)
        {
            World.message.SetMessage($"Weapon Name: {weaponToLook.Name}");
            World.message.SetMessage($"Description: {weaponToLook.Desc}");
            World.message.SetMessage($"Damage: {weaponToLook.Damage}");
            World.message.SetMessage($"Damage Type: {weaponToLook.DamageType}");
            World.message.SetMessage($"Price: {weaponToLook.Price.ToString()}");
        }
        #endregion

        #region Monster
        public static void LookAtMonster(Monster monsterToLook)
        {
            World.message.SetMessage($"Name: {monsterToLook.Name}");
            World.message.SetMessage($"Armor Class: {monsterToLook.AC}");
            World.message.SetMessage($"Current Hitpoints: {monsterToLook.CurrentHitPoints}");            
        }
        #endregion

        #region NPC
        public static void LookAtNpc(NPC npcToLook)
        {
            World.message.SetMessage($"Name: {npcToLook.NPCName}");
            World.message.SetMessage($"Class: {npcToLook.NPCClass}");
            World.message.SetMessage($"Race: {npcToLook.NPCRace}");            
        }
        #endregion
    }
}
