using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {

        private int _id;                         // To hold the Room's ID number
        private string _roomName;                // To hold the Room's name
        private string _roomDescript;            // To hold the Room's description
        private Monster _monsters;
        private int _locationToNorth;           // To hold the Room's exit1 string
        private int _locationToEast;            // To hold the Room's exit2 string
        private int _locationToSouth;           // To hold the Room's exit3 string
        private int _locationToWest;            // To hold the Room's exit4 string        
        //private List<Item> _roomItems;
        
        //int numMonsters;
        //int numItems;

        /**
         * Creating the properties to accesss the private variables
         */
        public int ID { get { return _id; } set { _id = value; } }
        public string RoomName { get { return _roomName; } set { _roomName = value; } }
        public string RoomDescript { get { return _roomDescript; } set { _roomDescript = value; } }
        public Monster Monsters { get { return _monsters; } set { _monsters = value; } }
        public int LocationToNorth { get { return _locationToNorth; } set { _locationToNorth = value; } }
        public int LocationToEast { get { return _locationToEast; } set { _locationToEast = value; } }
        public int LocationToSouth { get { return _locationToSouth; } set { _locationToSouth = value; } }
        public int LocationToWest { get { return _locationToWest; } set { _locationToWest = value; } }

        /**
         * This is the Room constructor. It creates a Room object with the passed variables then assignd
         * those to the class variables.
         */
        public Room(int id, String name, String descript, int exit1, int exit2, int exit3, int exit4, int idMonster)
        {
            this.ID = id;
            this.RoomName = name;
            this.RoomDescript = descript;
            this.LocationToNorth = exit1;
            this.LocationToEast = exit2;
            this.LocationToSouth = exit3;
            this.LocationToWest = exit4;
            if (idMonster > 0)
            {
                this.Monsters = World.Monsters[idMonster];
            }
        }                          
    }
}
