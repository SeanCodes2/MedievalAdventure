using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdversaryLibrary
{
    public class Combat
    {
        //this class will not have any fields props or constructors
        //just a method warehouse for combat

        public static void DoAttack(Character attacker, Character defender)
        {
            //get a random number 1-100  as our dice roll.
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            Thread.Sleep(300);//1000 is one second
            if (diceRoll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //we Hit!
                //Calculate damage and save to variable
                int damageDealt = attacker.CalcDamage();

                defender.Life -= damageDealt;

                //Write result                
                Console.ForegroundColor = ConsoleColor.Red;
                //Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }//end if
            else
            {
                //attack missed!
                Console.WriteLine($"{attacker.Name} missed!");
            }//end else
        }

        public static void DoBattle(Player player, Adversary adversary)
        {
            //player attacks first
            DoAttack(player, adversary);
            //moster attacks second if alive
            if (adversary.Life > 0)
            {
                DoAttack(adversary, player);
            }
        }

        public static void TryEscape(Character adversary,Player player)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);

            if (diceRoll < player.EscapeChance)
            {
                Console.WriteLine($"{adversary.Name} Attacks you as you travel");
                Combat.DoAttack(adversary,player);
                Console.ReadKey();
            }
        }
    }
}
