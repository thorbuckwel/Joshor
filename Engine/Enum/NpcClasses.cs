using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    using System;

    //All of the different Classes for the player
    [Flags]
    public enum NpcClasses
    {
        //Class Adept
        Adept,

        //Class Aristocrat
        Aristocrat,

        //Class Commoner
        Commoner,

        //Class Expert
        Expert,

        //Class Warrior
        Warrior
    }
}
