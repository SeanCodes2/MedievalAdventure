using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureLibrary;
using AdversaryLibrary;

namespace Project
{
    public class TestHarness
    {
        static void Main(string[] args)
        {
            Player testUser = new Player("Test Player", CharacterClass.Balanced, 50, 50, 60, 0, Weapon.GetWeapon(4), Shield.GetShield(1), 50, 0, 0);
            Adversary testAdversary = FoeCastle.GetCastleFoe();

            Console.WriteLine(testUser);
            Console.WriteLine(testUser.EquippedWeapon);
            Console.WriteLine(testUser.EquippedShield);
            Console.WriteLine();
            Console.WriteLine(testAdversary);
            Console.ReadKey();
            while (testUser.Life > 0 && testAdversary.Life > 0 )
            {
            Combat.DoBattle(testUser, testAdversary);
                Console.WriteLine(testUser.Life + " " + testAdversary.Life);

            }
        }
    }
}
