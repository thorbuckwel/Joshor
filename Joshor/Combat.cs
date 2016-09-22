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

            while (theMonster.IsDead != true && thePlayer.HasTakenFatalDamage != true)
            {
                combatResults += PlayerTurn(thePlayer, theMonster);

                if (theMonster.HasTakenFatalDamage)
                {
                    combatResults += "The creature is dead!" + Environment.NewLine;
                    thePlayer.xp += theMonster.Exp;
                    thePlayer.gold += theMonster.Gold;
                    break;
                }

                combatResults += MonsterTurn(thePlayer, theMonster);
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

        private static string PlayerTurn(Player thePlayer, Monster theMonster)
        {
            
            Dice chanceToAttack = new Dice(20);
            Dice damageDice = new Dice(6);
            int rollToBeatAC = chanceToAttack.Roll();

            //_attackResult = attack.DiceResult;
            string attackLog = "You attack with your " + thePlayer.equipt.name + Environment.NewLine;

            if (rollToBeatAC > theMonster.AC) //Tie goes to the defender?
            {
                //Do all the math and actual combat stuff
                int damageDealt = damageDice.Roll();
                theMonster.CurrentHitPoints -= damageDealt;

                /* Since its a hit, you know what the flavor text is going to be
                 * Separating it from the actual logic helps keep readability
 
                 * Example: you have a typo with what is being printed out? You know exactly where to look. */
                attackLog += "You hit the creature with a roll of: " + rollToBeatAC + Environment.NewLine;
                attackLog += "You did " + damageDealt + " points of damage." + Environment.NewLine;
                attackLog += theMonster.Name + " has " + theMonster.CurrentHitPoints + " hitpoints left" + Environment.NewLine;
            }
            else
            {
                attackLog += "You Missed your attack!" + Environment.NewLine;
            }

            return attackLog;
        }

        private static string MonsterTurn(Player thePlayer, Monster theMonster)
        {

            int rollToBeatAC = new Dice(20).Roll();

            string attackLog = theMonster.Name + "attemps to attack you." + Environment.NewLine;

            if (rollToBeatAC > thePlayer.ac)
            {
                int damageDealt = new Dice(6).Roll();
                thePlayer.CurrentHitPoints -= damageDealt;

                attackLog += "The creature hits you! (Your AC of: " + thePlayer.ac + " vs " + rollToBeatAC + ")" + Environment.NewLine;
                attackLog += "The creature did " + damageDealt + " points of damage." + Environment.NewLine;
                attackLog += "You have " + thePlayer.CurrentHitPoints + " hitpoints left." + Environment.NewLine;

            }
            else
            {
                attackLog += "The creature missed you!" + Environment.NewLine;
            }

            return attackLog;
        }
    }
}
