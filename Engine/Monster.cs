﻿using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }                         // To hold the ID number of the Monster
        public string name { get; set; }                    // To hold the Monster's name
        public int exp { get; set; }                        // To hold the amount of XP recieved for killing
        public int gold { get; set; }                       // To hold amount of gold recieved from killing
        public int ac { get; set; }                         // To hold how much armor the monster has
        public int damage { get; set; }                     // To hold how much damage the monster does
        public int baseAttack { get; set; }                 // To hold the plus or minus amount to ToHit
        public string image { get; set; }                   // To hold the Monster's image string

        /**
         * This is the constructor for the Monster class. It accepts values to be assigned to the class variables
         * plus passing the current and max hit points to the LivingCreature class that the Monster class is 
         * derived from so that the monster can inherate these values.
         */
        public Monster(int id, string name, int xp, int gold, int armor, int dam, int ba, int currentHitpoints, int maximumHitpoints, string image) 
            : base(currentHitpoints, maximumHitpoints)
        { 
            this.ID = id;
            this.name = name;
            this.exp = xp;
            this.gold = gold;
            this.ac = armor;
            this.damage = dam;
            this.baseAttack = ba;
            this.image = image;
        }

        internal Monster NewInstanceOfMonster()
        {
            Monster newMonster = new Monster(ID, name, exp, gold, ac, damage, baseAttack, CurrentHitPoints, MaximumHitPoints, image);

            return newMonster;
        }
    }
}
