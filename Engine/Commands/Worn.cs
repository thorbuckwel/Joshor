﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Worn
    {
        public static void DisplayEquipment(Player _player)
        {
            World.message.SetMessage("You are wearing:");
            foreach(var location in _player.Equipted)
            {
                Console.WriteLine($"{location.Key}- {ReplaceNull(location.Value)}");
            }
        }

        public static string ReplaceNull(IItem test)
        {
            if (test == null)
            {
                return "Nothing";
            }

            return test.Name.ToString();
        }
    }
}
