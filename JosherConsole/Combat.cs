using System;
using System.ComponentModel;
using System.Linq;
using System.IO;
using Engine;

namespace JosherConsole
{
    internal class Combat
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

        public void Fight(Monster enemy, Player player, Weapon equipt)
        {

            // Create the Dice objects
            Dice attack = new Dice(20);
            Dice damage = new Dice(6);

            while (enemy.IsDead != true && player.IsDead != true)
            {
                _attackResult = attack.DiceResult;

                Console.WriteLine("Your attack with your " + player.Equipt + ": " + AttackResults);

                if (AttackResults >= enemy.AC)
                {
                    Console.WriteLine("You hit the " + enemy.Name);

                    _damageResult = damage.DiceResult;
                    Console.WriteLine("You did " + DamageResults + " points of damage.");

                    enemy.CurrentHitPoints -= DamageResults;
                    Console.WriteLine(enemy.Name + " has " + enemy.CurrentHitPoints + " hitpoints left");

                    if (enemy.CurrentHitPoints <= 0)
                    {
                        Console.WriteLine("The " + enemy.Name + " is dead!");
                        enemy.IsDead = true;
                        player.ExperiencePoints += enemy.Experiance;
                        player.Gold += enemy.Gold;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("You Missed your attack!");
                }

                _attackResult = attack.DiceResult;
                Console.WriteLine(enemy.Name + " attacks you: " + AttackResults);

                if (AttackResults > player.AC)
                {
                    Console.WriteLine("The " + enemy.Name + " hits you!");

                    _damageResult = damage.DiceResult;
                    Console.WriteLine("The " + enemy.Name + " did " + DamageResults + " points of damage.");

                    player.CurrentHitPoints -= DamageResults;

                    if (player.CurrentHitPoints <= 0)
                    {
                        Console.WriteLine("You are dead!");
                        player.IsDead = true;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("The " + enemy.Name + " missed you!");
                }

                Round++;

            }

            Console.WriteLine("The fight took " + Round + " rounds to finish.");
        }
    }
}