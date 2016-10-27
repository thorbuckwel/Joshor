using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        private int _id;                         // To hold the Weapon's ID number
        private String _name;                    // To hold the Weapon's name
        private int _cost;                       // To hold the Weapon's cost
        private int _damage;                     // To hold the Weapon's damage
        private String _damageType;              // To hold the Weapon's damage type

        /**
         * Create properties to access the private variables.
         */
        public int Cost { get { return _cost; } set { _cost = value; } }
        public int Damage { get { return _damage; } set { _damage = value; } }
        public String DamageType { get { return _damageType; } set { _damageType = value; } }

        /**
         * This is the Weapons constructor. It creates a Room object with the passed variables then assignd
         * those to the class variables.
         */
        public Weapon(int id, String name, String namePluarl, String desc, int cost, int damage, String damageType, bool equiptable) : base (id, name, namePluarl, desc, cost, equiptable)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = namePluarl;
            this.Desc = desc;
            this.Cost = cost;
            this.Damage = damage;
            this.DamageType = damageType;
            this.Equiptable = equiptable;
        }
    }
}
