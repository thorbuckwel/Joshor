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
            World.message.SetMessage($"Player Name: {_player.PlayerName}");
            World.message.SetMessage($"Player Class: {_player.PlayerClass}");
            World.message.SetMessage($"Player Race: {_player.PlayerRace}");
            World.message.SetMessage($"Current hit points: {_player.CurrentHitPoints}");
            World.message.SetMessage($"Maximum hit points: {_player.MaximumHitPoints}");
            World.message.SetMessage($"Experience Points: {_player.ExperiencePoints}");
            World.message.SetMessage($"Level: {_player.Level}");
            World.message.SetMessage($"Gold: {_player.Gold}");
            World.message.SetMessage($"Faction: {_player.Factions}");
            World.message.SetMessage($"Alignment: {_player.Alignment}");
        }
    }
}
