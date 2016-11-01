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
    public partial class JoshorInterface : Form
    {
    //    Monster inhab;
    //    private Player _player;                 // Create a player from the PLayer class    

    //    /**
    //     * There are several things that need to happen when the interface is initialized.
    //     * First we need to populate all our list by calling a ListBuilder class method. Then
    //     * we need to build a new player and populate the labels with the player's stats
    //     */
    //    public JoshorInterface()
    //    {
    //        InitializeComponent();

    //        ListBuilder.Build();                // On load we need to call the ListBuilder to build all out List
    //        //_player = new Player("Killakia", "Warrior", "Human", 100, 10, 10, World.Weapons[2], false);  // Creating a player object 
    //        _player = Player.CreateDefaultPlayer();
    //        /**
    //         * Displaying the players stats int the stat group
    //         */
    //        lblDisplayPlayerName.Text = _player.PlayerName;
    //        lblDisplayPlayerRace.Text = _player.PlayerRace;
    //        lblDisplayPlayerClass.Text = _player.PlayerClass;
    //        lblDisplayLvl.Text = _player.Level.ToString();
    //        lblDisplayGold.Text = _player.Gold.ToString();
    //        lblDisplayExp.Text = _player.ExperiencePoints.ToString();
    //        lblDisplayAC.Text = _player.AC.ToString();
    //        lblDisplayHP.Text = _player.CurrentHitPoints.ToString();
    //        cboWeapons.Text = _player.Equipt.Name.ToString();            
    //    }

    //    /**
    //     * On Interface load we want to assign the player a starting location and then
    //     * display that locations information into the interface.
    //     */
    //    public void JoshorInterface_Load(object sender, EventArgs e)
    //    {
            
    //        Player.CurrentLocation = World.Location[0];            

    //        rtbLocation.Text += Player.CurrentLocation.RoomName + Environment.NewLine;
    //        rtbLocation.Text += Player.CurrentLocation.RoomDescript + Environment.NewLine;            
    //    }

    //    /**
    //     * This method passes the monster that has been selected in the combo box. Then
    //     * calls a new form to display the monster's attributes.
    //     */
    //    public void btnEnemyView_Click(object sender, EventArgs e)
    //    {
    //        MobInterface mobInter = new MobInterface(this);
    //        mobInter.Show();
    //    }

    //    /**
    //     * When the North button is click We call the MoveNorth method in the player 
    //     * object to set the players current location to the next room north 
    //     */
    //    private void btnNorth_Click(object sender, EventArgs e)
    //    {
    //        Move.MoveTo;
    //        rtbLocation.Text = "";
    //        rtbLocation.Text += _player.CurrentLocation.RoomName + Environment.NewLine;
    //        rtbLocation.Text += _player.CurrentLocation.RoomDescript + Environment.NewLine;
    //        Exits(_player);            
            
    //        if(_player.CurrentLocation.Monsters != null)
    //        {
    //            if (_player.CurrentLocation.Monsters.ID != 5)
    //            {
    //                inhab = new Monster(World.Monsters[RandomNumberGenerator.NumberBetween(0, 3)]);
    //                cboEnemies.Text = inhab.Name.ToString();
    //                rtbEnv.Text = "A " + inhab.Name + " is wondering around here." + Environment.NewLine;
    //            }
    //            else
    //            {
    //                inhab = new Monster(World.Monsters[4]);
    //                cboEnemies.Text = _player.CurrentLocation.Monsters.Name;
    //                rtbEnv.Text = " A large " + _player.CurrentLocation.Monsters.Name + " fills the room with its massive body." +
    //                                Environment.NewLine;
    //            }
    //        }
    //        else
    //        {
    //            cboEnemies.Text = "";
    //        }
                       
    //    }

    //    /**
    //     * When the South button is click We call the MoveNorth method in the player 
    //     * object to set the players current location to the next room south 
    //     */
    //    private void btnSouth_Click(object sender, EventArgs e)
    //    {
    //        _player.MoveSouth();
    //        rtbLocation.Text = "";
    //        rtbLocation.Text += _player.CurrentLocation.RoomName + Environment.NewLine;
    //        rtbLocation.Text += _player.CurrentLocation.RoomDescript + Environment.NewLine;
    //        Exits(_player);
    //        Monster inhab;

    //        if (_player.CurrentLocation.Monsters != null)
    //        {
    //            if (_player.CurrentLocation.Monsters.ID != 5)
    //            {
    //                inhab = new Monster(World.Monsters[RandomNumberGenerator.NumberBetween(0, 3)]);
    //                cboEnemies.Text = inhab.Name.ToString();
    //                rtbEnv.Text = "A " + inhab.Name + " is wondering around here." + Environment.NewLine;

    //            }
    //            else
    //            {
    //                cboEnemies.Text = _player.CurrentLocation.Monsters.Name;
    //                rtbEnv.Text = " A large " + _player.CurrentLocation.Monsters.Name + " fills the room with its massive body." +
    //                                    Environment.NewLine;
    //            }               
    //        }
    //        else
    //        {
    //            cboEnemies.Text = "";
    //        }
    //    }

    //    /**
    //     *  This method recieves an argument so it can check if the new room has exits.
    //     *  if the the exit holds the bool true then it will turn on the button for that
    //     *  direction. If not then the button is not enabled.
    //     */
    //    public void Exits(Player location)
    //    {
    //        if (_player.CurrentLocation.LocationToNorth != -1)
    //        {
    //            btnNorth.Visible = false;
    //        }
    //        else
    //        {
    //            btnNorth.Visible = true;
    //        }
    //        if (_player.CurrentLocation.LocationToEast != -1)
    //        {
    //            btnEast.Visible = false;
    //        }
    //        else
    //        {
    //            btnEast.Visible = true;
    //        }
    //        if (_player.CurrentLocation.LocationToSouth != -1)
    //        {
    //            btnSouth.Visible = false;
    //        }
    //        else
    //        {
    //            btnSouth.Visible = true;
    //        }
    //        if (_player.CurrentLocation.LocationToWest != -1)
    //        {
    //            btnWest.Visible = false;
    //        }
    //        else
    //        {
    //            btnWest.Visible = true;
    //        }
    //    }

    //    /**
    //     * When the view button is pressed if there is a weapon in the combo box then
    //     * we pull up the weapon interface to get the weapons stats. 
    //     */
    //    private void btnInspectWeapon_Click(object sender, EventArgs e)
    //    {
    //        if (Application.OpenForms.OfType<WeaponInterface>().Count() == 1)
    //        {

    //        }
    //        else
    //        {
    //            WeaponInterface weaponInterface = new WeaponInterface(this);
    //            weaponInterface.Show();
    //        }
    //    }

    //    /**
    //     * This was a test to see if we could move through the rooms using just the up 
    //     * arrow. It does work however it needs inprovements.
    //     */
    //    private void JoshorInterface_KeyDown(object sender, KeyEventArgs e)
    //    {
    //        if (e.KeyCode == Keys.Up)
    //        {
    //            _player.MoveNorth();
    //            rtbLocation.Text = "";
    //            rtbLocation.Text += _player.CurrentLocation.RoomName + Environment.NewLine;
    //            rtbLocation.Text += _player.CurrentLocation.RoomDescript + Environment.NewLine;
    //            Exits(_player);

    //        }
    //    }

    //    /**
    //     *  When the Attack with button is attack we assign a copy of both the mob and 
    //     *  the weapon into thier own varaible. Then we create a new combat object to
    //     *  resolve the battle. Into the new combat object we pass the enemy, weapon,
    //     *  and this interface so that the combat object can make changes to the
    //     *  interface.
    //     */
    //    private void btnAttack_Click(object sender, EventArgs e)
    //    {          
            
            
    //        //Add a null check for stupidty reasons
                       
    //        Weapon equipt = World.Weapons.First(item => item.Name == cboWeapons.Text);
    //        Combat fight = new Combat();
    //        fight.Fight(inhab, _player, equipt, this);
    //        if (inhab.IsDead == true)
    //        {
    //            cboEnemies.Text = "";
    //        }

    //        if (_player.CurrentHitPoints <= 0)
    //        {
    //            DeathScreen deathScreen = new DeathScreen();
    //            deathScreen.Show();
    //        }
    //    }

    //    private void timer1_Tick(object sender, EventArgs e)
    //    {
    //        lblDisplayExp.Text = _player.ExperiencePoints.ToString();
    //        lblDisplayLvl.Text = _player.Level.ToString();
    //        lblDisplayGold.Text = _player.Gold.ToString();
    //    }
        
    }
}
