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

            _player = new Player("Killakia", "Warrior", "Human", 100, 10, 10);  // Creating a player object 

            /**
             * Displaying the players stats int the stat group
             */
            lblDisplayPlayerName.Text = _player.playerName;
            lblDisplayPlayerRace.Text = _player.playerRace;
            lblDisplayPlayerClass.Text = _player.playerClass;
            lblDisplayLvl.Text = _player.lvl.ToString();
            lblDisplayGold.Text = _player.gold.ToString();
            lblDisplayExp.Text = _player.xp.ToString();
            lblDisplayAC.Text = _player.ac.ToString();
            lblDisplayHP.Text = _player.CurrentHitPoints.ToString();
            


        }

        public void JoshorInterface_Load(object sender, EventArgs e)
        {

            ListBuilder.Build();                // On load we need to call the ListBuilder to build all out List
            _player.CurrentLocation = World.Location[0];

            /**
             * The following is just test code to see if our other code is working
             */
            foreach (Monster mob in World.Monsters)
            {
                cboEnemies.Items.Add(mob.name);
            }

            foreach(Weapon weapon in World.Weapons)
            {
                cboWeapons.Items.Add(weapon.name);

            }

            rtbLocation.Text += _player.CurrentLocation.roomName + Environment.NewLine;
            rtbLocation.Text += _player.CurrentLocation.roomDescript + Environment.NewLine;            
        }

        
        public void btnEnemyView_Click(object sender, EventArgs e)
        {
            MobInterface mobInter = new MobInterface(this);
            mobInter.Show();
        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            _player.MoveNorth();
            rtbLocation.Text = "";
            rtbLocation.Text += _player.CurrentLocation.roomName + Environment.NewLine;
            rtbLocation.Text += _player.CurrentLocation.roomDescript + Environment.NewLine;
            Exits(_player);
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            _player.MoveSouth(-1);
            rtbLocation.Text += _player.CurrentLocation.roomName + Environment.NewLine;
            rtbLocation.Text += _player.CurrentLocation.roomDescript + Environment.NewLine;
            
        }

        public void Exits(Player location)
        {
            if (_player.CurrentLocation.LocationToNorth != true)
            {
                if(_player.CurrentLocation.LocationToEast != true)
                {
                    if(_player.CurrentLocation.LocationToSouth != true)
                    {
                        if(_player.CurrentLocation.LocationWest != true)
                        {
                            btnWest.Visible = false;
                        }
                        else
                        {
                            btnWest.Visible = true;
                        }

                        btnSouth.Visible = false;
                    }
                    else
                    {
                        btnSouth.Visible = true;
                    }
                    btnEast.Visible = false;
                }
                else
                {
                    btnEast.Visible = true;
                }
                btnNorth.Visible = false;
            }
            else
            {
                btnNorth.Visible = true;
            }
        }
    }
}
