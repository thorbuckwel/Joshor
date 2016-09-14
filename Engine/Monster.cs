using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string name { get; set; }
        public int exp { get; set; }
        public int gold { get; set; }
        public int ac { get; set; }
        public int hitPoints { get; set; }
        public int damage { get; set; }
        public int baseAttack { get; set; }

        public Monster(int id, string name, int xp, int gold, int armor, int hp, int dam, int ba) : base(currentHitPoints, maximumHitPoints)
        { 
            this.ID = id;
            this.name = name;
            this.exp = xp;
            this.gold = gold;
            this.ac = armor;
            this.hitPoints = hp;
            this.damage = dam;
            this.baseAttack = ba;
        }
    }
}
