using System;
using System.ComponentModel;
using System.Linq;
using System.IO;

namespace Engine
{
    internal class Combat
    {
        #region Fields
        private int _round;         // To keep track of the rounds
        private int _attackResult;  // To hold the value of the attack roll.
        private int _damageResult; // To hold the value of the damage roll.
        #endregion

        // Create the Combat Properties
        #region Properties
        public int Round { get { return _round; } set { _round = value; }}
        public int AttackResults { get { return _attackResult; }}
        public int DamageResults { get { return _damageResult; }}
        #endregion

        // Create a no arg constructor
        #region Constructor
        public Combat()
        {
            _round = 1;
        }
        #endregion

        /**
         * This method takes the Mob, player and weapon then runs a battle until one of them is dead.
         */
        public void Fight(Monster enemy, Player player)
        {

            // Create the Dice objects
            DiceRoll attack = new DiceRoll(1, 20);      //Repersents 1D20 die
            DiceRoll pDamage = new DiceRoll(player.Equipt.Damage);
            DiceRoll mobDamage = new DiceRoll(enemy.Damage);
            if (enemy.CanBeAttacked == false)
            {
                Console.WriteLine("Can't be attacked for whatever reason");
                return;
            }

            while (enemy.IsDead != true && player.IsDead != true)
            {
                _attackResult = attack.Roll();

                Console.WriteLine("Your attack with your " + player.Equipt.Name.ToString() + ": " + AttackResults);

                if (AttackResults >= enemy.AC)
                {
                    Console.WriteLine("You hit the " + enemy.Name);

                    _damageResult = pDamage.Roll();
                    Console.WriteLine("You did " + DamageResults + " points of damage.");

                    enemy.CurrentHitPoints -= DamageResults;
                    Console.WriteLine(enemy.Name + " has " + enemy.CurrentHitPoints + " hitpoints left");

                    if (enemy.CurrentHitPoints <= 0)
                    {
                        Console.WriteLine("The " + enemy.Name + " is dead!");
                        enemy.IsDead = true;
                        Console.WriteLine("The fight took " + Round + " rounds to finish.");
                        Player.CurrentLocation.RoomMob.Remove(enemy);
                        player.ExperiencePoints += enemy.Experiance;
                        player.Gold += enemy.Gold;
                        if(enemy.Factions == Factions.Evil)
                        {
                            player.Alignment++;
                        }
                        else if (enemy.Factions == Factions.Good)
                        {
                            player.Alignment--;
                        }
                            
                                
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You Missed your attack!");
                }

                _attackResult = attack.Roll();
                Console.WriteLine(enemy.Name + " attacks you: " + AttackResults);

                if (AttackResults > player.AC)
                {
                    Console.WriteLine("The " + enemy.Name + " hits you!");

                    _damageResult = mobDamage.Roll();
                    Console.WriteLine("The " + enemy.Name + " did " + DamageResults + " points of damage.");

                    player.CurrentHitPoints -= DamageResults;

                    if (player.CurrentHitPoints <= 0)
                    {
                        Console.WriteLine("You are dead!");                                                
                        player.IsDead = true;
                        Console.WriteLine("The fight took " + Round + " rounds to finish.\n");
                        Load.LoadGameData(player.PlayerName);
                        CurrentLocationClass.DisplayCurrentLocation();
                                         
                    }
                }
                else
                {
                    Console.WriteLine("The " + enemy.Name + " missed you!");
                }

                Round++;

            }

            //Console.WriteLine("The fight took " + Round + " rounds to finish.");
            if (player.IsDead == true)
            {
                player.PlayerName += "-Dead";
            }            
        }
    }
}