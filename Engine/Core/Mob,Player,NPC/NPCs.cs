using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Core.Mob_Player_NPC
{
    class NPCs
    {
        #region Fields
        private bool _isAttackable = false;         // Can this NPC be attacked?
        private Classes _npcClass;                  // What Class are they.
        private NpcClasses _npcSubClass;            // What NPC Class do they belong.
        private bool _ventor = false;               // Are they a ventor.
        private string _damage;                     // If attackable how much damage can they inflict.
        private int _goldAward;                     // Gold recieved if killed
        private int _xpAward;                       // Xp recieved if killed
        #endregion

        #region Properties
        public bool IsAttackable { get { return _isAttackable; } set { _isAttackable = value; } }
        public Classes NpcClass { get { return _npcClass; } set { _npcClass = value; } }
        public NpcClasses NpcSubClass { get { return _npcSubClass; } set { _npcSubClass = value; } }
        public bool Venter { get { return _ventor; } set { _ventor = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public string Damage { get { return _damage; } set { _damage = value; } }
        public int GoldAward { get { return _goldAward; } set { _goldAward = value; } }
        public int XpAward { get { return _xpAward; } set { _xpAward = value; } }
        #endregion

        public NPCs(int id, string name, string damage, int xpAward, int goldAward, string description, Factions faction, int str,
                    int dex, int con, int intel, int wis, int cha) : base(id, name, str, dex, con, intel, wis, cha)
        {

        }
    }
}
