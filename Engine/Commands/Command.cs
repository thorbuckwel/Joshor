using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Command
    {
        public static void CommandCase(string input, Player _player)
        {
            string[] commands = input.Split(null);
            string verb = commands[0].ToLower();
            string noun;
            if (commands.Length != 1)
            {
                noun = commands[1];
            }
            else
            {
                noun = "";
            }

            switch(verb)
            {
                case "look":
                    Look.Looking();
                    break;
                case "help":
                    HelpFile.HelpInfo();
                    break;
                case "score":
                    Score.Stats(CreatePlayer._player);
                    break;
                case "get":
                    Get.GetCommand(noun, CreatePlayer._player);
                    break;
                case "north":
                    PlayerMove.MoveTo(verb);
                    break;
                case "east":
                    PlayerMove.MoveTo(verb);
                    break;
                case "south":
                    PlayerMove.MoveTo(verb);
                    break;
                case "west":
                    PlayerMove.MoveTo(verb);
                    break;
                case "inventory":
                    Inventory.Inv(CreatePlayer._player);
                    break;
                case "attack":
                    Attack.Attacking(noun, CreatePlayer._player);
                    break;
                case "drop":
                    ItemDrop.Drop(noun, CreatePlayer._player);
                    break;
                case "equip":
                    Equipt.Equip(noun, CreatePlayer._player);
                    break;
                case "save":
                    SaveData.SaveGameData(CreatePlayer._player);
                    break;


            }

        }
    }
}
