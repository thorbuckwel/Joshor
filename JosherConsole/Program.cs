using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using Engine;
using System.Timers;

namespace JosherConsole
{
    public class Program
    {        
        private static void Main(string[] args)
        {
            #region Start
            Console.ForegroundColor = ConsoleColor.White;
            ListBuilder.Build();                // On load we need to call the ListBuilder to build all our List
            WelcomeScreen welcome = new WelcomeScreen();
            welcome.Welcome();


            Console.WriteLine("Type 'Help' to see a list of commands");
            Console.WriteLine("");

            CurrentLocationClass.DisplayCurrentLocation();

            // Connect player events to functions that will display in the UI
            //_player.PropertyChanged += Player_OnPropertyChanged;
            //_player.OnMessage += Player_OnMessage;
            #endregion

            #region While loop
            // Infinite loop, until the user types "exit"

            //Run timer every 5 minutes (300,000 millisec's) for autosave feature
            System.Timers.Timer autoSave = new System.Timers.Timer();
            autoSave.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            autoSave.Interval = 60000;
            autoSave.Enabled = true;
            while (true)
            {
                // Display a prompt, so the user knows to type something
                Console.Write(Player._player.CurrentHitPoints + "/" + Player._player.MaximumHitPoints + " Hp" +" >");                

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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Saving character, will close when finished!");
                    SaveData.SaveGameData(Player._player);

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
                CurrentLocationClass.DisplayCurrentLocation();               
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
            // Call the command class to figure out what to do.
            Command.CommandCase(input, Player._player);

            // Write a blank line, to keep the UI a little cleaner
            Console.WriteLine("");
        }

        /**
         * This method will save player data everytime there is a tick for it.
         */
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            SaveData.SaveGameData(Player._player);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Autosaving, Please wait!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Player._player.CurrentHitPoints + "/" + Player._player.MaximumHitPoints + " Hp" + " >");
        }
    }
}


