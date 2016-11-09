using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC : LivingCreature
    {

        #region Fields
        private int _id;                                 // To hold the ID number of the Monster
        private String _npcName;                         // To hold the player's name
        private String _npcClass;                        // To hold the player's class
        private String _npcRace;                         // To hold the player's race
        private int _gold;                               // To hold the player's gold
        

        public List<InventoryItem> Inventory { get; set; }
        public event EventHandler<MessageEventArgs> OnMessage;
        public static Player _player;
        #endregion

        #region Properties
        public int ID { get { return _id; } set { _id = value; } }
        public String NPCClass { get { return _npcClass; } set { _npcClass = value; } }
        public String NPCName { get { return _npcName; } set { _npcName = value; } }
        public String NPCRace { get { return _npcRace; } set { _npcRace = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        #endregion

        /**
        * This is the constructor for the NPC class. It accepts values to be assigned to the class variables
        * plus passing the current and max hit points to the LivingCreature class that the Player class is 
        * derived from so that the player can inherate these values.
        */
        #region Constructor
        public NPC(int id, String name, String PC, String PR, int gold, int currentHitPoints, int maximumHitPoints,bool isDead, bool canBeAttacked, Factions faction)
            : base(currentHitPoints, maximumHitPoints, isDead, canBeAttacked, faction)
        {
            this.ID = id;
            this.NPCName = name;
            this.NPCClass = PC;
            this.NPCRace = PR;
            this.Gold = gold;
            Inventory = new List<InventoryItem>();
        }

        /**
         * At the moment this will be used to make a deep copy of a monster object so we can use it and
         * not mess with the object that is in the list.
         */
        public NPC(NPC m) : base(m.CurrentHitPoints, m.MaximumHitPoints, m.IsDead, m.CanBeAttacked, m.Factions)
        {
            this.ID = m.ID;
            this.NPCName = m.NPCName;
            this.NPCClass = m.NPCClass;
            this.NPCRace = m.NPCRace;
            this.Gold = m.Gold;
            this.CurrentHitPoints = m.CurrentHitPoints;
            this.IsDead = m.IsDead;
            this.CanBeAttacked = m.CanBeAttacked;
        }
        #endregion
    }
}
