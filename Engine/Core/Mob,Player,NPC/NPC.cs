using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class NPC : LivingCreature
    {
        public List<InventoryItem> Inventory { get; set; }
        public event EventHandler<MessageEventArgs> OnMessage;
        public static Player _player; //Not sure why this is here
        

        #region Properties
        public string NPCClass { get; set; }
        public string NPCName { get; set; }
        public string NPCRace { get; set; }
        public int Gold { get; set; }
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
