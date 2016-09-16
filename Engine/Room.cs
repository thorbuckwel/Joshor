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
        public String exit1 { get; set; }                   // To hold the Room's exit1 string
        public String exit2 { get; set; }                   // To hold the Room's exit2 string
        public String exit3 { get; set; }                   // To hold the Room's exit3 string
        public String exit4 { get; set; }                   // To hold the Room's exit4 string

        /**
         * This is the Room constructor. It creates a Room object with the passed variables then assignd
         * those to the class variables.
         */
        public Room(int id, String name, String descript, String exit1, String exit2, String exit3, String exit4)
        {
            this.ID = id;
            this.roomName = name;
            this.roomDescript = descript;
            this.exit1 = exit1;
            this.exit2 = exit2;
            this.exit3 = exit3;
            this.exit4 = exit4;
        }
    }
}
