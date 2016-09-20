using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        public int ID { get; set; }                         // To hold the Room's ID number
        public String roomName { get; set; }                // To hold the Room's name
        public String roomDescript { get; set; }            // To hold the Room's description
        public bool LocationToNorth { get; set; }                   // To hold the Room's exit1 string
        public bool LocationToEast { get; set; }                   // To hold the Room's exit2 string
        public bool LocationToSouth { get; set; }                   // To hold the Room's exit3 string
        public bool LocationWest { get; set; }                   // To hold the Room's exit4 string

        public List<Monster> inhabitants;
        public List<Item> roomItems;
        int numMonsters;
        int numItems;


        /**
         * This is the Room constructor. It creates a Room object with the passed variables then assignd
         * those to the class variables.
         */
        public Room(int id, String name, String descript, bool exit1, bool exit2, bool exit3, bool exit4)
        {
            this.ID = id;
            this.roomName = name;
            this.roomDescript = descript;
            this.LocationToNorth = exit1;
            this.LocationToEast = exit2;
            this.LocationToSouth = exit3;
            this.LocationWest = exit4;
        }

       
    }
}
