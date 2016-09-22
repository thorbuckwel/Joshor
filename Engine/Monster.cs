using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; private set; }                         // To hold the ID number of the Monster
        public int Exp { get; private set; }                        // To hold the amount of XP recieved for killing
        public int Gold { get; private set; }                       // To hold amount of gold recieved from killing
        public Dice DamageDice { get; private set; }                     // To hold how much damage the monster does
        public int BaseHitChance { get; private set; }                 // To hold the plus or minus amount to ToHit
        public string ImagePath { get; private set; }               // To hold the Monster's image string

        /*
         * 0 = ID
         * 1 = Name
         * 2 = Exp
         * 3 = Gold
         * 4 = ArmorClass
         * 5 = Damage Die
         * 6 = BaseChanceToHit
         * 7 = Max hit Points
         * 8 = Path
         */
        public Monster(int maxHitPoints, string name, int armorClass, string[] properties)
            : base(maxHitPoints, name, armorClass)
        {
            ID = int.Parse(properties[0]);
            Exp = int.Parse(properties[2]);
            Gold = int.Parse(properties[3]);
            DamageDice = new Engine.Dice(int.Parse(properties[5]));
            BaseHitChance = int.Parse(properties[6]);
            ImagePath = properties[8];
        }

        public Monster(Monster m) : base (m.MaximumHitPoints, m.Name, m.ArmorClass)
        {
            this.ID = m.ID;
            this.Exp = m.Exp;
            this.Gold = m.Gold;
            this.DamageDice = m.DamageDice;
            this.BaseHitChance = m.BaseHitChance;
            this.ImagePath = m.ImagePath;
        }
    }
}
