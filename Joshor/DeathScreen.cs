using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace Joshor
{
    public partial class DeathScreen : Form
    {
        JoshorInterface JoshorInterface; //Allows this form to interact with the parent form
        public DeathScreen()
        {
            InitializeComponent();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Program.Restart();
            this.Dispose(false);
            this.Close();

               
        }

        private void btnExitGame_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
