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
        public Dictionary<string, IEquiptable> Equipted = new Dictionary<string, IEquiptable>();
        public event EventHandler<MessageEventArgs> OnMessage;
        public static Player _player;  //Not sure why this is here

        /**
         * Setting Properties to be able to access the private variables.
         */
        #region Properties
        public List<InventoryItem> Inventory { get; set; }
        public string PlayerClass { get; set; }
        public string PlayerName { get; set; }
        public string PlayerRace { get; set; }
        public int ExperiencePoints { get; set; }
        public int Gold { get; set; }
        // TODO figure out how to work experanice
        public int Level { get; set; }
        public int AC { get; set; }
        public int MaxHitPoints { get; set; }
        public Factions Faction { get; set; }
        public int Alignment { get; set; }
        public static Room CurrentLocation { get; set; }
        public Weapon Equipt { get; set; }
        public static  Monster CurrentMonster { get; set; }
        public static NPC CurrentNPC { get; set; }
        #endregion

        /**
        * This is the constructor for the Player class. It accepts values to be assigned to the class variables
        * plus passing the current and max hit points to the LivingCreature class that the Player class is 
        * derived from so that the player can inherate these values.
        */
        #region Constructors
        public Player(string name, string PC, string PR, int gold, int currentHitPoints, int maximumHitPoints, Weapon equipt, bool isDead, bool canBeAttacked, Factions faction, int alignment)
            : base(currentHitPoints, maximumHitPoints, isDead, canBeAttacked, faction)
        {
            this.PlayerName = name;
            this.PlayerClass = PC;
            this.PlayerRace = PR;
            this.Gold = gold;
            this.ExperiencePoints = 0;
            this.AC = 10;
            this.CurrentHitPoints = currentHitPoints;
            this.MaxHitPoints = maximumHitPoints;
            this.Equipt = equipt;
            this.Alignment = alignment;
            Inventory = new List<InventoryItem>();
            Equipted = new Dictionary<string, IEquiptable>()
            {
                {"Head",null },
                {"Ears",null },
                {"Neck",null },
                {"Body",null },
                {"Back",null },
                {"Leg",null },
                {"Feet",null },
                {"Primary Hand",null },
                {"Off Hand",null }
            };
            CurrentLocation = World.Location[0];
        }
        #endregion

        #region Commented out XML section
        /** Need to do this from a DataBase
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

            XmlNode faction = playerData.CreateElement("Faction");
            faction.AppendChild(playerData.CreateTextNode(this.Factions.ToString()));
            stats.AppendChild(faction);

            XmlNode alignment = playerData.CreateElement("Alignment");
            alignment.AppendChild(playerData.CreateTextNode(this.Alignment.ToString()));
            stats.AppendChild(alignment);

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

        //public static Player CreatePlayerFromXmlString(string xmlPlayerData)
        //{
        //    try
        //    {
        //        XmlDocument playerData = new XmlDocument();

        //        playerData.LoadXml(xmlPlayerData);
        //        string playerName = playerData.SelectSingleNode("/Player/Stats/Name").InnerText;
        //        Console.WriteLine("Got name: " + playerName);
        //        string PC = playerData.SelectSingleNode("/Player/Stats/Class").InnerText;
        //        Console.WriteLine("Got class: " + PC);
        //        string PR = playerData.SelectSingleNode("/Player/Stats/Race").InnerText;
        //        Console.WriteLine("Got race: " + PR);
        //        int currentHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentHitPoints").InnerText);
        //        Console.WriteLine("Got current hit points: " + currentHitPoints.ToString());
        //        int maximumHitPoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/MaximumHitPoints").InnerText);
        //        Console.WriteLine("Got max hit points: " + maximumHitPoints.ToString());
        //        int gold = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/Gold").InnerText);
        //        Console.WriteLine("Got gold: " + gold.ToString());
        //        int experiencePoints = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/ExperiencePoints").InnerText);
        //        Console.WriteLine("Got experience: " + experiencePoints.ToString());
        //        int equiptString = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
        //        Console.WriteLine("Got equipt weapon: " + equiptString.ToString());
        //        Weapon equipt = World.WeaponByID(equiptString);

        //        Player player = new Player(playerName, PC, PR, gold, currentHitPoints, maximumHitPoints, equipt, false);
                

        //        int currentLocationID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentLocation").InnerText);
        //        CurrentLocation = World.LocationByID(currentLocationID);

        //        if (playerData.SelectSingleNode("/Player/Stats/CurrentWeapon") != null)
        //        {
        //            int currentWeaponID = Convert.ToInt32(playerData.SelectSingleNode("/Player/Stats/CurrentWeapon").InnerText);
        //            player.Equipt = World.WeaponByID(currentWeaponID);
        //        }

        //        foreach (XmlNode node in playerData.SelectNodes("/Player/InventoryItems/InventoryItem"))
        //        {
        //            int id = Convert.ToInt32(node.Attributes["ID"].Value);
        //            int quantity = Convert.ToInt32(node.Attributes["Quantity"].Value);

        //            if (id > 100 && id <= 200)
        //            {
        //                for (int i = 0; i < quantity; i++)
        //                {
        //                    player.AddItemToInventory(World.WeaponByID(id));
        //                }
        //            }
        //            else
        //            {
        //                for (int i = 0; i < quantity; i++)
        //                {
        //                    player.AddItemToInventory(World.ItemByID(id));
        //                }
        //            }
        //        }

        //        return player;
        //    }
        //    catch(Exception ex)
        //    {
        //        // If there was an error with the XML data, return a default player object
        //        //Console.WriteLine(ex.ToString());
        //        return CreateDefaultPlayer();
        //        //return null;
        //    }
        //}

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
        **/
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

            //RaiseInventoryChangedEvent(itemToAdd);
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
            IItem weapon = weaponToRemove;
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
                //RaiseInventoryChangedEvent(weaponToRemove);
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
                
    }
}


