using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class CreatePlayer
    {
        public static void CreatePlayerInst()
        {
            string name;
            string className = "";
            string raceName = "";
            Factions faction = Factions.Admin;
            int alignment = 0;
            int gold = 0;
            int hp = 0;
            bool validRace = false;
            bool validClass = false;
            bool validFaction = false;


            Console.WriteLine("Give me your name.");
            Console.Write("> ");
            name = CapWord.FirstCharToUpper(Console.ReadLine());

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

            while (validFaction == false)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("To what faction do you belong?");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Hero, Villion > ");
                string strFaction =  CapWord.FirstCharToUpper(Console.ReadLine());

                if (strFaction == Factions.Hero.ToString() || strFaction == Factions.Villain.ToString() || strFaction == Factions.Admin.ToString()) 
                {
                    faction = (Factions)Enum.Parse(typeof(Factions), strFaction, true);
                    validFaction = true;
                    
                }                
            }
        
            Console.ForegroundColor = ConsoleColor.White;
            Player._player = new Player(name, CapWord.FirstCharToUpper(className), CapWord.FirstCharToUpper(raceName), gold, hp, hp, (Weapon)World.WeaponByID(103), false, true, faction, alignment);
            Console.WriteLine("Creating character data, please wait!");
            SaveData.SaveGameData(Player._player);
            
        }

        public static void CreateFromLoad(Player loadPlayer)
        {
            Player _player = new Player(loadPlayer.PlayerName, loadPlayer.PlayerClass, loadPlayer.PlayerRace, loadPlayer.Gold, loadPlayer.CurrentHitPoints,
                                    loadPlayer.MaximumHitPoints, loadPlayer.Equipt, loadPlayer.IsDead, loadPlayer.CanBeAttacked, loadPlayer.Faction, loadPlayer.Alignment);
        }

    }
}
