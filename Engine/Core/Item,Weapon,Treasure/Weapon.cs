using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : IItem, IEquiptable, IWeapon
    {
        #region Fields
        private int _id;                         // To hold the Weapon's ID number
        private string _name;                    // To hold the Weapon's name
        private int _cost;                       // To hold the Weapon's cost
        private string _damage;                  // To hold the Weapon's damage
        private string _damageType;              // To hold the Weapon's damage type

        #endregion

        /**
         * Create properties to access the private variables.
         */
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string NamePlural { get; set; }
        public int Price { get; set; }
        public string Damage { get; set; }
        public string DamageType { get; set; }
        public int WearLocation { get; set; }
        public string Desc { get; set; }
        public bool Equiptable { get; set; }
        #endregion

        /**
         * This is the Weapons constructor. It creates a Room object with the passed variables then assignd
         * those to the class variables.
         */
        #region Constructor
        public Weapon(int id, string name, string namePluarl, string desc, int cost, string damage, string damageType, bool equiptable, int wearLocation)
        {
            this.ID = id;
            this.Name = name;
            this.NamePlural = namePluarl;
            this.Desc = desc;
            this.Price = cost;
            this.Damage = damage;
            this.DamageType = damageType;
            this.Equiptable = equiptable;
            this.WearLocation = wearLocation;

        }
        #endregion
    }
}
