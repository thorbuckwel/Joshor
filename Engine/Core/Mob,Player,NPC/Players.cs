using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Players : MobleObject
    {

        #region Fields
        private Classes _pClass;                // Holds player Class
        private Races _pRace;                   // Holds player Race
        private int _gold, _xp, _alignment;     // Holds gold, xp, alignment values
        private bool _admin;                    // Is or is not Admin
        private Factions _faction;              // Holds the faction of the player
        private Room _currentLocation;
        private Weapon _equipt;
        private Monster _currentMonster;
        private NPC _npc;
        #endregion

        List<InventoryItem> Inventory;

        #region Properties
        public Classes Class { get { return _pClass; } set { _pClass = value; } }
        public Races Race { get { return _pRace; } set { _pRace = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int XP { get { return _xp; } set { _xp = value; } }
        public int Alignment { get { return _alignment; } set { _alignment = value; } }
        public Factions Faction { get { return _faction} set { _faction = value; } }
        #endregion

        #region Constructors
        // Constructor for a new player (no fort, reflex, will, hp and other stats that need calculating)
        public Players(int id, string name, Races race, Classes pClass, int gold, int xp, int alignment,
                        bool admin, Factions faction, int str, int dex, int con, int intel, int wis,
                        int cha) : base (id, name, str, dex, con, intel, wis, cha)
        {
            this.Race = race;
            this.Class = pClass;
            this.Gold = gold;
            this.XP = xp;
            this.Alignment = alignment;
            this.Faction = faction;
        }

        // Constructor for loading existing players.
        public Players(int id, string name, Races race, Classes pClass, int gold, int xp, int alignment,
                        bool admin, Factions faction, int str, int dex, int con, int intel, int wis,
                        int cha, int fort, int reflex, int will, int currentHp, int maxHp, int ac,
                        int baseAttack) : base (id, name, str, dex, con, intel, wis, cha, fort, reflex, will,
                            currentHp, maxHp, ac, baseAttack)
        {
            this.Race = race;
            this.Class = pClass;
            this.Gold = gold;
            this.XP = xp;
            this.Alignment = alignment;
            this.Faction = faction;
        }
        #endregion
    }
}
