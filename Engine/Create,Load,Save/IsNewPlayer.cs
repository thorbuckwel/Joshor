using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class IsNewPlayer
    {
        public static void NewPlayer()
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
                    Console.WriteLine("What is your name?");
                    userInput = Console.ReadLine();
                    Load.LoadGameData(userInput.ToLower());
                }
                else if (userInput.ToLower() == "yes")
                {
                    validAnswer = true;
                    CreatePlayer.CreatePlayerInst();
                }
                else
                {
                    Console.WriteLine("Not a valid answer.");
                }
            }
        }
    }
}
