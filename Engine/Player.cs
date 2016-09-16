using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public String playerName { get; set; }              // To hold the player's name
        public String playerClass { get; set;}              // To hold the player's class
        public String playerRace { get; set; }              // To hold the player's race
        public int xp { get; set; }                         // To hold the player's xp
        public int gold { get; set;}                        // To hold the player's gold
        public int lvl { get; set; }                        // To hold the player's level
        public int ac { get; set; }                         // To hold the player's armor
        private Room _currentLocation;                      // Not used as of yet!

        /**
        * This is the constructor for the Player class. It accepts values to be assigned to the class variables
        * plus passing the current and max hit points to the LivingCreature class that the Player class is 
        * derived from so that the player can inherate these values.
        */
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

        /**
         * Not used as of yet!
         */
        public Room CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
            }
        }

        
    }
}
