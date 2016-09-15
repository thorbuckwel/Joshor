using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon
    {
        public int id;
        public String name;
        public int cost;
        public int damage;
        public String damageType;

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
