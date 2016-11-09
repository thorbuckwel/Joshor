using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Attack
    {
        public static void Attacking(string noun, Player _player)
        {
            

            if (Player.CurrentLocation.RoomMob == null)
            {
                Console.WriteLine("There is nothing here to attack");
            }
            else
            {

                Combat fight = new Combat();
                Monster namedMonster;
                NPC namedNPC;
                if (CheckIfMonsterIsInRoom(noun, out namedMonster))
                {
                    fight.Fight(namedMonster, _player);
                    //Monster first
                }
                else if (CheckIfNPCIsInRoom(noun, out namedNPC))
                {
                    //NPC
                    //fight.Fight(namedNPC, _player);
                }
                 else
                {

                    //No creature found
                }
                
                //foreach (Monster mob in Player.CurrentLocation.RoomMob.ToList())
                //{
                    
                //    foreach (NPC npc in Player.CurrentLocation.RmNPC.ToList())
                //    {
                //        if (mob.Name != CapWord.FirstCharToUpper(noun) || npc.NPCName != CapWord.FirstCharToUpper(noun)) 
                //        {
                //            isHere = false;
                //        } 
                                            
                        
                //    }
                //}

                //if (isHere == true)
                //{
                    
                //}

                //if (_player.Equipt == null)
                //{
                //    Console.WriteLine("You do not have any weapons");
                //}

                //else
                //{
                //    Combat fight = new Combat();
                //    fight.Fight(Player.CurrentMonster, _player, _player.Equipt);
                //    //_player.UseWeapon(_player.Equipt);
                //}
            }
        }

        private static bool CheckIfMonsterIsInRoom(string monsterName, out Monster namedMonster)
        {
            foreach (Monster mob in Player.CurrentLocation.RoomMob)
            {
                if (mob.Name.Equals(CapWord.FirstCharToUpper(monsterName)))
                {
                    namedMonster = mob;
                    return true;
                }
            }
            namedMonster = null;
            return false;
        }

        private static bool CheckIfNPCIsInRoom(string npcName, out NPC namedNPC)
        {
            foreach (NPC npc in Player.CurrentLocation.RmNPC)
            {
                if (npc.NPCName.Equals(CapWord.FirstCharToUpper(npcName)))
                {
                    namedNPC = npc;
                    return true;
                }
                    
            }
            namedNPC = null;
            return false;
        }
    }
}          

