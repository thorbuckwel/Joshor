using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using Engine;



namespace JosherConsole
{
    public class Program
    {
        public const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";

        public static Player _player;
                
        private static void Main(string[] args)
        {
            #region Start
            Console.ForegroundColor = ConsoleColor.White;
            ListBuilder.Build();                // On load we need to call the ListBuilder to build all our List
            WelcomeScreen welcome = new WelcomeScreen();
            welcome.Welcome();


            Console.WriteLine("Type 'Help' to see a list of commands");
            Console.WriteLine("");

            DisplayCurrentLocation();

            // Connect player events to functions that will display in the UI
            _player.PropertyChanged += Player_OnPropertyChanged;
            _player.OnMessage += Player_OnMessage;
            #endregion

            #region While loop
            // Infinite loop, until the user types "exit"
            while (true)
            {
                // Display a prompt, so the user knows to type something
                Console.Write(_player.CurrentHitPoints + "/" + _player.MaximumHitPoints + " Hp" +" >");

                // Wait for the user to type something, and press the <Enter> key
                string userInput = Console.ReadLine();

                // If they typed a blank line, loop back and wait for input again
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    continue;
                }

                // Convert to lower-case, to make comparisons easier
                string cleanedInput = userInput.ToLower();

                // Save the current game data, and break out of the "while(true)" loop
                if (cleanedInput == "exit")
                {
                    //SaveGameData();

                    break;
                }

                // If the user typed something, try to determine what to do
                ParseInput(cleanedInput);
            }
        }
        #endregion

