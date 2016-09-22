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
        private Player _player;                 // Create a player from the PLayer class    

        /**
         * There are several things that need to happen when the interface is initialized.
         * First we need to populate all our list by calling a ListBuilder class method. Then
         * we need to build a new player and populate the labels with the player's stats
         */
        public JoshorInterface()
        {
            InitializeComponent();

            ListBuilder.Build();                // On load we need to call the ListBuilder to build all out List
            _player = new Player("Killakia", "Warrior", "Human", 100, 10, 10, World.Weapons[2], false);  // Creating a player object 

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
            cboWeapons.Text = _player.equipt.name.ToString();            
        }

        /**
         * On Interface load we want to assign the player a starting location and then
         * display that locations information into the interface.
         */
        public void JoshorInterface_Load(object sender, EventArgs e)
        {
            
            _player.CurrentLocation = World.Location[0];            

            rtbLocation.Text += _player.CurrentLocation.roomName + Environment.NewLine;
            rtbLocation.Text += _player.CurrentLocation.roomDescript + Environment.NewLine;            
        }

        /**
         * This method passes the monster that has been selected in the combo box. Then
         * calls a new form to display the monster's attributes.
         */
        public void btnEnemyView_Click(object sender, EventArgs e)
        {
            MobInterface mobInter = new MobInterface(this);
            mobInter.Show();
        }

        /**
         * When the North button is click We call the MoveNorth method in the player 
         * object to set the players current location to the next room north 
         */
        private void btnNorth_Click(object sender, EventArgs e)
        {
            _player.MoveNorth();
            rtbLocation.Text = "";
            rtbLocation.Text += _player.CurrentLocation.roomName + Environment.NewLine;
            rtbLocation.Text += _player.CurrentLocation.roomDescript + Environment.NewLine;
            Exits(_player);
            Monster inhab;
            
            if(_player.CurrentLocation.Monsters != null)
            {
                if (_player.CurrentLocation.Monsters.ID != 5)
                {
                    inhab = World.Monsters[RandomNumberGenerator.NumberBetween(0, 3)];
                    cboEnemies.Text = inhab.name.ToString();
                    rtbEnv.Text = "A " + inhab.name + " is wondering around here." + Environment.NewLine;
                }
                else
                {
                    cboEnemies.Text = _player.CurrentLocation.Monsters.name;
                    rtbEnv.Text = " A large " + _player.CurrentLocation.Monsters.name + " fills the room with its massive body." +
                                    Environment.NewLine;
                }
            }
            else
            {
                cboEnemies.Text = "";
            }
                       
        }

        /**
         * When the South button is click We call the MoveNorth method in the player 
         * object to set the players current location to the next room south 
         */
        private void btnSouth_Click(object sender, EventArgs e)
        {
            _player.MoveSouth();
            rtbLocation.Text = "";
            rtbLocation.Text += _player.CurrentLocation.roomName + Environment.NewLine;
            rtbLocation.Text += _player.CurrentLocation.roomDescript + Environment.NewLine;
            Exits(_player);
            Monster inhab;

            if (_player.CurrentLocation.Monsters != null)
            {
                if (_player.CurrentLocation.Monsters.ID != 5)
                {
                    inhab = World.Monsters[RandomNumberGenerator.NumberBetween(0, 3)];
                    cboEnemies.Text = inhab.name.ToString();
                    rtbEnv.Text = "A " + inhab.name + " is wondering around here." + Environment.NewLine;

                }
                else
                {
                    cboEnemies.Text = _player.CurrentLocation.Monsters.name;
                    rtbEnv.Text = " A large " + _player.CurrentLocation.Monsters.name + " fills the room with its massive body." +
                                        Environment.NewLine;
                }               
            }
            else
            {
                cboEnemies.Text = "";
            }
        }

        /**
         *  This method recieves an argument so it can check if the new room has exits.
         *  if the the exit holds the bool true then it will turn on the button for that
         *  direction. If not then the button is not enabled.
         */
        public void Exits(Player location)
        {
            if (_player.CurrentLocation.LocationToNorth != true)
            {
                btnNorth.Visible = false;
            }
            else
            {
                btnNorth.Visible = true;
            }
            if (_player.CurrentLocation.LocationToEast != true)
            {
                btnEast.Visible = false;
            }
            else
            {
                btnEast.Visible = true;
            }
            if (_player.CurrentLocation.LocationToSouth != true)
            {
                btnSouth.Visible = false;
            }
            else
            {
                btnSouth.Visible = true;
            }
            if (_player.CurrentLocation.LocationToWest != true)
            {
                btnWest.Visible = false;
            }
            else
            {
                btnWest.Visible = true;
            }
        }

        /**
         * When the view button is pressed if there is a weapon in the combo box then
         * we pull up the weapon interface to get the weapons stats. 
         */
        private void btnInspectWeapon_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<WeaponInterface>().Count() == 1)
            {

            }
            else
            {
                WeaponInterface weaponInterface = new WeaponInterface(this);
                weaponInterface.Show();
            }
        }

        /**
         * This was a test to see if we could move through the rooms using just the up 
         * arrow. It does work however it needs inprovements.
         */
        private void JoshorInterface_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                _player.MoveNorth();
                rtbLocation.Text = "";
                rtbLocation.Text += _player.CurrentLocation.roomName + Environment.NewLine;
                rtbLocation.Text += _player.CurrentLocation.roomDescript + Environment.NewLine;
                Exits(_player);

            }
        }

        /**
         *  When the Attack with button is attack we assign a copy of both the mob and 
         *  the weapon into thier own varaible. Then we create a new combat object to
         *  resolve the battle. Into the new combat object we pass the enemy, weapon,
         *  and this interface so that the combat object can make changes to the
         *  interface.
         */
        private void btnAttack_Click(object sender, EventArgs e)
        {
            Monster enemy = World.Monsters.First(item => item.name == cboEnemies.Text);
            Weapon equipt = World.Weapons.First(item => item.name == cboWeapons.Text);
            Combat fight = new Combat();
            fight.Fight(enemy, _player, equipt, this);
            if (enemy.isDead == true)
            {
                cboEnemies.Text = "";
            }

            if (_player.CurrentHitPoints <= 0)
            {
                DeathScreen deathScreen = new DeathScreen();
                deathScreen.Show();
            }
        }        
    }
}
