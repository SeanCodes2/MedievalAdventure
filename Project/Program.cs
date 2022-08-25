using AdventureLibrary;
using AdversaryLibrary;
using System.Reflection.Metadata;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nMedieval Adventure\n\n");

            #region Player Choosing Name
            Console.WriteLine("Hello Adventurer! What is your name??\n");
            string name = Console.ReadLine();
            #endregion

            #region Player Choosing Class            
            bool scope = true;
            int userInput = 0;
            while (scope)
            {
                Console.Write("\nPlease select a class:\n\n" +
                    "1. Balanced\t\tNo Change\n" +
                    "2. Dexer\t\tHitchance +10 | MaxLife -5\n" +
                    "3. Tank\t\t\tBlock +5 | MaxLife +10 | HitChance -5 | EscapeChance -10\n" +
                    "4. Berzerker\t\tDamage +5 | Block -10 | EscapeChance -10\n" +
                    "5. Peasant:\t\tBlock -3 | EscapChance -3 | HitChance -3 | MaxLife -10\n");

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
            Player user = new Player(name, playerClass, 50, 50, 60, 0, userWeapon, userShield, 50, 0, 40);

            Console.Clear();

            Console.WriteLine($"\n\n\nWelcome {user.Name}! Your Adventure Awaits!\n" +
                $"This is Where The story begins!!!\n" +
                $"The Story Continues\n\n" +
                $"(press any button)");
            Console.ReadKey(true);
            Console.Clear();

            bool adventureLoop = true;
            do
            {

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
                        Console.ForegroundColor = ConsoleColor.Green;
                                                
                        Console.WriteLine(currentRoom.RoomMap());

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\nWelcome to the {currentRoom} - {currentRoom.Description}\n");

                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Current Adversary: {adversary.Name}\n");
                        Console.ResetColor();

                        #region Inn Menu
                        if (currentRoom.ID == 0)
                        {
                            menuChoice = Location.InnMenu(ref currentRoom, user, ref adventureLoop, ref encounterLoop, ref newMonster);
                        }
                        #endregion

                        #region Provisioner Menu
                        else if (currentRoom.ID == 3)
                        {
                            Console.Write("\nMake Your Next Move:\n\n" +
                                "\tUpArrow - Move North\n" +
                                "\tRightArrow - Move East\n" +
                                "\tDownArrow - Move South\n" +
                                "\tLeftArrow - Move West\n" +
                                "\tS. - Shop\n" +
                                "\tP. - Player Info\n" +
                                "\tE. - Exit\n\n");

                            menuChoice = Console.ReadKey(true).Key;

                            switch (menuChoice)
                            {
                                case ConsoleKey.UpArrow:
                                    Location.MoveNorth(ref currentRoom);
                                    newMonster = true;
                                    break;
                                case ConsoleKey.RightArrow:
                                    Location.MoveEast(ref currentRoom);
                                    newMonster = true;
                                    break;
                                case ConsoleKey.DownArrow:
                                    Location.MoveSouth(ref currentRoom);
                                    newMonster = true;
                                    break;
                                case ConsoleKey.LeftArrow:
                                    Location.MoveWest(ref currentRoom);
                                    newMonster = true;
                                    break;
                                case ConsoleKey.S:
                                    Console.Clear();
                                    Console.WriteLine($"\n\nGold Available: {user.Gold}\n");
                                    Console.WriteLine($"Current wares available:\n\n" +
                                        $"1. (10 Gold) Dagger {Weapon.GetWeapon(1)}\n" +
                                        $"2. (15 Gold) Katana {Weapon.GetWeapon(2)}\n" +
                                        $"3. (20 Gold) Spear {Weapon.GetWeapon(3)}\n" +
                                        $"4. (25 Gold) Mace {Weapon.GetWeapon(4)}\n" +
                                        $"5. (10 Gold) Buckler Shield{Shield.GetShield(1)}\n" +
                                        $"6. (25 Gold) Kite Shield {Shield.GetShield(2)}\n" +
                                        $"7. (40 Gold) Heater Shield {Shield.GetShield(3)}\n" +
                                        $"8. (15 Gold) Bandage (restores 15 lift)" +
                                        $"\n" +
                                        $"E. Exit Store");
                                    ConsoleKey shopChoice = Console.ReadKey(true).Key;
                                    Items.ShopChoice(user, shopChoice);
                                    break;
                                case ConsoleKey.P:
                                    Console.Clear();
                                    Console.WriteLine(user);
                                    Console.WriteLine(user.EquippedWeapon);
                                    Console.WriteLine(user.EquippedShield);
                                    break;
                                case ConsoleKey.E:
                                case ConsoleKey.Escape:
                                    Console.WriteLine("\n\nNoone Likes a Quitter!\n\n");
                                    Console.Clear();
                                    adventureLoop = false;
                                    encounterLoop = false;
                                    newMonster = true;
                                    break;
                                default:
                                    Console.WriteLine("Unknown Command - Please try again.");
                                    break;
                            }//end switch
                        }
                        #endregion

                        #region Attack Menu
                        else
                        {
                            Random rand = new Random();
                            int diceRoll = rand.Next(1, 101);
                            Console.Write("Choose Your Next Move:\n" +
                               "\tUpArrow - Move North\n" +
                               "\tRightArrow - Move East\n" +
                               "\tDownArrow - Move South\n" +
                               "\tLeftArrow - Move West\n" +
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
                                    Location.MoveNorth(ref currentRoom);
                                    newMonster = true;
                                    break;
                                case ConsoleKey.RightArrow:
                                    Location.MoveEast(ref currentRoom);
                                    newMonster = true;
                                    break;
                                case ConsoleKey.DownArrow:
                                    Location.MoveSouth(ref currentRoom);
                                    newMonster = true;
                                    break;
                                case ConsoleKey.LeftArrow:
                                    Location.MoveWest(ref currentRoom);
                                    newMonster = true;
                                    break;
                                case ConsoleKey.A:
                                    Console.Clear();
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
                                        user.Gold = user.Gold + 3;
                                        encounterLoop = false; //get a new room and monster
                                        newMonster = true;
                                    }
                                    if (user.Life <= 0)
                                    {
                                        Console.WriteLine("Dude.... you Died!\a");
                                        adventureLoop = false;
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
                                        newMonster = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You Run Away....");
                                        Console.ReadKey();
                                        newMonster = true;
                                    }
                                    break;
                                case ConsoleKey.P:
                                    Console.Clear();
                                    Console.WriteLine(user);
                                    Console.WriteLine(user.EquippedWeapon);
                                    Console.WriteLine(user.EquippedShield);
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.M:
                                    Console.Clear();
                                    Console.WriteLine(adversary);
                                    Console.ReadKey();
                                    break;
                                case ConsoleKey.E:
                                case ConsoleKey.Escape:
                                    adventureLoop = false;
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
                        #endregion
                    }
                } while (encounterLoop && adventureLoop);
            } while (adventureLoop);

        }//End Main()    


    }//End Class
}//End Namespace