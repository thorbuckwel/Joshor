using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using Engine;

namespace Engine
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
            IsNewPlayer.NewPlayer();            // Next determine if they are a new player.
        }    
    }
}
 