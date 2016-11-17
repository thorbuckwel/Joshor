using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    class Mob : MobleObject
    {
        #region Fields
        private string _damage;         // Hold the Mobs damage
        private int _xpAward;           // Hold the xp award
        private int _goldAward;          // Hold the gold award
        private string _description;    // Hold the Mob's description
        #endregion

        #region Properties
        public string Damage { get { return _damage; } set { _damage = value; } }
        public int XpAward { get { return _xpAward; } set { _xpAward = value; } }
        public int GoldAward { get { return _goldAward; } set { _goldAward = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        #endregion

        #region Constructor
        // The Mob will be recreated each time
        public Mob(int id, string name, string damage, int xpAward, int goldAward, string description, Factions faction, int str,
                    int dex, int con, int intel, int wis, int cha) : base(id, name, str, dex, con, intel, wis, cha)
        {
            this.Damage = damage;
            this.XpAward = xpAward;
            this.GoldAward = goldAward;
            this.Description = description;
        }
        #endregion
    }
}
