using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using JosherConsole;

namespace Engine
{
    public class Spawn
    {
        public static void WhatToSpawn()
        {
            Spawning spawn = new Spawning();
            //This gives the newly instantiated copy of the form
            //focus, instead of the console window    
            spawn.Show();
            spawn.Activate();
            Application.Run(spawn);            
        }       
    }
}