        #region Player PropertyChange, OnMessage
        private static void Player_OnPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "CurrentLocation")
            {
                DisplayCurrentLocation();               
            }
        }

        private static void Player_OnMessage(object sender, MessageEventArgs e)
        {
            Console.WriteLine(e.Message);

            if (e.AddExtraNewLine)
            {
                Console.WriteLine("");
            }
        }
        #endregion

        private static void ParseInput(string input)
        {
            #region Help
            if (input.Contains("help") || input == "?")
            {
                Console.WriteLine("Available commands");
                Console.WriteLine("====================================");
                Console.WriteLine("Stats - Display player information");
                Console.WriteLine("Score - Display player information");
                Console.WriteLine("Look - Get the description of your location");
                Console.WriteLine("Inventory - Display your inventory");
                Console.WriteLine("Quests - Display your quests");
                Console.WriteLine("Attack - Fight the monster");
                Console.WriteLine("Equip <weapon name> - Set your current weapon");
                Console.WriteLine("Drink <potion name> - Drink a potion");
                Console.WriteLine("Trade - display your inventory and vendor's inventory");
                Console.WriteLine("Buy <item name> - Buy an item from a vendor");
                Console.WriteLine("Sell <item name> - Sell an item to a vendor");
                Console.WriteLine("Drop <item name> - Drop an item");
                Console.WriteLine("North - Move North");
                Console.WriteLine("South - Move South");
                Console.WriteLine("East - Move East");
                Console.WriteLine("West - Move West");
                Console.WriteLine("Exit - Save the game and exit");
            }
            #endregion

            #region Stat, Score
            else if (input == "stats" || input == "score")
            {
                Console.WriteLine("Player Name: " + _player.PlayerName);
                Console.WriteLine("Player Class: " + _player.PlayerClass);
                Console.WriteLine("Player Race: " + _player.PlayerRace);
                Console.WriteLine("Current hit points: {0}", _player.CurrentHitPoints);
                Console.WriteLine("Maximum hit points: {0}", _player.MaximumHitPoints);
                Console.WriteLine("Experience Points: {0}", _player.ExperiencePoints);
                Console.WriteLine("Level: {0}", _player.Level);
                Console.WriteLine("Gold: {0}", _player.Gold);
            }
            #endregion

            #region Get
            else if (input.StartsWith("get ") || input.StartsWith("get"))
            {
                string inputItemName = input.Substring(4).Trim();

                if (string.IsNullOrEmpty(inputItemName))
                {
                    Console.WriteLine("You must enter the name of the item to get");
                }
                else
                {
                    if (inputItemName != null)
                    {
                        foreach (Item item in Player.CurrentLocation.RoomLoot.ToList())
                        {                            
                            if (item.Name.ToLower() == inputItemName)
                            {
                                if (item.ID > 200 && item.ID <= 300)
                                {
                                    _player.Inventory.Add(new InventoryItem(item, 1));
                                    Player.CurrentLocation.RoomLoot.Remove(item);
                                }
                                else if (item.ID > 100 && item.ID <= 200)
                                {
                                    Weapon weaponToGet =
                                        World.Weapons.SingleOrDefault(x => x.ID == item.ID);

                                    _player.Inventory.Add(new InventoryItem(new Weapon(weaponToGet.ID, weaponToGet.Name, weaponToGet.NamePlural, weaponToGet.Desc,
                                                            weaponToGet.Cost, weaponToGet.Damage, weaponToGet.DamageType, weaponToGet.Equiptable), 1));
                                    Player.CurrentLocation.RoomLoot.Remove(item);
                                }
                            }
                        }
                    }
                }
             }
            #endregion

            #region Look
            else if (input == "look")
            {
                DisplayCurrentLocation();
            }
            #endregion

            #region Move
            else if (input.Contains("north") || input.Contains("east") || input.Contains("south") || input.Contains("west"))
            {
                Move.MoveToNew(input);
                DisplayCurrentLocation();
                if (Move.canGo == false)
                {
                    Console.WriteLine("You can not go " + input);
                }
            }
            #endregion

            #region Inventory
            else if (input == "inventory" || input == "inv")
            {
                foreach (InventoryItem inventoryItem in _player.Inventory)
                {
                    Console.WriteLine("{0}: {1}", inventoryItem.Description, inventoryItem.Quantity);
                }
            }
            else if (input.Contains("attack") || input.Contains("kill"))
            {
                if (Player.CurrentLocation.RoomMob == null)
                {
                    Console.WriteLine("There is nothing here to attack");
                }
                else
                {
                    
                    //if (_player.Equipt == null)
                    //{
                    //    // Select the first weapon in the player's inventory 
                    //    // (or 'null', if they do not have any weapons)
                    //    _player.Equipt = _player. .FirstOrDefault();
                    //}

                    if (_player.Equipt == null)
                    {
                        Console.WriteLine("You do not have any weapons");
                    }
                    else
                    {
                        Combat fight = new Combat();
                        fight.Fight(_player.CurrentMonster, _player, _player.Equipt);
                        //_player.UseWeapon(_player.Equipt);
                    }
                }
            }
            #endregion

            #region Drop
            else if (input.StartsWith("drop ") || input.StartsWith("drop"))
            {
                string inputItemName = input.Substring(4).Trim();

                if (string.IsNullOrEmpty(inputItemName))
                {
                    Console.WriteLine("You must enter the name of the item to drop");
                }
                else
                {
                    Item itemToDrop = World.Items.SingleOrDefault(
                                       x => x.Name.ToLower() == inputItemName || x.NamePlural.ToLower() == inputItemName);
                    Weapon weaponToDrop = World.Weapons.SingleOrDefault(
                                       x => x.Name.ToLower() == inputItemName || x.NamePlural.ToLower() == inputItemName);

                    foreach (InventoryItem item in _player.Inventory.ToList())
                    {
                        if (item.Details.Name.ToLower() == inputItemName.ToString())
                        {
                            if (itemToDrop != null)
                            {
                                _player.RemoveItemFromInventory(itemToDrop, 1);
                                Player.CurrentLocation.RoomLoot.Add(itemToDrop);
                                Console.WriteLine("You drop {0}", inputItemName);
                            }
                            else if (weaponToDrop != null)
                            {
                                _player.RemoveItemFromInventory(weaponToDrop, 1);
                                Player.CurrentLocation.RoomLoot.Add(weaponToDrop);
                                Console.WriteLine("You drop {0}", inputItemName);
                            }
                        }
                        else if (item.Details.Name == null)
                        {
                            Console.WriteLine("You do not have the item {0}", inputItemName);
                        }
                    }
                }
                
            }
            #endregion

            #region Equip
            else if (input.StartsWith("equip ") || input.StartsWith("equip"))
            {
                string inputWeaponName = input.Substring(5).Trim();

                foreach (InventoryItem item in _player.Inventory.ToList())
                {
                    if (item.Details.Name.ToLower() == inputWeaponName.ToString())
                    {
                        if (string.IsNullOrEmpty(inputWeaponName))
                        {
                            Console.WriteLine("You must enter the name of the weapon to equip");
                        }
                        else
                        {
                            Weapon weaponToEquip =
                                World.Weapons.SingleOrDefault(
                                    x => x.Name.ToLower() == inputWeaponName || x.NamePlural.ToLower() == inputWeaponName);

                            if (weaponToEquip == null)
                            {
                                Console.WriteLine("You do not have the weapon: {0}", weaponToEquip);
                            }
                            else
                            {
                                _player.Inventory.Add(new InventoryItem(_player.Equipt, 1));
                                _player.Equipt = weaponToEquip;
                                _player.RemoveItemFromInventory(weaponToEquip, 1);
                                Console.WriteLine("You equip your {0}", weaponToEquip.Name.ToString());
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No such weapon in inventory");
                    }
                }
            }
            #endregion

            #region Save
            else if (input.StartsWith("save"))
            {
                WelcomeScreen welcome = new WelcomeScreen();
                welcome.SaveGameData();
            }
            else
            {
                Console.WriteLine("I do not understand");
                Console.WriteLine("Type 'Help' to see a list of available commands");
            }

            // Write a blank line, to keep the UI a little cleaner
            Console.WriteLine("");
        }
        #endregion

            #region DisplayCurrentLocation
        private static void DisplayCurrentLocation()
        {
            Console.WriteLine("You are at: {0}", Player.CurrentLocation.RoomName);

            if (Player.CurrentLocation.RoomDescript != "")
            {
                Console.WriteLine(Player.CurrentLocation.RoomDescript);
            }

            if (Player.CurrentLocation.RoomLoot != null)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                foreach (Item item in Player.CurrentLocation.RoomLoot)
                {
                    Console.WriteLine(item.Name);
                }                
                Console.ForegroundColor = ConsoleColor.White;
            }

            if (Player.CurrentLocation.RoomMob != null)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                foreach (Monster mob in Player.CurrentLocation.RoomMob)
                {                        
                    if (mob.ID != 5)
                    {
                        
                        _player.CurrentMonster = mob;
                        
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" A " + mob.Name + " is wondering around here.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        _player.CurrentMonster = mob;
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" A large " + mob.Name + " fills the room with its massive body.");
                        Console.ForegroundColor = ConsoleColor.White;
                    }                   
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        #endregion       
    }
}

