﻿using AdventureLibrary;
using AdversaryLibrary;



namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nMedieval Adventure\n\n");

            #region Player Choosing Name
            Console.WriteLine("Hello Adventurer! What is your name??\n");
            string name = Console.ReadLine();
            #endregion

            #region Player Choosing Class 
            //Customize race/name based on user input
            var charClass = Enum.GetValues(typeof(CharacterClass));
            int Index = 1;
            Console.WriteLine("\nPlease select a class: ");


            foreach (var type in charClass)
            {
                Console.WriteLine($"{Index}) {type}");
                Index++;
            }
                        
            int userInput = int.Parse(Console.ReadLine()) - 1;//Subtract 1 to make zero based
            CharacterClass playerClass = (CharacterClass)userInput;
            #endregion

            Weapon userWeapon = Weapon.GetWeapon(0);
            Shield userShield = Shield.GetShield(0);

            Player user = new Player(name, playerClass, 40, 40, 50, 0, userWeapon, userShield, 50, 0, 5);

            Console.Clear();
            Console.WriteLine($"\nWelcome {user.Name}! Your Adventure Awaits!");


            Random rand1 = new Random();
            bool adventureLoop = true;
            do
            {

                Location currentRoom = Room.GetRoom(1);

                bool encounterLoop = true;
                do
                {                    
                    ConsoleKey menuChoice;

                    Console.WriteLine($"\n\n\t\t\t\t\tNORTH: {currentRoom.North.Name} \n\n\n" +
                        $"\t\tWEST: {currentRoom.West.Name}" +
                        $"\n\t\t\t\t\t\t\t\t\tEAST: {currentRoom.East.Name}\n\n\n" +
                        $"\t\t\t\t\tSOUTH: {currentRoom.South.Name}\n\n\n");

                    Console.WriteLine($"\nWelcome to the {currentRoom} - {currentRoom.Description}\n");

                    #region Adversary Switch
                    Adversary adversary = new Adversary();
                    switch (currentRoom.Id)
                    {
                        case 1:
                        case 2:
                            adversary = new Adversary();
                            break;
                        case 3:
                            adversary = FoeSewer.GetSewerFoe();
                            break;
                        case 4:
                            adversary = FoeGraveyard.GetGraveyardFoe();
                            break;
                        case 5:
                            adversary = FoeCastle.GetCastleFoe();
                            break;
                        case 6:
                            adversary = FoeMtnPass.GetMtnPassFoe();
                            break;
                        case 7:
                        case 8:
                        case 9:
                            adversary = FoeForestRoad.GetForestRoadFoe();
                            break;
                        case 10:
                        case 11:
                            adversary = FoeSwamp.GetSwampFoe();
                            break;
                        case 12:
                        case 13:
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                            adversary = FoeForestRoad.GetForestRoadFoe();
                            break;
                        default:
                            adversary = new Adversary();
                            break;
                    }
                    #endregion

                    Console.WriteLine($"Current Adversary: {adversary.Name}\n");




                    #region Display Menu Conditional If
                    if (currentRoom.Id == 1)
                    {
                        Console.Write("\nMake Your Next Move:\n\n" +
                            "\tUpArrow - Move North\n" +
                            "\tRightArrow - Move East\n" +
                            "\tDownArrow - Move South\n" +
                            "\tLeftArrow - Move West\n" +
                            "\tP. - Player Info\n" +
                            "\tE. - Exit\n\n");

                        menuChoice = Console.ReadKey(true).Key;

                        switch (menuChoice)
                        {
                            case ConsoleKey.UpArrow:
                                Console.WriteLine("You Move North\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                currentRoom = currentRoom.North;
                                break;
                            case ConsoleKey.RightArrow:
                                Console.WriteLine("You Move East\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                currentRoom = currentRoom.East;
                                break;
                            case ConsoleKey.DownArrow:
                                Console.WriteLine("You Move South\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                currentRoom = currentRoom.South;
                                break;
                            case ConsoleKey.LeftArrow:
                                Console.WriteLine("You Move West\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                currentRoom = currentRoom.West;
                                break;
                            case ConsoleKey.P:
                                Console.Clear();
                                Console.WriteLine(user);
                                Console.WriteLine(user.EquippedWeapon);
                                Console.WriteLine(user.EquippedShield);
                                Console.ReadKey();
                                break;
                            case ConsoleKey.E:
                            case ConsoleKey.Escape:
                                Console.WriteLine("\n\nNoone Likes a Quitter!\n\n");
                                Console.Clear();
                                adventureLoop = false;
                                break;
                            default:
                                Console.WriteLine("Unknown Command - Please try again.");
                                break;
                        }//end switch

                    }//end room 1 IF
                    else if (currentRoom.Id == 2)
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
                                Console.WriteLine("You Move North\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                currentRoom = currentRoom.North;
                                break;
                            case ConsoleKey.RightArrow:
                                Console.WriteLine("You Move East\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                currentRoom = currentRoom.East;
                                break;
                            case ConsoleKey.DownArrow:
                                Console.WriteLine("You Move South\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                currentRoom = currentRoom.South;
                                break;
                            case ConsoleKey.LeftArrow:
                                Console.WriteLine("You Move West\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                currentRoom = currentRoom.West;
                                break;
                            case ConsoleKey.S:
                                Console.Clear();
                                Console.WriteLine($"\n\nGold Available: {user.Gold}\n");
                                Console.WriteLine($"Current wares available:\n\n" +
                                    $"1. (10 Gold) Dagger {Weapon.GetWeapon(2)}\n" +
                                    $"2. (15 Gold) Katana {Weapon.GetWeapon(1)}\n" +
                                    $"3. (20 Gold) Spear {Weapon.GetWeapon(3)}\n" +
                                    $"4. (25 Gold) Mace {Weapon.GetWeapon(4)}\n" +
                                    $"5. (10 Gold) Buckler Shield{Shield.GetShield(1)}\n" +
                                    $"6. (25 Gold) Kite Shield {Shield.GetShield(2)}\n" +
                                    $"7. (40 Gold) Heater Shield {Shield.GetShield(3)}\n" +
                                    $"\n" +
                                    $"E. Exit Store");

                                ConsoleKey shopChoice = Console.ReadKey(true).Key;
                                switch (shopChoice)
                                {
                                    case ConsoleKey.D1:
                                        if (user.Gold < 10)
                                        {
                                            Console.WriteLine("Cannot Afford That Item.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You Bought The Dagger!");
                                            user.Gold = user.Gold - 10;
                                            user.EquippedWeapon = Weapon.GetWeapon(2);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case ConsoleKey.D2:
                                        if (user.Gold < 15)
                                        {
                                            Console.WriteLine("Cannot Afford That Item.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You Bought The Katana!");
                                            user.Gold = user.Gold - 15;
                                            user.EquippedWeapon = Weapon.GetWeapon(1);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case ConsoleKey.D3:
                                        if (user.Gold < 20)
                                        {
                                            Console.WriteLine("Cannot Afford That Item.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You Bought The Spear!");
                                            user.Gold = user.Gold - 20;
                                            user.EquippedWeapon = Weapon.GetWeapon(3);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case ConsoleKey.D4:
                                        if (user.Gold < 25)
                                        {
                                            Console.WriteLine("Cannot Afford That Item.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You Bought The Mace!");
                                            user.Gold = user.Gold - 25;
                                            user.EquippedWeapon = Weapon.GetWeapon(4);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case ConsoleKey.D5:
                                        if (user.Gold < 10)
                                        {
                                            Console.WriteLine("Cannot Afford That Item.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You Bought The Buckler!");
                                            user.Gold = user.Gold - 10;
                                            user.EquippedShield = Shield.GetShield(1);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case ConsoleKey.D6:
                                        if (user.Gold < 25)
                                        {
                                            Console.WriteLine("Cannot Afford That Item.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You Bought The Kite Shield!");
                                            user.Gold = user.Gold - 25;
                                            user.EquippedShield = Shield.GetShield(2);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    case ConsoleKey.D7:
                                        if (user.Gold < 40)
                                        {
                                            Console.WriteLine("Cannot Afford That Item.");
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        else
                                        {
                                            Console.WriteLine($"You Bought The Heater Shield!");
                                            user.Gold = user.Gold - 40;
                                            user.EquippedShield = Shield.GetShield(3);
                                            Console.ReadKey();
                                            Console.Clear();
                                        }
                                        break;
                                    default:
                                        Console.WriteLine("Unknown Command - Please try again. ");
                                        Console.ReadKey();
                                        break;
                                }
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
                                break;
                            default:
                                Console.WriteLine("Unknown Command - Please try again.");
                                break;
                        }//end switch
                    }
                    else
                    {
                        #endregion

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
                                currentRoom = currentRoom.North;
                                Console.WriteLine("You Move North\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.RightArrow:
                                currentRoom = currentRoom.East;
                                Console.WriteLine("You Move East\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.DownArrow:
                                currentRoom = currentRoom.South;
                                Console.WriteLine("You Move South\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.LeftArrow:
                                currentRoom = currentRoom.West;
                                Console.WriteLine("You Move West\n" + "Press any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.A:

                                break;
                            case ConsoleKey.R:

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
                                Console.WriteLine("\n\nNoone Likes a Quitter!\n\n");
                                Console.Clear();
                                adventureLoop = false;
                                break;
                            default:
                                Console.WriteLine("Unknown Command - Please try again.");
                                break;
                        }//end switch
                    }


                } while (encounterLoop && adventureLoop);
            } while (adventureLoop);

        }//End Main()




    }//End Class
}//End Namespace