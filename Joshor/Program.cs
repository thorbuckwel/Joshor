using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Joshor
{
    static class Program
    {
        private static JoshorInterface Game;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Game = new JoshorInterface();
            Application.Run(Game);
        }

        public static void Restart()
        {
            Game = new JoshorInterface();
            Game.Show();
                       
        }        
    }
}
