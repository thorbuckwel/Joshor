using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Room
    {
        #region Fields
        private int _id;                         // To hold the Room's ID number
        private string _roomName;                // To hold the Room's name
        private string _roomDescript;            // To hold the Room's description
        private Monster _monsters;
        private NPC _npc;
        private int _locationToNorth;           // To hold the Room's exit1 string
        private int _locationToEast;            // To hold the Room's exit2 string
        private int _locationToSouth;           // To hold the Room's exit3 string
        private int _locationToWest;            // To hold the Room's exit4 string        
                                                //private List<Item> _roomItems;

        //int numMonsters;
        //int numItems;
        #endregion

        /**
         * Creating the properties to accesss the private variables
         */
        #region Properties
        public int ID { get { return _id; } set { _id = value; } }
        public string RoomName { get { return _roomName; } set { _roomName = value; } }
        public string RoomDescript { get { return _roomDescript; } set { _roomDescript = value; } }
        public Monster RoomMonsters { get { return _monsters; } set { _monsters = value; } }
        public NPC RoomNPC { get { return _npc; } set { _npc = value; } }
        public int LocationToNorth { get { return _locationToNorth; } set { _locationToNorth = value; } }
        public int LocationToEast { get { return _locationToEast; } set { _locationToEast = value; } }
        public int LocationToSouth { get { return _locationToSouth; } set { _locationToSouth = value; } }
        public int LocationToWest { get { return _locationToWest; } set { _locationToWest = value; } }
        public List<IItem> RoomLoot = new List<IItem>();
        public List<Monster> RoomMob = new List<Monster>();
        public List<NPC> RmNPC = new List<NPC>();
        #endregion

        /**
         * This is the Room constructor. It creates a Room object with the passed variables then assignd
         * those to the class variables.
         */
        #region Constructor
        public Room(int id, String name, String descript, int exit1, int exit2, int exit3, int exit4, int idMonster, int idRmLoot, int idRmNPC)
        {
            this.ID = id;
            this.RoomName = name;
            this.RoomDescript = descript;
            this.LocationToNorth = exit1;
            this.LocationToEast = exit2;
            this.LocationToSouth = exit3;
            this.LocationToWest = exit4;

            #region Monster List Add
            if (idMonster != 5) // 5 == dragon (Monster.Txt)
            {
                if (idMonster > -1)
                {

                    Random rand = new Random();

                    //int rmMobCatch = rand.Next(1, 5);
                    int rmMobCatch = RandomNumberGenerator.NumberBetween(0, 3); // 0 - 3 goblin - dog (element index)
                    this.RoomMonsters = new Monster(World.Monsters[rmMobCatch]);
                    this.RoomMob.Add(RoomMonsters);
                }
            }
            else
            {
                this.RoomMob.Add(World.MonsterByID(idMonster));
            }
            #endregion

            #region Room Loot
            if (idRmLoot > -1)
            {
                if (idRmLoot > 200 && idRmLoot <= 300)
                {
                    Item rmLoot = World.Items.SingleOrDefault(ii => ii.ID == idRmLoot);
                    RoomLoot.Add(new Item(rmLoot.ID, rmLoot.Name, rmLoot.NamePlural, rmLoot.Desc, rmLoot.Price, rmLoot.Equiptable));
                    
                }
                else if (idRmLoot > 100 && idRmLoot <= 200)
                {
                    IWeapon rmLoot = World.Weapons.SingleOrDefault(ii => ii.ID == idRmLoot);
                    RoomLoot.Add(new Weapon(rmLoot.ID, rmLoot.Name, rmLoot.NamePlural, rmLoot.Desc, rmLoot.Price, rmLoot.Damage, rmLoot.DamageType, rmLoot.Equiptable, rmLoot.WearLocation));
                }
            }
            #endregion


            #region NPC Load
            if (idRmNPC != -1)
            {
                if (idRmNPC == 601) // 601== Bob the Cook (NPC.Txt)
                {
                    this.RoomNPC = new NPC(World.NPCByID(idRmNPC));
                    this.RmNPC.Add(RoomNPC);
                }
                else if (idRmNPC == 602) // 602== Dragon Trainer (NPC.Txt)
                {
                    this.RoomNPC = new NPC(World.NPCByID(idRmNPC));
                    this.RmNPC.Add(World.NPCByID(idRmNPC));
                }
            }
            #endregion


        }
        #endregion       
    }
}

