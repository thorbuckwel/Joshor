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
            string userInput;                   // To hold the user's input.
            bool validAnswer = false;           // This will stay false until the user's answers yes or no.

            /**
             * This loop will stay going until a valid answer is recieved from 
             * the user.
             */
            while (validAnswer == false)
            {
                Console.WriteLine("Are you a new Player?");
                Console.Write("> ");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "no")
                {
                    validAnswer = true;
                    Console.WriteLine("What is your name?");
                    userInput = CapWord.FirstCharToUpper(Console.ReadLine());
                    Load.LoadGameData(userInput.ToLower());         // Go to the Load class and exacute the LoadGame method.
                }
                else if (userInput.ToLower() == "yes")
                {
                    validAnswer = true;
                    CreatePlayer.CreatePlayerInst();                // Go to CreatePlayer and exacute the CreatePlayerInst method. 
                }
                else
                {
                    Console.WriteLine("Not a valid answer.");
                }
            }
        }
    }
}
