using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        public int ID;
        public String roomName;
        public String roomDescript;
        public String exit1;
        public String exit2;
        public String exit3;
        public String exit4;
    

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
