using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace Joshor
{
    class Combat
    {
        private int _round;         // To keep track of the rounds
        private int _attackResult;  // To hold the value of the attack roll.
        private int _damageResult; // To hold the value of the damage roll.

        // Create the Combat Properties
        public int Round
        {
            get { return _round; }
            set { _round = value; }
        }

        public int AttackResults
        {
            get { return _attackResult; }
        }

        public int DamageResults
        {
            get { return _damageResult; }
        }

        // Create a no arg constructor
        public Combat()
        {
            _round = 1;
        }

        public void Fight(Monster enemy, Player player, Weapon equipt, JoshorInterface myInterface)
        {

            // Create the Dice objects
            Dice attack = new Dice(20);
            Dice damage = new Dice(6);

            while (enemy.IsDead != true && player.IsDead != true)
            {
                _attackResult = attack.DiceResult;

                myInterface.rtbEnv.Text += "Your attack with your " + myInterface.cboWeapons.Text + ": " + AttackResults +
                                            Environment.NewLine;

                if (AttackResults > enemy.AC)
                {
                    myInterface.rtbEnv.Text += "You hit the creature" + Environment.NewLine;
                  

                    _damageResult = damage.DiceResult;
                    myInterface.rtbEnv.Text += "You did " + DamageResults + " points of damage." + Environment.NewLine;
                                        
                    enemy.CurrentHitPoints -= DamageResults;
                    myInterface.rtbEnv.Text += enemy.Name + " has " + enemy.CurrentHitPoints + " hitpoints left" 
                                                + Environment.NewLine;
                    

                    if (enemy.CurrentHitPoints <= 0)
                    {
                        myInterface.rtbEnv.Text += "The creature is dead!" + Environment.NewLine;
                        enemy.IsDead = true;
                        break;
                    }
                }
                else
                {
                    myInterface.rtbEnv.Text += "You Missed your attack!" + Environment.NewLine;
                }

                _attackResult = attack.DiceResult;
                myInterface.rtbEnv.Text += "Creature attacks you: " + AttackResults + Environment.NewLine;
                
                if (AttackResults > player.ac)
                {
                    myInterface.rtbEnv.Text += "The creature hits you!" + Environment.NewLine;
                    
                    _damageResult = damage.DiceResult;
                    myInterface.rtbEnv.Text += "The creature did " + DamageResults + " points of damage."
                                                + Environment.NewLine;
                    
                    player.CurrentHitPoints -= DamageResults;
                    myInterface.rtbEnv.Text += "You have " + player.CurrentHitPoints + " hitpoints left." + Environment.NewLine;
                    myInterface.lblDisplayHP.Text = player.CurrentHitPoints.ToString();
                    
                    if (player.CurrentHitPoints <= 0)
                    {
                        myInterface.rtbEnv.Text += "You are dead!" + Environment.NewLine;
                        player.IsDead = true;
                        break;
                    }
                }
                else
                {
                    myInterface.rtbEnv.Text += "The creature missed you!" + Environment.NewLine;
                }

                Round++;

            }

            myInterface.rtbEnv.Text += "The fight took " + Round + " rounds to finish." + Environment.NewLine;            
        }
    }
}
