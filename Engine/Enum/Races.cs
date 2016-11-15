using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    using System;

    //All of the different Races for the player
    [Flags]
    public enum Races
    {
        //Race Dwarves
        Dwarf,

        //Race Elves
        Elf,

        //Race Gnomes
        Gnome,

        //Race Half-Elves
        HalfElf,

        //Race Half-Orcs
        HalfOrc,

        //Race Halfling
        Halfling,

        //Race Human
        Human
    }
}
