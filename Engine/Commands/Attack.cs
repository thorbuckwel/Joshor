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
            if ( Player.CurrentLocation.RoomMob == null)
            {
                Console.WriteLine("There is nothing here to attack");
            }
            else
            {

                //if (_player.Equipt == null)
                //{
                //    // Select the first weapon in the player's inventory 
                //    // (or 'null', if they do not have any weapons)
                //    _player.Equipt = _player. .FirstOrDefault();
                //}

                if (_player.Equipt == null)
                {
                    Console.WriteLine("You do not have any weapons");
                }
                else
                {                    
                    Combat fight = new Combat();
                    fight.Fight(Player.CurrentMonster, _player, _player.Equipt);
                    //_player.UseWeapon(_player.Equipt);
                }
            }
        }
    }    
}
