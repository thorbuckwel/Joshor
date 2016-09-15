using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Engine;



namespace Joshor
{
    public partial class JoshorInterface : Form
    {
        public JoshorInterface()
        {
            InitializeComponent();
        }

        private void JoshorInterface_Load(object sender, EventArgs e)
        {

            ListBuilder.Build();

            foreach(Monster mob in World.Monsters)
            {
                rtbEnv.Text += mob.name + Environment.NewLine;
            }

            foreach(Weapon weapon in World.Weapons)
            {
                rtbEnv.Text += weapon.name + Environment.NewLine;
            }
        }
    }
}
