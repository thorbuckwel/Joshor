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
        public int xp;                                      // To hold the player's xp
        public int gold;                                    // To hold the player's gold
        public int lvl { get { return ((xp / 100) + 1); } }                        // To hold the player's level
        public int ac { get; set; }                         // To hold the player's armor
        public Room _currentLocation;                      // Not used as of yet!
        public Weapon equipt;                               // To hold the currently equipt weapon

        public int Gold { get { return gold; } set { gold = value; OnPropertyChanged("Gold"); } }
        public int ExperiencePoints
        {
            get { return xp; }
            private set
            {
                xp = value;
                OnPropertyChanged("ExperiencePoints");
                OnPropertyChanged("Level");
            }
        }

        public int Level
        {
            get { return ((ExperiencePoints / 100) + 1); }
        }


        /**
        * This is the constructor for the Player class. It accepts values to be assigned to the class variables
        * plus passing the current and max hit points to the LivingCreature class that the Player class is 
        * derived from so that the player can inherate these values.
        */
        public Player (String name, String PC, String PR, int gold, int currentHitPoints, int maximumHitPoints, Weapon equipt, bool isDead) 
            : base(currentHitPoints, maximumHitPoints, isDead)
        {
            this.playerName = name;
            this.playerClass = PC;
            this.playerRace = PR;
            this.gold = gold;
            this.xp = 0;
            //this.lvl = 1;
            this.ac = 10;
            this.equipt = equipt;
        }
                
        public Room CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
            }
        }

        /**
         * This method takes the new location and assigns it to the player's current location.
         */
        public void ChangeLocation(Room location)
        {
            _currentLocation = location;
            
        }

        public void MoveTo(Room location)
        {
            // The player can enter this location
            ChangeLocation(location);  
                   
        }

        /**
         * If the player were to die or for any reason we need to send the player
         * back to the starting postion this will be the method called to do so.
         */
        private void MoveHome()
        {
            MoveTo(World.Location[0]);
        }

        /**
         * This method will add one to the element in the list to move to the next
         * room north
         */
        public void MoveNorth()
        {
            if (World.Location != null)
            {
                int ele = World.Location.IndexOf(_currentLocation);
                MoveTo(World.Location[(++ele)]);                                
            }            
        }

        /**
         * This method will subtract one to the element in the list to move to the next
         * room to the south
         */
        public void MoveSouth()
        {
            if (World.Location != null)
            {
                int ele = World.Location.IndexOf(_currentLocation);
                MoveTo(World.Location[--ele]);
            }
        }                
    }
}
