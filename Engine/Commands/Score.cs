using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Score
    {
        public static void Stats(Player _player)
        {
            Console.WriteLine("Player Name: " + _player.PlayerName);
            Console.WriteLine("Player Class: " + _player.PlayerClass);
            Console.WriteLine("Player Race: " + _player.PlayerRace);
            Console.WriteLine("Current hit points: {0}", _player.CurrentHitPoints);
            Console.WriteLine("Maximum hit points: {0}", _player.MaximumHitPoints);
            Console.WriteLine("Experience Points: {0}", _player.ExperiencePoints);
            Console.WriteLine("Level: {0}", _player.Level);
            Console.WriteLine("Gold: {0}", _player.Gold);
            Console.WriteLine("Faction: {0}", _player.Factions);
            Console.WriteLine("Alignment: {0}", _player.Alignment);
        }
    }
}
