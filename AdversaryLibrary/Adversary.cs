using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdversaryLibrary
{
    public class Adversary : Character
    {
        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }


        public Adversary()
        {
            Name = "No Adversary Here";

        }
        public Adversary(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block) : base(name, maxLife, life, hitChance, block)
        {
            MaxDmg = maxDmg;
            MinDmg = minDmg;
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDmg, MaxDmg + 1);
        }

        public override string ToString()
        {
            return $"No Adversary Here";
        }

        public static void AttackMenu(ref Location currentRoom, Player user, ref int userScore, ref bool encounterLoop, Adversary adversary, ref bool newMonster)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Console.Write("Choose Your Next Move:\n" +
               "\tUpArrow - Move North\n" +
               "\tRightArrow - Move East\n" +
               "\tDownArrow - Move South\n" +
               "\tLeftArrow - Move West\n\n" +
               "\tA. Attack\n" +
               "\tR. Run Away\n" +
               "\tP. Player Info\n" +
               "\tM. Monster Info\n" +
               "\tE. Exit\n\n\n");

            ConsoleKey choice = Console.ReadKey(true).Key;
            /*Console.Clear();*/

            switch (choice)
            {
                case ConsoleKey.UpArrow:
                    MoveAttack(user, adversary, diceRoll);
                    Location.MoveNorth(ref currentRoom);
                    newMonster = true;
                    break;
                case ConsoleKey.RightArrow:
                    MoveAttack(user, adversary, diceRoll);
                    Location.MoveEast(ref currentRoom);
                    newMonster = true;
                    break;
                case ConsoleKey.DownArrow:
                    MoveAttack(user, adversary, diceRoll);
                    Location.MoveSouth(ref currentRoom);
                    newMonster = true;
                    break;
                case ConsoleKey.LeftArrow:
                    MoveAttack(user, adversary, diceRoll);
                    Location.MoveWest(ref currentRoom);
                    newMonster = true;
                    break;
                case ConsoleKey.A:
                    
                    Console.WriteLine("Attack!");
                    //handle winning (reload) and losing (exit)
                    Combat.DoBattle(user, adversary);
                    if (adversary.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\nYou killed {adversary.Name}!");
                        Console.Beep(700, 500);
                        Console.ResetColor();
                        Console.WriteLine($"\nYou collect 3 gold.");
                        userScore++;
                        user.Gold = user.Gold + 3;
                        encounterLoop = false; //get a new room and monster
                        newMonster = true;
                    }
                    if (user.Life <= 0)
                    {
                        Console.WriteLine("Dude.... you Died!\a");
                        Console.WriteLine($"Number of Victories: {userScore}");
                        //adventureLoop = false;
                        encounterLoop = false;
                    }
                    Console.ReadKey(true);
                    Console.Clear();
                    break;
                case ConsoleKey.R:

                    if (diceRoll < user.EscapeChance)
                    {
                        //Console.WriteLine("You Try to Run Away...");
                        Combat.DoAttack(adversary, user);
                        Console.WriteLine($"{adversary.Name} attacks you as you flee...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("You Run Away....");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    newMonster = true;
                    break;
                case ConsoleKey.P:
                    Console.Clear();
                    Console.WriteLine(user);
                    Console.WriteLine($"Adversaries Defeated: {userScore}\n");
                    Console.WriteLine(user.EquippedWeapon);
                    Console.WriteLine(user.EquippedShield);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.M:
                    Console.Clear();
                    Console.WriteLine(adversary);
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case ConsoleKey.E:
                case ConsoleKey.Escape:
                    //adventureLoop = false;
                    encounterLoop = false;
                    newMonster = true;

                    Console.WriteLine("\n\nNoone Likes a Quitter!\n\n");
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Unknown Command - Please try again.");
                    break;
            }//end switch
        }

        public static void MoveAttack(Player user, Adversary adversary, int diceRoll)
        {
            if (diceRoll > user.EscapeChance)
            {
                Console.WriteLine($"{adversary.Name} attacks you as you flee...\n");
                Combat.DoAttack(adversary, user);
                Console.WriteLine("\n(continue)");
                Console.ReadKey();

            }
        }


    }
}
