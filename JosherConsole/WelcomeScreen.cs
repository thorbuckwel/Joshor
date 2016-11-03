using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using Engine;

namespace JosherConsole
{
    public class WelcomeScreen
    {
        public void Welcome()
        {
            Console.WriteLine("           ####################                 ");
            Console.WriteLine("           ####################                 ");
            Console.WriteLine("                   ###                        ##");
            Console.WriteLine("                   ###              #######   ##");
            Console.WriteLine("                   ###              ##   ##   ##");
            Console.WriteLine("                   ###     ####     ##        ##         ####     ##        ");
            Console.WriteLine("                   ###   ##    ##   #######   ######   ##    ##   ######    ");
            Console.WriteLine("                   ###  ##      ##       ##   ######  ##      ##  ###  #    ");
            Console.WriteLine("            ##########   ##    ##   ##   ##   ##  ##   ##    ##   ##        ");
            Console.WriteLine("            ##########     ####     #######   ##  ##     ####     ##        ");
            Console.WriteLine("________________________________________________________________________________");
            NewPlayer();

        }

        private void NewPlayer()
        {
            string userInput;
            bool validAnswer = false;

            while (validAnswer == false)
            {
                Console.WriteLine("Are you a new Player?");
                Console.Write("> ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "no")
                {
                    validAnswer = true;
                    LoadGameData();
                }
                else if (userInput.ToLower() == "yes")
                {
                    validAnswer = true;
                    CreatePlayer();
                }
                else
                {
                    Console.WriteLine("Not a valid answer.");
                }
            }
        }

        private void CreatePlayer()
        {
            String name;
            String className = "";
            String raceName = "";
            int gold = 0;
            int hp = 0;
            bool validRace = false;
            bool validClass = false;

            Console.WriteLine("Give me your name.");
            Console.Write("> ");
            name = Console.ReadLine();

            while (validClass == false)
            {
                Console.WriteLine("What class would you like to be?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Warrior, Mage, Thief > ");
                className = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.White;

                if (className == "warrior")
                {
                    gold = 100;
                    validClass = true;
                }
                else if (className == "mage")
                {
                    gold = 150;
                    validClass = true;
                }
                else if (className == "thief")
                {
                    gold = 200;
                    validClass = true;
                }
                else
                {
                    Console.WriteLine("Not a valid class");
                }
            }

            while (validRace == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("What race would you like?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Human, Elf, Dwarf > ");
                raceName = Console.ReadLine().ToLower();

                if (raceName == "human")
                {
                    validRace = true;
                    hp = 100;
                }
                else if (raceName == "elf")
                {
                    validRace = true;
                    hp = 80;
                }
                else if (raceName == "dwarf")
                {
                    validRace = true;
                    hp = 120;
                }
                else
                {
                    Console.WriteLine("Not a Valid entry.");
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
           Program._player = new Player(name, className, raceName, gold, hp, hp, World.WeaponByID(103), false);
            Console.WriteLine("Creating character data, please wait!");
            SaveGameData();
        }

        public static void LoadGameData()
        {

            if (Program._player == null)
            {
                if (File.Exists(Program.PLAYER_DATA_FILE_NAME))
                {
                    Program._player = null;
                    Program._player = Player.CreatePlayerFromXmlString(File.ReadAllText(Program.PLAYER_DATA_FILE_NAME));
                }
                else
                {
                    // _player = Player.CreateDefaultPlayer();
                }
            }
        }

        public void SaveGameData()
        {
            File.WriteAllText(Program.PLAYER_DATA_FILE_NAME, Program._player.ToXmlString());

            PlayerDataMapper.SaveToDatabase(Program._player);
        }
    }
}
