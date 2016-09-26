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
        public int RoundCounter = 1;

        public string Fight(Monster theMonster, Player thePlayer)
        {

            string turnOfCombat = "";

            //These need to be decleared outside the loop, to prevent .Next() from
            //returning the same value; since System.Random's seed is based off of time
            //and the loop is resolving in > 1 second - resulting in 200+ rounds of the same
            //roles, until someone dies.
            Dice rollToHitAC = new Dice(20);
            Dice playerDamageDice = new Dice(thePlayer.EquippedWeapon.damage);

            turnOfCombat += PlayerTurn(thePlayer, theMonster, rollToHitAC, playerDamageDice);

            if (theMonster.HasTakenFatalDamage)
            {
                turnOfCombat += "The creature is dead!" + Environment.NewLine;
                thePlayer.ExperiencePoints += theMonster.Exp;
                thePlayer.Gold += theMonster.Gold;
                return turnOfCombat;
            }

            turnOfCombat += MonsterTurn(thePlayer, theMonster, rollToHitAC);


            if (thePlayer.HasTakenFatalDamage)
            {
                turnOfCombat += "You are dead!" + Environment.NewLine;
                return turnOfCombat;
            }

            turnOfCombat += Environment.NewLine;
            RoundCounter++;
            return turnOfCombat;    
        }

        //Work in progress on using a single method for combat
        //private static string Turn<T>(LivingCreature Attacker, LivingCreature Defender, Dice rollToHitAC) where T : LivingCreature
        //{
        //    int rollToBeatAC = rollToHitAC.Roll();
        //    int criticalHitMultipler = (rollToBeatAC == 20) ? 2 : 1; //Natural 20!
        //    string attackLog = "";

        //    if (rollToBeatAC > Defender.ArmorClass) //Tie goes to the defender?
        //    {
        //        //Deal damage to the Monster
        //        int damageDealt = Attacker.damageDice.Roll() * criticalHitMultipler;
        //        theMonster.CurrentHitPoints -= damageDealt;
        //        string crticial = (criticalHitMultipler == 2) ? " Critical Hit!" : "";
        //        //Update the Combat log
        //        attackLog += "You hit the " + theMonster.Name + "with your" + thePlayer.EquippedWeapon.ToString() + Environment.NewLine;
        //        attackLog += " (Roll: " + rollToBeatAC + " vs AC: " + theMonster.ArmorClass + ")" + Environment.NewLine;
        //        attackLog += "You did " + damageDealt + " points of damage." + crticial + Environment.NewLine;
        //        attackLog += theMonster.Name + " has " + theMonster.CurrentHitPoints + " hitpoints left" + Environment.NewLine;
        //    }
        //    else
        //    {
        //        attackLog += "You missed your attack! (Roll: " + rollToBeatAC + " vs AC: " + theMonster.ArmorClass + ")" + Environment.NewLine;
        //    }

        //    return attackLog;
        //}

        private static string PlayerTurn(Player thePlayer, Monster theMonster, Dice rollToHitAC, Dice damageDice)
        {
            
            int rollToBeatAC = rollToHitAC.Roll();
            int criticalHitMultipler = (rollToBeatAC == 20) ? 2 : 1; //Natural 20!
            string attackLog = "";

            if (rollToBeatAC > theMonster.ArmorClass) //Tie goes to the defender?
            {
                //Deal damage to the Monster
                int damageDealt = damageDice.Roll() * criticalHitMultipler;
                theMonster.CurrentHitPoints -= damageDealt;
                string crticial = (criticalHitMultipler == 2) ? " Critical Hit!" : "";
                //Update the Combat log
                attackLog += "You hit the " + theMonster.Name +  "with your"+ thePlayer.EquippedWeapon.ToString() + Environment.NewLine;
                attackLog += " (Roll: " + rollToBeatAC + " vs AC: " + theMonster.ArmorClass + ")" + Environment.NewLine;
                attackLog += "You did " + damageDealt + " points of damage." + crticial + Environment.NewLine;
                attackLog += theMonster.Name + " has " + theMonster.CurrentHitPoints + " hitpoints left" + Environment.NewLine;
            }
            else
            {
                attackLog += "You missed your attack! (Roll: " + rollToBeatAC + " vs AC: " + theMonster.ArmorClass + ")" + Environment.NewLine;
            }

            return attackLog;
        }

        private static string MonsterTurn(Player thePlayer, Monster theMonster, Dice rollToHitAC)
        {

            int rollToBeatAC = rollToHitAC.Roll();
            int criticalHitMultipler = (rollToBeatAC == 20) ? 2 : 1; //Natural 20!
            rollToBeatAC += theMonster.BaseHitChance;
            string attackLog = "";

            if (rollToBeatAC > thePlayer.ArmorClass)
            {
                //Deal damage to the player
                int damageDealt = theMonster.DamageDice.Roll() * criticalHitMultipler;
                thePlayer.CurrentHitPoints -= damageDealt;
                string crticial = (criticalHitMultipler == 2) ? " Critical Hit!" : "";
                //Update the combat log
                attackLog += "The "+ theMonster.Name +" hits you! (Roll: " + rollToBeatAC + " vs AC: " + thePlayer.ArmorClass + ")" + Environment.NewLine;
                attackLog += "The " + theMonster.Name + " did " + damageDealt + " points of damage."+ crticial + Environment.NewLine;
                attackLog += "You have " + thePlayer.CurrentHitPoints + " hitpoints left." + Environment.NewLine;
            }
            else
            {
                attackLog += "The " + theMonster.Name + " missed you! (Roll: " + rollToBeatAC + " vs AC: " + thePlayer.ArmorClass + ")" + Environment.NewLine;
            }

            return attackLog;
        }

        public void EndCombat()
        {
            RoundCounter = 1;
        }
    }
}
