using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreature
    {
        public string Class { get; private set;}                // To hold the player's class
        public string Race { get; private set; }                // To hold the player's race

        public Weapon EquippedWeapon { get; private set; }                           // To hold the currently equipt weapon

        private Room _currentLocation;
        public Room CurrentLocation
        {
            get { return _currentLocation; }
            private set
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
            }
        }

        private int _gold;
        public int Gold {
            get
            {
                return _gold;
            }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        private int _experiencePoints;
        public int ExperiencePoints
        {
            get
            {
                return _experiencePoints;
            }

            set
            {
                _experiencePoints = value;
                OnPropertyChanged("ExperiencePoints");
                OnPropertyChanged("Level");
            }
        }

        public int Level
        {
            get
            {
                return ((ExperiencePoints / 100) + 1);
            }
        }

        public Player (string name, string playerClass, string race, int gold, int maximumHitPoints, Weapon currentlyEquippedWeapon, int armorClass) 
            : base(maximumHitPoints, name, armorClass)
        {
            this.Class = playerClass;
            this.Race = race;
            this._gold = gold;
            this._experiencePoints = 0;
            this.EquippedWeapon = currentlyEquippedWeapon;
        }
                


        public void MoveTo(int roomIndex)
        {
            if (World.Location != null && (roomIndex >= 0 && roomIndex <= World.Location.Count))
            {
                //Make sure the list isn't null; then make sure the room we're attempting to move to
                //actually exists; roomIndex must be:
                // [0, List.Count], inclusive    --     0 <= roomIndex <= List.Count
                _currentLocation = World.Location[roomIndex];
            }                 
        }

        /**
         * If the player were to die or for any reason we need to send the player
         * back to the starting postion this will be the method called to do so.
         */
        private void MoveHome()
        {
            MoveTo(0);
        }            
    }
}
