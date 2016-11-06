namespace Engine
{
    using System;
        
    /// <summary>All of the different places you can wear a piece of equipment.</summary>
    [Flags]
    public enum Factions : ulong
    {
        /// <summary>Faction for heros.</summary>
        Hero = 1,

        /// <summary>Faction for Villains.</summary>
        Villain = 2,

        /// <summary>Faction for Ventors.</summary>
        Ventor = 4,

        /// <summary>Faction for Thiefs.</summary>
        Thief = 8,

        /// <summary>Faction for Warriors.</summary>
        Warrior = 16,

        /// <summary>Faction for Mages.</summary>
        Mage = 32,

        /// <summary>Faction for Mages.</summary>
        Admin = 64,

        /// <summary>Faction for Mages.</summary>
        Evil = 128,

        /// <summary>Faction for Mages.</summary>
        Good = 256,
    }
}
