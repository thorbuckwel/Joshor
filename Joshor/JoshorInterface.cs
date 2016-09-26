using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class DungeonUI : Form
    {
        private static Combat _combatManager;
        private Monster theMonster;
        private Player thePlayer;                 // Create a player from the PLayer class    
        private int _previouslyEnteredRoomID;
        /**
         * There are several things that need to happen when the interface is initialized.
         * First we need to populate all our list by calling a ListBuilder class method. Then
         * we need to build a new player and populate the labels with the player's stats
         */
        public DungeonUI()
        {
            InitializeComponent();

            _combatManager = new Combat();

            ListBuilder.Build();                // On load we need to call the ListBuilder to build all out List
            // Creating a player object 
            thePlayer = new Player(
                name: "Killakia", 
                playerClass: "Warrior", 
                race: "Human", 
                gold: 100,
                maximumHitPoints: 10,
                currentlyEquippedWeapon: World.Weapons[2],
                armorClass: 10);

        }

        /**
         * On load we want to assign the player a starting location and then
         * display that locations information into the interface.
         */
        public void DungeonUI_Load(object sender, EventArgs e)
        {
            //Display Player Character Information
            lblDisplayPlayerName.Text = thePlayer.Name;
            lblDisplayPlayerRace.Text = thePlayer.Race;
            lblDisplayPlayerClass.Text = thePlayer.Class;
            lblDisplayLvl.Text = thePlayer.Level.ToString();
            lblDisplayGold.Text = thePlayer.Gold.ToString();
            lblDisplayExp.Text = thePlayer.ExperiencePoints.ToString();
            lblDisplayAC.Text = thePlayer.ArmorClass.ToString();
            lblDisplayHP.Text = thePlayer.CurrentHitPoints.ToString();
            cboWeapons.Text = thePlayer.EquippedWeapon.name.ToString();

            //Display the starting room's information in the UI
            thePlayer.MoveTo(0);
            UpdateUI(false);
        }

        /**
         * This method passes the monster that has been selected in the combo box. Then
         * calls a new form to display the monster's attributes.
         */
        public void btnEnemyView_Click(object sender, EventArgs e)
        {
            MonsterInfoWindow monsterWindow = new MonsterInfoWindow(this);
            monsterWindow.Show();
        }

        /// <summary>
        /// Moving north, we want to increase the roomIndex by 1
        /// </summary>
        private void btnNorth_Click(object sender, EventArgs e)
        {
            MovePlayer(1);
        }

        /// <summary>
        /// Moving south, we want to decrease the roomIndex by 1
        /// </summary>
        private void btnSouth_Click(object sender, EventArgs e)
        {
            MovePlayer(-1);
        }

        /// <summary>
        /// Move to and load the new room.
        /// </summary>
        private void MovePlayer(int directionToMoveIndex)
        {
            //Save the previous room for use when fleeing combat
            _previouslyEnteredRoomID = World.Location.IndexOf(thePlayer.CurrentLocation);

            int destinationRoomIndex = World.Location.IndexOf(thePlayer.CurrentLocation) + directionToMoveIndex;
            //Tell the player to move North/South
            thePlayer.MoveTo(destinationRoomIndex);
            //Update the UI
            UpdateUI(false);

            //Spawn Monsters
            if (thePlayer.CurrentLocation.Monsters != null)
            {
                SpawnMonsterInRoom();
            }
        }

        /// <summary>
        /// Helper function to handle updating the RichTextBox Location and ComboBox Enemies;
        /// and
        /// Checks each possible neighbor of the CurrentRoom, and enables the corresponding
        /// movement button if their is a neighbor in that direction.
        /// </summary>
        private void UpdateUI(bool fledCombat)
        {
            //Update flavor text:
            rtbLocation.Text = "";
            rtbLocation.Text += thePlayer.CurrentLocation.roomName + Environment.NewLine;
            rtbLocation.Text += thePlayer.CurrentLocation.roomDescript + Environment.NewLine;
            cboEnemies.Text = "";

            if (fledCombat)
            {
                rtbEnv.Text = "You have fled from battle.";
            }
            else
            {
                rtbEnv.Text = "";
            }

            //Enable buttons for exits
            btnNorth.Enabled = thePlayer.CurrentLocation.LocationToNorth;
            btnSouth.Enabled = thePlayer.CurrentLocation.LocationToSouth;
            btnEast.Enabled = thePlayer.CurrentLocation.LocationToEast;
            btnWest.Enabled = thePlayer.CurrentLocation.LocationToWest;
        }

        /// <summary>
        /// Helper function to handle the logic of updating Enemy flavor text, and spawning a random monster in the room
        /// </summary>
        private void SpawnMonsterInRoom()
        {
            int monsterIndex = (thePlayer.CurrentLocation.Monsters.ID != 5) ? RandomNumberGenerator.NumberBetween(0, 3) : 4;
            theMonster = new Monster(World.Monsters[monsterIndex]);

            if (monsterIndex != 4) //Need a better way to check if it is the dragon or not
            {
                cboEnemies.Text = theMonster.Name.ToString();
                rtbEnv.Text = "A " + theMonster.Name + " is wondering around here." + Environment.NewLine;
            }
            else
            {
                cboEnemies.Text = thePlayer.CurrentLocation.Monsters.Name;
                rtbEnv.Text = " A large " + thePlayer.CurrentLocation.Monsters.Name + " fills the room with its massive body." + Environment.NewLine;
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

        /// <summary>
        /// If the Up or Down arrow key is pressed down; check to see if the corresponding movement button is enabled.
        /// If true, allow the player to move in that direction.
        /// </summary>
        private void JoshorInterface_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && btnNorth.Enabled)
            {
                MovePlayer(1);
            }

            if (e.KeyCode == Keys.Down && btnSouth.Enabled)
            {
                MovePlayer(-1);
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
            string turnOfCombat = _combatManager.Fight(theMonster, thePlayer);

            if (_combatManager.RoundCounter == 1)
            {
                //Clear out the Environment RTB for new combat log
                rtbEnv.Text = turnOfCombat;
            }
            else
            {
                //Add the turn's results to the Environment combat log
                rtbEnv.Text += turnOfCombat;
            }
            

            //The callback for CurrentHitPoints being modified is not implemented
            //Remove this when it has been.
            lblDisplayHP.Text = thePlayer.CurrentHitPoints.ToString();

            if (theMonster.HasTakenFatalDamage || thePlayer.HasTakenFatalDamage)
            {
                //Combat has ended, display end of combat message 
                rtbEnv.Text += "The fight took " + _combatManager.RoundCounter + " rounds to finish." + Environment.NewLine;
                //Reset the round counter
                _combatManager.EndCombat();
                if (thePlayer.HasTakenFatalDamage)
                {
                    DeathScreen deathScreen = new DeathScreen();
                    deathScreen.Show();
                }
               if (theMonster.HasTakenFatalDamage)
                {
                    cboEnemies.Text = "";
                }
                
            }
        }


        //What is this used for?
        //Deprecated or important?
        //"timer1" is a very vague event name
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDisplayExp.Text = thePlayer.ExperiencePoints.ToString();
            lblDisplayLvl.Text = thePlayer.Level.ToString();
            lblDisplayGold.Text = thePlayer.Gold.ToString();
        }

        private void fleeButton_Click(object sender, EventArgs e)
        {
            if (thePlayer.HasTakenFatalDamage == false)
            {
                //Reset the round counter
                _combatManager.EndCombat();
                //If the player is still alive, let them flee to the previous room
                thePlayer.MoveTo(_previouslyEnteredRoomID);
                
                //Refresh the UI to reflect the new location
                UpdateUI(true);
            }
        }
    }
}
