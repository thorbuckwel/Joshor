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

            if(_player.Factions != Factions.Admin)
            {
                NormalCommands(verb, noun);
            }
            else
            {
                AdminCommands(verb, noun);
            }
        }

        public static void NormalCommands(string verb, string noun)
        {
            switch (verb)
            {
                case "look":
                    if (noun != "")
                    {
                        Look.Looking(noun);
                    }
                    else
                    {
                        Look.Looking();
                    }
                    break;
                case "help":
                    HelpFile.HelpInfo();
                    break;
                case "score":
                    Score.Stats(Player._player);
                    break;
                case "get":
                    Get.GetCommand(noun, Player._player);
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
                    Inventory.Inv(Player._player);
                    break;
                case "attack":
                    Attack.Attacking(noun, Player._player);
                    break;
                case "drop":
                    ItemDrop.Drop(noun, Player._player);
                    break;
                case "equip":
                    Equipt.Equip(noun, Player._player);
                    break;
                case "save":
                    SaveData.SaveGameData(Player._player);
                    break;
                case "equipment":
                    Worn.DisplayEquipment(Player._player);
                    break;
            }
        }

        public static void AdminCommands(string verb, string noun)
        {
            switch (verb)
            {
                case "create":
                    Create.WhatToCreate();
                    break;
                case "spawn":
                    Spawn.WhatToSpawn();
                    break; 
                default:
                    NormalCommands(verb, noun);
                    break;

            }
        }
    }
}
