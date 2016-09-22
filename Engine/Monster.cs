using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Monster
    {
        public int ID { get; set; }                         // To hold the ID number of the Monster
        public string Name { get; set; }                    // To hold the Monster's name
        public int Exp { get; set; }                        // To hold the amount of XP recieved for killing
        public int Gold { get; set; }                       // To hold amount of gold recieved from killing
        public int AC { get; set; }                         // To hold how much armor the monster has
        public int Damage { get; set; }                     // To hold how much damage the monster does
        public int BaseAttack { get; set; }                 // To hold the plus or minus amount to ToHit
        public string Image { get; set; }                   // To hold the Monster's image string
        public int CurrentHitPoints { get; set; }
        public int MaxHitPoints { get; set; }
        public bool IsDead { get; set; }

        /**
         * This is the constructor for the Monster class. It accepts values to be assigned to the class variables
         * plus passing the current and max hit points to the LivingCreature class that the Monster class is 
         * derived from so that the monster can inherate these values.
         */
        public Monster(int id, string name, int xp, int gold, int armor, int dam, int ba, int mobcurrentHitpoints, int mobmaximumHitpoints, string image, bool mobIsDead) 
            
        { 
            this.ID = id;
            this.Name = name;
            this.Exp = xp;
            this.Gold = gold;
            this.AC = armor;
            this.Damage = dam;
            this.BaseAttack = ba;
            this.Image = image;
            this.CurrentHitPoints = mobcurrentHitpoints;
            this.MaxHitPoints = mobmaximumHitpoints;
            this.IsDead = mobIsDead;
        }        

        public Monster(Monster m)
        {
            this.ID = m.ID;
            this.Name = m.Name;
            this.Exp = m.Exp;
            this.Gold = m.Gold;
            this.AC = m.AC;
            this.Damage = m.Damage;
            this.BaseAttack = m.BaseAttack;
            this.Image = m.Image;
            this.CurrentHitPoints = m.CurrentHitPoints;
            this.MaxHitPoints = m.MaxHitPoints;
            this.IsDead = m.IsDead;
        }
    }
}
