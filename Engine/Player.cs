using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;

namespace Engine
{
    public class Player : LivingCreature
    {
        private String _playerName;                         // To hold the player's name
        private String _playerClass;                        // To hold the player's class
        private String _playerRace;                         // To hold the player's race
        private int _xp;                                    // To hold the player's xp
        private int _gold;                                  // To hold the player's gold
        private int _lvl;                                   // To hold the player's level
        private int _ac;                                    // To hold the player's armor
        private Room _currentLocation;                      // Not used as of yet!
        private Weapon _equipt;                             // To hold the currently equipt weapon

        public List<InventoryItem> Inventory { get; set; }
        public event EventHandler<MessageEventArgs> OnMessage;

        /**
         * Setting Properties to be able to access the private variables.
         */
        public String PlayerClass { get { return _playerClass; } set { _playerClass = value; } }
        public String PlayerName { get { return _playerName; } set { _playerName = value; } }
        public String PlayerRace { get { return _playerRace; } set { _playerRace = value; } }
        public int ExperiencePoints { get { return _xp; } set { _xp = value;}}
        public int Gold { get { return _gold; } set { _gold = value;} }
        public int Level { get { return ((ExperiencePoints / 100) + 1); }}
        public int AC { get { return _ac; } set { _ac = value; }}
        public Room CurrentLocation { get { return _currentLocation; } set { _currentLocation = value; } }
        public Weapon Equipt { get { return _equipt; } set { _equipt = value; } }


        /**
        * This is the constructor for the Player class. It accepts values to be assigned to the class variables
        * plus passing the current and max hit points to the LivingCreature class that the Player class is 
        * derived from so that the player can inherate these values.
        */

        
        public Player (String name, String PC, String PR, int gold, int currentHitPoints, int maximumHitPoints, Weapon equipt, bool isDead) 
            : base(currentHitPoints, maximumHitPoints, isDead)
        {
            this.PlayerName = name;
            this.PlayerClass = PC;
            this.PlayerRace = PR;
            this.Gold = gold;
            this.ExperiencePoints = 0;
            this.AC = 10;
            this.Equipt = equipt;
            Inventory = new List<InventoryItem>();
            this.Inventory.Add(new InventoryItem(new Weapon(101, "Club", "Clubs", 100, 6, "Blunt"), 1));
            this.CurrentLocation = World.Location[0];
        }

        public static Player CreateDefaultPlayer()
        {
            Player player = new Player("Killakia", "Warrior", "Human", 10, 10, 20, World.Weapons[1], false);
            player.CurrentLocation = World.Location[0];

            return player;
        }

        //public static Player CreatePlayerFromXmlString(string xmlPlayerData)
        //{
        //    try
        //    {
        //        XmlDocument playerData = new XmlDocument();

        //        playerData.LoadXml(xmlPlayerData);

        //        int currentHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentHitPoints").InnerText);
        //        int maximumHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumHitPoints").InnerText);
        //        int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
        //        int experiencePoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ExperiencePoints").InnerText);

        //        Player player = new Player(name, PC, PR, gold, currentHitPoints, maximumHitPoints, equipt, isDead);

        //        int currentLocationID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText);
        //        player.CurrentLocation = World.Location(currentLocationID);

        //        if (playerData.SelectSingleNode("/Player/Stats/CurrentWeapon") != null)
        //        {
        //            int currentWeaponID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
        //            player.Equipt = (Weapon)World.ItemByID(currentWeaponID);
        //        }

        //        foreach (XmlNode node in playerData.SelectNodes("/Player/InventoryItems/InventoryItem"))
        //        {
        //            int id = Convert.ToInt32(node.Attributes["ID"].Value);
        //            int quantity = Convert.ToInt32(node.Attributes["Quantity"].Value);

        //            for (int i = 0; i < quantity; i++)
        //            {
        //                player.AddItemToInventory(World.ItemByID(id));
        //            }
        //        }                

        //        return player;
        //    }
        //    catch
        //    {
        //        // If there was an error with the XML data, return a default player object
        //        return CreateDefaultPlayer();
        //    }
        //}

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
                MoveTo(World.Location[CurrentLocation.LocationToNorth]);                                
            }            
        }
        public void MoveEast()
        {
            if (World.Location != null)
            {
                int ele = World.Location.IndexOf(_currentLocation);
                MoveTo(World.Location[CurrentLocation.LocationToEast]);
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
                MoveTo(World.Location[CurrentLocation.LocationToSouth]);
            }
        }
        public void MoveWest()
        {
            if (World.Location != null)
            {
                int ele = World.Location.IndexOf(_currentLocation);
                MoveTo(World.Location[CurrentLocation.LocationToWest]);
            }
        }

        private void RaiseMessage(string message, bool addExtraNewLine = false)
        {
            if (OnMessage != null)
            {
                OnMessage(this, new MessageEventArgs(message, addExtraNewLine));
            }
        }
    }
}
