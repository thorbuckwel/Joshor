using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapons
    {
        private int id;
        private String name;
        private int cost;
        private int damage;
        private String damageType;

        public Weapons(int id, String name, int cost, int damage, String damageType)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
            this.damage = damage;
            this.damageType = damageType;
        }
    }
}
