using AdventureLibrary;
using AdversaryLibrary;
using System.Reflection.Metadata;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowHeight = 60;
            Console.WindowWidth = 140;

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"

                          ______________________________________
                         //                                     \\
                       <<            MEDIEVAL ADVENTURE           >>
                         \\_____________________________________//

");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(@"
                                                o         _ _ _ _ _
                                           _----|         I-I-I-I-I
                        _ _ _ _ _ _      o  ----|     o   \~~`~'~~/
                        ]-I-I-I-I-[ _----|      |_----|    |.    |
                        \~`\~~~/'~/  ----|     / \----|    |  /^\|
                         [*] ' __|       ^    / ^ \   ^    |_ |*||
                         |__    ,|      / \  /    `\ / \   |  ===|
                       __|  ___ ,|__   /    /=_=_=_=\   \  |,  __|
                       I_I__I_I__I_I  (====(_________)___|_|_____|___
                       \-\--|-|--/-/  |'    I~~[ ]~~I I_I__|IIII|_I_l
                        | [ ]    '|   | [~] |_`_~_ _[  \-\--|-|--/-/
                        |.   | |' |___|____`I_I_|_I_I___|---------|
                       / \| [] ~ .|_|-|_|-|-|_|-|_|-|_|-| []   [] |
                      <===>  |  ~.|-=-=-=-=-=-=-=-=-=-=-|~  |  ~ / \
                      | []|`   []~||.|.|.|.|.|.|.|.|.|.||-~   ~ <===>
                      | []| ` |   |/////////I\\\\\\\\\\||__. ~| |[*]I
                      <===> ~   ' ||||| |   |   | ||||.||  []  ~<===>
                       \T/  |~|-- ||||| | O | O | ||||.|| . |'~  \T/
                        |     ~.~_||||| |~~~|~~~| ||||.|| | ~   | |
                  __.../|' v . | .|||||/____|____\|||| /|. . | . .|\.\/_

");

            #region Player Choosing Name
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\n\t\tHello Adventurer! What is your name??\n\n\t\t");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            #region Player Choosing Class            
            bool scope = true;
            int userInput = 0;
            while (scope)
            {
                Console.Write("\n\t\tPlease select a class:\n\n" +
                    "\t\t1. Balanced\t\tNo Change\n" +
                    "\t\t2. Dexer\t\tHitchance +10 | MaxLife -5\n" +
                    "\t\t3. Tank\t\t\tBlock +5 | MaxLife +10 | HitChance -5 | EscapeChance -10\n" +
                    "\t\t4. Berzerker\t\tDamage +5 | Block -10 | EscapeChance -10\n" +
                    "\t\t5. Peasant:\t\tBlock -3 | EscapChance -3 | HitChance -3 | MaxLife -10\n\t\t");

                bool success = int.TryParse(Console.ReadLine(), out userInput);
                if (userInput < 6 && userInput > 0 && success)
                {
                    scope = false;
                }
                Console.Clear();
            }

            CharacterClass playerClass = Player.GetClass(userInput);
            #endregion

            Weapon userWeapon = Weapon.GetWeapon(0);
            Shield userShield = Shield.GetShield(0);
            Location currentRoom = Location.GetRoomById(0);
            Player user = new Player(name, playerClass, 50, 50, 60, 0, userWeapon, userShield, 40, 0, 40);
            int userScore = 0;

            Console.Clear();
            Console.WriteLine($"\n\n\n\n\n\n\n\n\n\t\tWelcome {user.Name} the {user.PlayerClass}! Your Adventure Awaits!\n" +
                $"\t\tThis is Where The story begins!!!\n" +
                $"\t\tThe Story Continues\n\n" +
                $"\t\t(press any button)");
            Console.ReadKey(true);
            Console.Clear();
            Console.ResetColor();
                   
            bool encounterLoop = true;
            do
            {
                ConsoleKey menuChoice;

                #region Adversary Switch
                Adversary adversary = new Adversary();
                switch (currentRoom.ID)
                {
                    case 0:
                        adversary = new Adversary();
                        break;
                    case 1:
                        adversary = FoeForestRoad.GetForestRoadFoe();
                        break;
                    case 2:
                        adversary = FoeSewer.GetSewerFoe();
                        break;
                    case 3:
                        adversary = new Adversary();
                        break;
                    case 4:
                    case 5:
                        adversary = FoeForestRoad.GetForestRoadFoe();
                        break;
                    case 6:
                        adversary = FoeCastle.GetCastleFoe();
                        break;
                    case 7:
                        adversary = FoeSwamp.GetSwampFoe();
                        break;
                    case 8:
                    case 9:
                        adversary = FoeForestRoad.GetForestRoadFoe();
                        break;
                    case 10:
                        adversary = FoeSwamp.GetSwampFoe();
                        break;
                    case 11:
                    case 12:
                        adversary = FoeForestRoad.GetForestRoadFoe();
                        break;
                    case 13:
                        adversary = FoeGraveyard.GetGraveyardFoe();
                        break;
                    case 14:
                        adversary = FoeMtnPass.GetMtnPassFoe();
                        break;
                    case 15:
                        adversary = FoeForestRoad.GetForestRoadFoe();
                        break;
                    //case 16:
                    //case 17:
                    default:
                        adversary = new Adversary();
                        break;
                }
                #endregion

                bool newMonster = false;
                while (!newMonster)
                {
                    Console.WriteLine(@$"{currentRoom.Art}");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(currentRoom.RoomMap());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"\nWelcome to the {currentRoom} - ");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine($"{currentRoom.Description}\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Current Adversary: {adversary.Name}\n");
                    Console.ResetColor();
                    
                    if (currentRoom.ID == 0)
                    {
                        menuChoice = Location.InnMenu(ref currentRoom, user, ref encounterLoop, ref newMonster);
                    }                    
                    else if (currentRoom.ID == 3)
                    {
                        menuChoice = Location.ProvisionerMenu(ref currentRoom, user, userScore, ref encounterLoop, ref newMonster);
                    }                   
                    else
                    {
                        Adversary.AttackMenu(ref currentRoom, user, ref userScore, ref encounterLoop, adversary, ref newMonster);
                    }                   
                }
            } while (encounterLoop );
            

        }//End Main()    





    }//End Class
}//End Namespace