using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using Engine;



namespace JosherConsole
{
    public class Program
    {
        private const string PLAYER_DATA_FILE_NAME = "PlayerData.xml";

        private static Player _player;

        private static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            ListBuilder.Build();                // On load we need to call the ListBuilder to build all our List
            WelcomeScreen welcome = new WelcomeScreen();
            welcome.Welcome();
            CreatePlayer();
            // Load the player
            // LoadGameData();


            Console.WriteLine("Type 'Help' to see a list of commands");
            Console.WriteLine("");

            DisplayCurrentLocation();

            // Connect player events to functions that will display in the UI
            _player.PropertyChanged += Player_OnPropertyChanged;
            _player.OnMessage += Player_OnMessage;

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

        private static void ParseInput(string input)
        {
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
            else if (input == "look")
            {
                DisplayCurrentLocation();
            }
            else if (input.Contains("north"))
            {
                if (_player.CurrentLocation.LocationToNorth == -1)
                {
                    Console.WriteLine("You cannot move North");
                }
                else
                {
                    _player.MoveNorth();
                    DisplayCurrentLocation();
                }
            }
            else if (input.Contains("east"))
            {
                if (_player.CurrentLocation.LocationToEast == -1)
                {
                    Console.WriteLine("You cannot move East");
                }
                else
                {
                    _player.MoveEast();
                    DisplayCurrentLocation();
                }
            }
            else if (input.Contains("south"))
            {
                if (_player.CurrentLocation.LocationToSouth == -1)
                {
                    Console.WriteLine("You cannot move South");
                }
                else
                {
                    _player.MoveSouth();
                    DisplayCurrentLocation();
                }
            }
            else if (input.Contains("west"))
            {
                if (_player.CurrentLocation.LocationToWest == -1)
                {
                    Console.WriteLine("You cannot move West");
                }
                else
                {
                    _player.MoveWest();
                    DisplayCurrentLocation();
                }
            }
            else if (input == "inventory" || input == "inv")
            {
                foreach (InventoryItem inventoryItem in _player.Inventory)
                {
                    Console.WriteLine("{0}: {1}", inventoryItem.Description, inventoryItem.Quantity);
                }
            }
            else if (input.Contains("attack") || input.Contains("kill"))
            {
                if (_player.CurrentLocation.Monsters == null)
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
                    if (itemToDrop == null || weaponToDrop == null)
                    {
                        Console.WriteLine("You do not have the item {0}", inputItemName);
                    }
                    else
                    {                        
                        
                        _player.RemoveItemFromInventory(itemToDrop, 1);
                        _player.RemoveItemFromInventory(weaponToDrop, 1);
                        Console.WriteLine("You drop {0}", inputItemName);
                    }

                }
            }
            else if (input.StartsWith("equip ") || input.StartsWith("equip"))
            {
                string inputWeaponName = input.Substring(6).Trim();

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
                        Console.WriteLine("You do not have the weapon: {0}", inputWeaponName);
                    }
                    else
                    {
                        
                        _player.Inventory.Add(new InventoryItem( _player.Equipt, 1));
                        _player.RemoveItemFromInventory(_player.Equipt, 1);
                        Console.WriteLine("You equip your {0}", _player.Equipt.Name);
                    }
                }
            }
            else
            {
                Console.WriteLine("I do not understand");
                Console.WriteLine("Type 'Help' to see a list of available commands");
            }

            // Write a blank line, to keep the UI a little cleaner
            Console.WriteLine("");
        }

        private static void DisplayCurrentLocation()
        {
            Console.WriteLine("You are at: {0}", _player.CurrentLocation.RoomName);

            if (_player.CurrentLocation.RoomDescript != "")
            {
                Console.WriteLine(_player.CurrentLocation.RoomDescript);
            }

            if (_player.CurrentLocation.Monsters != null)
            {
                Monster inhab;
                if (_player.CurrentLocation.Monsters.ID != 5)
                {

                    inhab = new Monster(World.Monsters[RandomNumberGenerator.NumberBetween(0, 3)]);
                    _player.CurrentMonster = inhab;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" A " + inhab.Name + " is wondering around here.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    inhab = new Monster(World.Monsters[4]);
                    _player.CurrentMonster = inhab;
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" A large " + _player.CurrentLocation.Monsters.Name + " fills the room with its massive body.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }      

        private static void CreatePlayer()
        {
            String name;
            String className;
            String raceName;        
            Console.WriteLine("Give me your name.");
            Console.Write("> ");
            name = Console.ReadLine();
            Console.WriteLine("What class would you like to be?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Warrior, Mage, Thief > ");
            className = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("What race would you like?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Human, Elf, Dwarf > ");
            raceName = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            _player = new Player(name, className, raceName, 100, 100, 100, World.WeaponByID(103), false);

        }

        //    private static void LoadGameData()
        //    {
        //        _player = PlayerDataMapper.CreateFromDatabase();

        //        if (_player == null)
        //        {
        //            if (File.Exists(PLAYER_DATA_FILE_NAME))
        //            {
        //                _player = Player.CreatePlayerFromXmlString(File.ReadAllText(PLAYER_DATA_FILE_NAME));
        //            }
        //            else
        //            {
        //                _player = Player.CreateDefaultPlayer();
        //            }
        //        }
        //    }

        //private static void SaveGameData()
        //{
        //    File.WriteAllText(PLAYER_DATA_FILE_NAME, _player.ToXmlString());

        //    PlayerDataMapper.SaveToDatabase(_player);
        //}
    }
}

