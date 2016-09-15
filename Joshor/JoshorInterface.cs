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
        private Player _player;

        public JoshorInterface()
        {
            InitializeComponent();

            _player = new Player("Killakia", "Warrior", "Human", 100);

            lblDisplayPlayerName.Text = _player.playerName;
            lblDisplayPlayerRace.Text = _player.playerRace;
            lblDisplayPlayerClass.Text = _player.playerClass;
            lblDisplayLvl.Text = _player.lvl.ToString();
            lblDisplayGold.Text = _player.gold.ToString();
            lblDisplayExp.Text = _player.xp.ToString();
            lblDisplayAC.Text = _player.ac.ToString();


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

            foreach (Room Location in World.Location)
            {
                rtbLocation.Text += Location.roomName + Environment.NewLine;
            }
        }
    }
}
