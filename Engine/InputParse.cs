using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class InputParse
    {
        public static void ParseInput(string input)
        {
            // Call the command class to figure out what to do.
            Command.CommandCase(input, Player._player);

            // Write a blank line, to keep the UI a little cleaner
            World.message.SetMessage("");
        }
    }
}
