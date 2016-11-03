using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace Engine
{
    public class Player : LivingCreature
    {
        #region Fields
        private String _playerName;                         // To hold the player's name
        private String _playerClass;                        // To hold the player's class
        private String _playerRace;                         // To hold the player's race
        private int _xp;                                    // To hold the player's xp
        private int _gold;                                  // To hold the player's gold
        private int _lvl;                                   // To hold the player's level
        private int _ac;                                    // To hold the player's armor
        private static Room _currentLocation;                      // Not used as of yet!
        private Weapon _equipt;                             // To hold the currently equipt weapon
        private static Monster _currentMonster;

        public List<InventoryItem> Inventory { get; set; }
        public event EventHandler<MessageEventArgs> OnMessage;
        #endregion

        /**
         * Setting Properties to be able to access the private variables.
         */
        #region Properties
        public String PlayerClass { get { return _playerClass; } set { _playerClass = value; } }
        public String PlayerName { get { return _playerName; } set { _playerName = value; } }
        public String PlayerRace { get { return _playerRace; } set { _playerRace = value; } }
        public int ExperiencePoints { get { return _xp; } set { _xp = value;}}
        public int Gold { get { return _gold; } set { _gold = value;} }
        public int Level { get { return ((ExperiencePoints / 100) + 1); }}
        public int AC { get { return _ac; } set { _ac = value; }}
        public static Room CurrentLocation { get { return _currentLocation; } set { _currentLocation = value; } }
        public Weapon Equipt { get { return _equipt; } set { _equipt = value; } }
        public static  Monster CurrentMonster { get { return _currentMonster; } set { _currentMonster = value; } }
        #endregion

        /**
        * This is the constructor for the Player class. It accepts values to be assigned to the class variables
        * plus passing the current and max hit points to the LivingCreature class that the Player class is 
        * derived from so that the player can inherate these values.
        */
        #region Constructors
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
            CurrentLocation = World.Location[0];
        }

        public static Player CreateDefaultPlayer()
        {
            Player player = new Player("Killakia", "Warrior", "Human", 10, 10, 20, World.Weapons[1], false);
            CurrentLocation = World.Location[0];

            return player;
        }
        #endregion

        #region Save,Load XML
        public string ToXmlString()
        {
            XmlDocument playerData = new XmlDocument();

            // Create the top-level XML node
            XmlNode player = playerData.CreateElement("Player");
            playerData.AppendChild(player);

            // Create the "Stats" child node to hold the other player statistics nodes
            XmlNode stats = playerData.CreateElement("Stats");
            player.AppendChild(stats);

            // Create the child nodes for the "Stats" node
            XmlNode playerName = playerData.CreateElement("Name");
            playerName.AppendChild(playerData.CreateTextNode(this.PlayerName.ToString()));
            stats.AppendChild(playerName);

            XmlNode playerClass = playerData.CreateElement("Class");
            playerClass.AppendChild(playerData.CreateTextNode(this.PlayerClass.ToString()));
            stats.AppendChild(playerClass);

            XmlNode playerRace = playerData.CreateElement("Race");
            playerRace.AppendChild(playerData.CreateTextNode(this.PlayerRace.ToString()));
            stats.AppendChild(playerRace);

            XmlNode currentHitPoints = playerData.CreateElement("CurrentHitPoints");
            currentHitPoints.AppendChild(playerData.CreateTextNode(this.CurrentHitPoints.ToString()));
            stats.AppendChild(currentHitPoints);

            XmlNode maximumHitPoints = playerData.CreateElement("MaximumHitPoints");
            maximumHitPoints.AppendChild(playerData.CreateTextNode(this.MaximumHitPoints.ToString()));
            stats.AppendChild(maximumHitPoints);

            XmlNode gold = playerData.CreateElement("Gold");
            gold.AppendChild(playerData.CreateTextNode(this.Gold.ToString()));
            stats.AppendChild(gold);

            XmlNode experiencePoints = playerData.CreateElement("ExperiencePoints");
            experiencePoints.AppendChild(playerData.CreateTextNode(this.ExperiencePoints.ToString()));
            stats.AppendChild(experiencePoints);

            XmlNode currentLocation = playerData.CreateElement("CurrentLocation");
            currentLocation.AppendChild(playerData.CreateTextNode(CurrentLocation.ID.ToString()));
            stats.AppendChild(currentLocation);

            if (Equipt != null)
            {
                XmlNode currentWeapon = playerData.CreateElement("CurrentWeapon");
                currentWeapon.AppendChild(playerData.CreateTextNode(this.Equipt.ID.ToString()));
                stats.AppendChild(currentWeapon);
            }

            // Create the "InventoryItems" child node to hold each InventoryItem node
            XmlNode inventoryItems = playerData.CreateElement("InventoryItems");
            player.AppendChild(inventoryItems);

            // Create an "InventoryItem" node for each item in the player's inventory
            foreach (InventoryItem item in this.Inventory)
            {
                XmlNode inventoryItem = playerData.CreateElement("InventoryItem");

                XmlAttribute idAttribute = playerData.CreateAttribute("ID");
                idAttribute.Value = item.Details.ID.ToString();
                inventoryItem.Attributes.Append(idAttribute);

                XmlAttribute quantityAttribute = playerData.CreateAttribute("Quantity");
                quantityAttribute.Value = item.Quantity.ToString();
                inventoryItem.Attributes.Append(quantityAttribute);

                inventoryItems.AppendChild(inventoryItem);
            }

            // Create the "PlayerQuests" child node to hold each PlayerQuest node
            XmlNode playerQuests = playerData.CreateElement("PlayerQuests");
            player.AppendChild(playerQuests);

            // Create a "PlayerQuest" node for each quest the player has acquired
            //foreach (PlayerQuest quest in this.Quests)
            //{
            //    XmlNode playerQuest = playerData.CreateElement("PlayerQuest");

            //    XmlAttribute idAttribute = playerData.CreateAttribute("ID");
            //    idAttribute.Value = quest.Details.ID.ToString();
            //    playerQuest.Attributes.Append(idAttribute);

            //    XmlAttribute isCompletedAttribute = playerData.CreateAttribute("IsCompleted");
            //    isCompletedAttribute.Value = quest.IsCompleted.ToString();
            //    playerQuest.Attributes.Append(isCompletedAttribute);

            //    playerQuests.AppendChild(playerQuest);
            //}

            return playerData.InnerXml; // The XML document, as a string, so we can save the data to disk
        }

        public static Player CreatePlayerFromXmlString(string xmlPlayerData)
        {
            try
            {
                XmlDocument playerData = new XmlDocument();

                playerData.LoadXml(xmlPlayerData);
                string playerName = playerData.SelectSingleNode("/Player/Stats/Name").InnerText;
                Console.WriteLine("Got name: " + playerName);
                string PC = playerData.SelectSingleNode("/Player/Stats/Class").InnerText;
                Console.WriteLine("Got class: " + PC);
                string PR = playerData.SelectSingleNode("/Player/Stats/Race").InnerText;
                Console.WriteLine("Got race: " + PR);
                int currentHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentHitPoints").InnerText);
                Console.WriteLine("Got current hit points: " + currentHitPoints.ToString());
                int maximumHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumHitPoints").InnerText);
                Console.WriteLine("Got max hit points: " + maximumHitPoints.ToString());
                int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
                Console.WriteLine("Got gold: " + gold.ToString());
                int experiencePoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ExperiencePoints").InnerText);
                Console.WriteLine("Got experience: " + experiencePoints.ToString());
                int equiptString = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
                Console.WriteLine("Got equipt weapon: " + equiptString.ToString());
                Weapon equipt = World.WeaponByID(equiptString);

                Player player = new Player(playerName, PC, PR, gold, currentHitPoints, maximumHitPoints, equipt, false);
                player.RemoveItemFromInventory(World.WeaponByID(101));

                int currentLocationID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText);
                CurrentLocation = World.LocationByID(currentLocationID);

                if (playerData.SelectSingleNode("/Player/Stats/CurrentWeapon") != null)
                {
                    int currentWeaponID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
                    player.Equipt = World.WeaponByID(currentWeaponID);
                }

                foreach (XmlNode node in playerData.SelectNodes("/Player/InventoryItems/InventoryItem"))
                {
                    int id = Convert.ToInt32(node.Attributes["ID"].Value);
                    int quantity = Convert.ToInt32(node.Attributes["Quantity"].Value);

                    if (id > 100 && id <= 200)
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            player.AddItemToInventory(World.WeaponByID(id));
                        }
                    }
                    else
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            player.AddItemToInventory(World.ItemByID(id));
                        }
                    }
                }

                return player;
            }
            catch(Exception ex)
            {
                // If there was an error with the XML data, return a default player object
                //Console.WriteLine(ex.ToString());
                return CreateDefaultPlayer();
                //return null;
            }
        }

        public static string GetXMLFromObject(object o)
        {

            StringWriter sw = new StringWriter();
            XmlTextWriter tw = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(o.GetType());
                tw = new XmlTextWriter(sw);
                serializer.Serialize(tw, o);
            }
            catch (Exception ex)
            {
                //Handle Exception Code
            }
            finally
            {
                sw.Close();
                if (tw != null)
                {
                    tw.Close();
                }
            }
            return sw.ToString();
        }

        public static Object ObjectToXML(string xml, Type objectType)
        {
            StringReader strReader = null;
            XmlSerializer serializer = null;
            XmlTextReader xmlReader = null;
            Object obj = null;
            try
            {
                strReader = new StringReader(xml);
                serializer = new XmlSerializer(objectType);
                xmlReader = new XmlTextReader(strReader);
                obj = serializer.Deserialize(xmlReader);
            }
            catch (Exception exp)
            {
                //Handle Exception Code
            }
            finally
            {
                if (xmlReader != null)
                {
                    xmlReader.Close();
                }
                if (strReader != null)
                {
                    strReader.Close();
                }
            }
            return obj;
        }
        #endregion

        #region Modify Inventory
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

        public void AddItemToInventory(Weapon itemToAdd, int quantity = 1)
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
                Console.WriteLine("Cannot drop an item you do not have.");
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

        public void RemoveItemFromInventory(Weapon weaponToRemove, int quantity = 1)
        {
            Item weapon = weaponToRemove;
            InventoryItem item = Inventory.SingleOrDefault(ii => ii.ItemID == weapon.ID);

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
                RaiseInventoryChangedEvent(weaponToRemove);
            }
        }
        #endregion

        #region Raise Events
        private void RaiseMessage(string message, bool addExtraNewLine = false)
        {
            if (OnMessage != null)
            {
                OnMessage(this, new MessageEventArgs(message, addExtraNewLine));
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
        #endregion

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
                Move.MoveTo(CurrentLocation);
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
                    Move.MoveHome();
                }
            }
        }        
    }
}


