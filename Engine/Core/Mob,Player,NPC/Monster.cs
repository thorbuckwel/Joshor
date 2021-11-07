using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Monster : LivingCreature
    {
        /**
         * Set the properties so that we have access to the private variables
         */
        #region Properties
        public string Name { get; set; }
        public int Experiance { get; set; }
        public int Gold { get; set; }
        public int AC { get; set; }
        public string Damage { get; set; }
        public int BaseAttack { get; set; }
        public string Image { get; set; }
        public int MaxHitPoints { get; set; }
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
