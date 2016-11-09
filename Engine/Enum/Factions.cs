namespace Engine
{
    using System;
        
    /// <summary>All of the different places you can wear a piece of equipment.</summary>
    [Flags]
    public enum Factions : ulong
    {
        /// <summary>Faction for heros.</summary>
        Hero,

        /// <summary>Faction for Villains.</summary>
        Villain,

        /// <summary>Faction for Ventors.</summary>
        Ventor,

        /// <summary>Faction for Thiefs.</summary>
        Thief,

        /// <summary>Faction for Warriors.</summary>
        Warrior,

        /// <summary>Faction for Mages.</summary>
        Mage,

        /// <summary>Faction for Mages.</summary>
        Admin,

        /// <summary>Faction for Mages.</summary>
        Evil,

        /// <summary>Faction for Mages.</summary>
        Good,
    }
}
