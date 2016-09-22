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

        public static string Fight(Monster theMonster, Player thePlayer)
        {
            string combatResults = "";
            int roundCounter = 1; // To keep track of the rounds

            //These need to be decleared outside the loop, to prevent .Next() from
            //returning the same value; since System.Random's seed is based off of time
            //and the loop is resolving in > 1 second - resulting in 200+ rounds of the same
            //roles, until someone dies.
            Dice rollToHitAC = new Dice(20);
            Dice playerDamageDice = new Dice(thePlayer.EquippedWeapon.damage);

            while (!theMonster.HasTakenFatalDamage && !thePlayer.HasTakenFatalDamage)
            {
                combatResults += PlayerTurn(thePlayer, theMonster, rollToHitAC, playerDamageDice);

                if (theMonster.HasTakenFatalDamage)
                {
                    combatResults += "The creature is dead!" + Environment.NewLine;
                    thePlayer.ExperiencePoints += theMonster.Exp;
                    thePlayer.Gold += theMonster.Gold;
                    break;
                }

                combatResults += MonsterTurn(thePlayer, theMonster, rollToHitAC);
                //activeUI.lblDisplayHP.Text = thePlayer.CurrentHitPoints.ToString();
                //As long as combat is done in one continous loop, the player will never
                //see their HP change as each round progresses.

                if (thePlayer.HasTakenFatalDamage)
                {
                    combatResults += "You are dead!" + Environment.NewLine;
                    break;
                }
                combatResults += Environment.NewLine;
                roundCounter++; //Is this used?
            }

            combatResults += "The fight took " + roundCounter + " rounds to finish." + Environment.NewLine;
            return combatResults;    
        }

        private static string PlayerTurn(Player thePlayer, Monster theMonster, Dice rollToHitAC, Dice damageDice)
        {
            
            int rollToBeatAC = rollToHitAC.Roll();
            string attackLog = "You attack with your " + thePlayer.EquippedWeapon.name + Environment.NewLine;

            if (rollToBeatAC > theMonster.ArmorClass) //Tie goes to the defender?
            {
                //Deal damage to the Monster
                int damageDealt = damageDice.Roll();
                theMonster.CurrentHitPoints -= damageDealt;

                //Update the Combat log
                attackLog += "You hit the creature! (Roll: " + rollToBeatAC + " vs AC: " + theMonster.ArmorClass + ")" + Environment.NewLine;
                attackLog += "You did " + damageDealt + " points of damage." + Environment.NewLine;
                attackLog += theMonster.Name + " has " + theMonster.CurrentHitPoints + " hitpoints left" + Environment.NewLine;
            }
            else
            {
                attackLog += "You Missed your attack! (Roll: " + rollToBeatAC + " vs AC: " + theMonster.ArmorClass + ")" + Environment.NewLine;
            }

            return attackLog;
        }

        private static string MonsterTurn(Player thePlayer, Monster theMonster, Dice rollToHitAC)
        {

            int rollToBeatAC = rollToHitAC.Roll();
            string attackLog = theMonster.Name + " attemps to attack you." + Environment.NewLine;

            if (rollToBeatAC > thePlayer.ArmorClass)
            {
                //Deal damage to the player
                int damageDealt = theMonster.DamageDice.Roll();
                thePlayer.CurrentHitPoints -= damageDealt;

                //Update the combat log
                attackLog += "The creature hits you! (Roll: " + rollToBeatAC + " vs AC: " + thePlayer.ArmorClass + ")" + Environment.NewLine;
                attackLog += "The creature did " + damageDealt + " points of damage." + Environment.NewLine;
                attackLog += "You have " + thePlayer.CurrentHitPoints + " hitpoints left." + Environment.NewLine;
            }
            else
            {
                attackLog += "The creature missed you! (Roll: " + rollToBeatAC + " vs AC: " + thePlayer.ArmorClass + ")" + Environment.NewLine;
            }

            return attackLog;
        }
    }
}
