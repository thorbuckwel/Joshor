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
        private Monster _currentMonster;

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
        public Monster CurrentMonster { get { return _currentMonster; } set { _currentMonster = value; } }
        


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
            this.Inventory.Add(new InventoryItem(new Weapon(101, "Club", "Clubs", "Short little stick", 100, 6, "Blunt", true), 1));
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

        public void AddItemToInventory(Item itemToAdd, int quantity = 1)
        {
            InventoryItem item = Inventory.SingleOrDefault(ii => ii.Details.ID == itemToAdd.ID);

            if (item == null)
            {
                // They didn't have the item, so add it to their inventory
                Inventory.Add(new InventoryItem(itemToAdd, quantity));
            }
            else
            {
                // They have the item in their inventory, so increase the quantity
                item.Quantity += quantity;
            }

            RaiseInventoryChangedEvent(itemToAdd);
        }

        public void RemoveItemFromInventory(Item itemToRemove, int quantity = 1)
        {
            InventoryItem item = Inventory.SingleOrDefault(ii => ii.ItemID == itemToRemove.ID);

            if (item == null)
            {
                // The item is not in the player's inventory, so ignore it.
                // We might want to raise an error for this situation
            }
            else
            {
                // They have the item in their inventory, so decrease the quantity
                item.Quantity -= quantity;

                // Don't allow negative quantities.
                // We might want to raise an error for this situation
                if (item.Quantity < 0)
                {
                    item.Quantity = 0;
                }

                // If the quantity is zero, remove the item from the list
                if (item.Quantity == 0)
                {
                    Inventory.Remove(item);
                }

                // Notify the UI that the inventory has changed
                RaiseInventoryChangedEvent(itemToRemove);
            }
        }

        private void RaiseInventoryChangedEvent(Item item)
        {
            if (item is Weapon)
            {
                OnPropertyChanged("Weapons");
            }

            //if (item is HealingPotion)
            //{
            //    OnPropertyChanged("Potions");
            //}
        }

        public void UseWeapon(Weapon weapon)
        {
            // Determine the amount of damage to do to the monster
            int damageToMonster = RandomNumberGenerator.NumberBetween(1, weapon.Damage);

            // Apply the damage to the monster's CurrentHitPoints
            _currentMonster.CurrentHitPoints -= damageToMonster;

            // Display message
            RaiseMessage("You hit the " + _currentMonster.Name + " for " + damageToMonster + " points.");

            // Check if the monster is dead
            if (_currentMonster.CurrentHitPoints <= 0)
            {
                // Monster is dead
                RaiseMessage("");
                RaiseMessage("You defeated the " + _currentMonster.Name);

                // Give player experience points for killing the monster
                //AddExperiencePoints(_currentMonster.RewardExperiencePoints);
                //RaiseMessage("You receive " + _currentMonster.RewardExperiencePoints + " experience points");

                // Give player gold for killing the monster 
                //Gold += _currentMonster.RewardGold;
                //RaiseMessage("You receive " + _currentMonster.RewardGold + " gold");

                // Get random loot items from the monster
                List<InventoryItem> lootedItems = new List<InventoryItem>();

                // Add items to the lootedItems list, comparing a random number to the drop percentage
                //foreach (LootItem lootItem in _currentMonster.LootTable)
                //{
                //    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                //    {
                //        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                //    }
                //}

                // If no items were randomly selected, then add the default loot item(s).
                //if (lootedItems.Count == 0)
                //{
                //    foreach (LootItem lootItem in _currentMonster.LootTable)
                //    {
                //        if (lootItem.IsDefaultItem)
                //        {
                //            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                //        }
                //    }
                //}

                // Add the looted items to the player's inventory
                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        RaiseMessage("You loot " + inventoryItem.Quantity + " " + inventoryItem.Details.Name);
                    }
                    else
                    {
                        RaiseMessage("You loot " + inventoryItem.Quantity + " " + inventoryItem.Details.NamePlural);
                    }
                }

                // Add a blank line to the messages box, just for appearance.
                RaiseMessage("");

                // Move player to current location (to heal player and create a new monster to fight)
                MoveTo(CurrentLocation);
            }
            else
            {
                // Monster is still alive

                // Determine the amount of damage the monster does to the player
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.Damage);

                // Display message
                RaiseMessage("The " + _currentMonster.Name + " did " + damageToPlayer + " points of damage.");

                // Subtract damage from player
                CurrentHitPoints -= damageToPlayer;

                if (CurrentHitPoints <= 0)
                {
                    // Display message
                    RaiseMessage("The " + _currentMonster.Name + " killed you.");

                    // Move player to "Home"
                    MoveHome();
                }
            }
        }
    }
}
