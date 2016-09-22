using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joshor
{
    static class Program
    {
        private static DungeonUI Game;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Game = new DungeonUI();
            Application.Run(Game);
        }

        public static void Restart()
        {
            Game = new DungeonUI();
            Game.Show();
                       
        }        
    }
}
