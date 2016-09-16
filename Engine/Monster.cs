using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int exp { get; set; }
        public int gold { get; set; }
        public int ac { get; set; }
        public int damage { get; set; }
        public int baseAttack { get; set; }
        public string image { get; set; }

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
    }
}
