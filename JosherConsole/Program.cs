using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using Engine;
using System.Timers;
using System.Diagnostics;


namespace JosherConsole
{
    public class Program
    {        
        private static void Main(string[] args)
        {
            #region Start
            Console.ForegroundColor = ConsoleColor.White;       // The text will be White.
            ListBuilder.Build();                                // On load we need to call the ListBuilder to build all our List
            World.message = new Alert(AlertPlayer, AlertPlayerWrite);
            WelcomeScreen welcome = new WelcomeScreen();        // Create a new welcome screen
            welcome.Welcome();                                  // Call that screen.


            World.message.SetMessage("Type 'Help' to see a list of commands");
            World.message.SetMessage("");

            //Run timer every 5 minutes (300,000 millisec's) for autosave feature
            System.Timers.Timer autoSave = new System.Timers.Timer();
            autoSave.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            autoSave.Interval = 300000;
            autoSave.Enabled = true;
            #endregion

            CurrentLocationClass.DisplayCurrentLocation();
            World.message.SetMessage("");

            #region While loop
            // Infinite loop, until the user types "exit"
            while (true)
            { 
                // Display a prompt, so the user knows to type something
                Console.Write(Player._player.CurrentHitPoints + "/" + Player._player.MaxHitPoints + " Hp" +" >");                

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
                    World.message.SetMessage("Saving character, will close when finished!");
                    SaveData.SaveGameData(Player._player);
                    break;
                }

                // If the user typed something, try to determine what to do
                ParseInput(cleanedInput);
            }
        }
        #endregion

        public static void AlertPlayer(string message)
        {
            Console.WriteLine(message);
        }

        public static void AlertPlayerWrite(string message)
        {
            Console.Write(message);
        }

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
            World.message.SetMessage(e.Message);

            if (e.AddExtraNewLine)
            {
                World.message.SetMessage("");
            }
        }
        #endregion

        private static void ParseInput(string input)
        {
            // Call the command class to figure out what to do.
            Command.CommandCase(input, Player._player);

            // Write a blank line, to keep the UI a little cleaner
            World.message.SetMessage("");
        }

        /**
         * This method will save player data everytime there is a tick for it.
         */
        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            SaveData.SaveGameData(Player._player);
            Console.ForegroundColor = ConsoleColor.Red;
            World.message.SetMessage("Autosaving, Please wait!");
            Console.ForegroundColor = ConsoleColor.White;
            World.message.SetMessage($"{Player._player.CurrentHitPoints}/{Player._player.MaximumHitPoints} Hp > ");
        }
    }
}


