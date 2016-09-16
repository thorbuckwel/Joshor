using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public String playerName { get; set; }
        public String playerClass { get; set;}
        public String playerRace { get; set; }
        public int xp { get; set; }
        public int gold { get; set;}
        public int lvl { get; set; }
        public int ac { get; set; }

        public Player (String name, String PC, String PR, int gold, int currentHitPoints, int maximumHitPoints) 
            : base(currentHitPoints, maximumHitPoints)
        {
            this.playerName = name;
            this.playerClass = PC;
            this.playerRace = PR;
            this.gold = gold;
            this.xp = 0;
            this.lvl = 1;
            this.ac = 10;
        }


    }
}
