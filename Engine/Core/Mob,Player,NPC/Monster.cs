using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Monster : LivingCreature
    {
        #region Fields
        private int _id;                         // To hold the ID number of the Monster
        private string _name;                    // To hold the Monster's name
        private int _exp;                        // To hold the amount of XP recieved for killing
        private int _gold;                       // To hold amount of gold recieved from killing
        private int _ac;                         // To hold how much armor the monster has
        private string _damage;                  // To hold how much damage the monster does
        private int _baseAttack;                 // To hold the plus or minus amount to ToHit
        private string _image;                   // To hold the Monster's image string
        private int _currentHitPoints;           // To hold the Monster's current hit points
        private int _maxHitPoints;               // To hold the Monster's max hit points
        private bool _isDead;                    // To tell is the Monster is dead or alive
        #endregion

        /**
         * Set the properties so that we have access to the private variables
         */
        #region Properties
        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public int Experiance { get { return _exp; } set { _exp = value; } }
        public int Gold { get { return _gold; } set { _gold = value; } }
        public int AC { get { return _ac; } set { _ac = value; } }
        public string Damage { get { return _damage; } set { _damage = value; } }
        public int BaseAttack { get { return _baseAttack; } set { _baseAttack = value; } }
        public string Image { get { return _image; } set { _image = value; } }
        public int CurrentHitPoints { get { return _currentHitPoints; } set { _currentHitPoints = value; } }
        public int MaxHitPoints { get { return _maxHitPoints; } set { _maxHitPoints = value; } }
        public bool IsDead { get { return _isDead; } set { _isDead = value; } }
        #endregion

        /**
         * This is the constructor for the Monster class. It accepts values to be assigned to the class variables
         * plus passing the current and max hit points to the LivingCreature class that the Monster class is 
         * derived from so that the monster can inherate these values.
         */
        #region Constructors
        public Monster(int id, string name, int xp, int gold, int armor, string dam, int ba, int mobcurrentHitpoints, int mobmaximumHitpoints, string image, bool mobIsDead, bool canBeAttacked, Factions faction):
            base(mobcurrentHitpoints, mobmaximumHitpoints, mobIsDead, canBeAttacked, faction)
            
        { 
            this.ID = id;
            this.Name = name;
            this.Experiance = xp;
            this.Gold = gold;
            this.AC = armor;
            this.Damage = dam;
            this.BaseAttack = ba;
            this.Image = image;
            this.CurrentHitPoints = mobcurrentHitpoints;
            this.MaxHitPoints = mobmaximumHitpoints;
            this.IsDead = mobIsDead;
        }        

        /**
         * At the moment this will be used to make a deep copy of a monster object so we can use it and
         * not mess with the object that is in the list.
         */
        public Monster(Monster m) : base(m.CurrentHitPoints, m.MaximumHitPoints, m.IsDead, m.CanBeAttacked, m.Factions)
        {
            this.ID = m.ID;
            this.Name = m.Name;
            this.Experiance = m.Experiance;
            this.Gold = m.Gold;
            this.AC = m.AC;
            this.Damage = m.Damage;
            this.BaseAttack = m.BaseAttack;
            this.Image = m.Image;
            this.CurrentHitPoints = m.CurrentHitPoints;
            //this.MaximumHitPoints = m.MaxHitPoints;
            this.IsDead = m.IsDead;
        }
        #endregion
    }
}
