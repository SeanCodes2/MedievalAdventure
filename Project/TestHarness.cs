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
            int playerWin = 0;
            int foeWin = 0;
            for (int i = 0; i < 10; i++)
            {
                Player testUser = new Player("Test Player", CharacterClass.Balanced, 50, 50, 60, 0, Weapon.GetWeapon(0), Shield.GetShield(0), 50, 0, 0);
                //Adversary testAdversary = FoeSewer.GetSewerFoe();
                //Adversary testAdversary = FoeSwamp.GetSwampFoe();
                //Adversary testAdversary = FoeForestRoad.GetForestRoadFoe();
                //Adversary testAdversary = FoeGraveyard.GetGraveyardFoe();
                Adversary testAdversary = FoeCastle.GetCastleFoe();
                //Adversary testAdversary = FoeMtnPass.GetMtnPassFoe();

                Console.WriteLine(testUser);
                Console.WriteLine(testUser.EquippedWeapon);
                Console.WriteLine(testUser.EquippedShield);
                Console.WriteLine();
                Console.WriteLine(testAdversary);
                //Console.ReadKey();
                while (testUser.Life > 0 && testAdversary.Life > 0)
                {
                    Combat.DoBattle(testUser, testAdversary);
                    Console.WriteLine(testUser.Life + " " + testAdversary.Life);
                }
                if (testUser.Life <= 0)
                {
                    foeWin++;
                }
                else
                {
                    playerWin++;
                }
                //Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine($"\nPlayer: {playerWin}   Foe: {foeWin}");

            //Location currentRoom = new Location();
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine(currentRoom.RoomMap());
            //Console.ResetColor();
        }
    }
}
