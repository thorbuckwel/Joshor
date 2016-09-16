using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon
    {
        public int id { get; set; }                         // To hold the Weapon's ID number
        public String name { get; set; }                    // To hold the Weapon's name
        public int cost { get; set; }                       // To hold the Weapon's cost
        public int damage { get; set; }                     // To hold the Weapon's damage
        public String damageType { get; set; }              // To hold the Weapon's damage type

        /**
         * This is the Weapons constructor. It creates a Room object with the passed variables then assignd
         * those to the class variables.
         */
        public Weapon(int id, String name, int cost, int damage, String damageType)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.damage = damage;
            this.damageType = damageType;
        }
    }
}
