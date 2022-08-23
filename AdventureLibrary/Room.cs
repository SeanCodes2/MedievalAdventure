using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public partial class Location
    {
        public static Location GetRoom(int id)

        {            
            Location inn = new Location("Inn", 01, "A place to seek out lodging to rest.", true, 0, false);
            Location provisioner = new Location("Provisioner", 02, "Looking to upgrade weapons or buy bandages? Look no further!", true, 3, false);
            Location sewer = new Location("Sewer", 3, "Risk your death to fight the undead. High risk high rewards here.", false, 5, true);
            Location graveyard = new Location("GraveYard", 4, "Risk your death to fight the undead. High risk high rewards here.", false, 10, true);
            Location castle = new Location("King's Castle", 5, "The mighty King's Castle in the forest", false, 10, true);
            Location mtnPass = new Location("Mountain Pass", 6, "You see a clearing in the mountains guarded by a goblin fort. You'll have to fight your way through to advance.", false, 10, true);
            Location road1 = new Location("Road", 7, "A well traveled road from the Inn to the King's King's Castle.", false, 5, true);
            Location road2 = new Location("Road", 8, "Dimmly lit from the over-arching tree line. Dare to venture out for new challenges?", false, 5, true);
            Location road3 = new Location("Road", 9, "A road riddled with graves from former travelers.. But that must be something on the other side worth the danger?", false, 5, true);
            Location swamp1 = new Location("Swamp", 10, "Water and Mud with the runoff from the sewer.. Gross but might be worth checking out.", false, 7, true);
            Location swamp2 = new Location("Swamp", 11, "Plenty of opportunities for death and wealth in this swamp. ", false, 7, true);
            Location forest1 = new Location("Forest", 12, "Shadowy figures and the unknown in this densly wooded area.", false, 7, true);
            Location forest2 = new Location("Forest", 13, "Shadowy figures and the unknown in this densly wooded area.", false, 7, true);
            Location forest3 = new Location("Forest", 14, "Shadowy figures and the unknown in this densly wooded area.", false, 7, true);
            Location forest4 = new Location("Forest", 15, "Shadowy figures and the unknown in this densly wooded area.", false, 7, true);
            Location forest5 = new Location("Forest", 16, "Shadowy figures and the unknown in this densly wooded area.", false, 7, true);
            Location forest6 = new Location("Forest", 17, "Shadowy figures and the unknown in this densly wooded area.", false, 7, true);
            Location ocean = new Location("Inaccessable Ocean", 18, "An Impassible body of water.", false, 0, false);
            Location mountain = new Location("Inaccessable Mountain", 19, "Vast formations of rock and snow. No getting through there..", false, 0, false);


            inn.North = road2; inn.East = road1; inn.South = sewer; inn.West = provisioner;
            provisioner.North = forest2; provisioner.East = inn; provisioner.South = road3; provisioner.West = mountain;
            sewer.North = inn; sewer.East = swamp1; sewer.South = ocean; sewer.West = road3;
            graveyard.North = mountain; graveyard.East = forest3; graveyard.South = road2; graveyard.West = forest1;
            castle.North = forest6; castle.East = ocean; castle.South = swamp2; castle.West = road1;
            mtnPass.North = mountain; mtnPass.East = road3; mtnPass.South = mountain; mtnPass.West = mountain;
            road1.North = forest4; road1.East = castle; road1.South = swamp1; road1.West = inn;
            road2.North = graveyard; road2.East = forest4; road2.South = inn; road2.West = forest2;
            road3.North = provisioner; road3.East = sewer; road3.South = ocean; road3.West = mtnPass;
            swamp1.North = road1; swamp1.East = swamp2; swamp1.South = ocean; swamp1.West = sewer;
            swamp2.North = castle; swamp2.East = ocean; swamp2.South = ocean; swamp2.West = swamp1;
            forest1.North = mountain; forest1.East = graveyard; forest1.South = forest2; forest1.West = mountain;
            forest2.North = forest1; forest2.East = road2; forest2.South = provisioner; forest2.West = mountain;
            forest3.North = mountain; forest3.East = forest5; forest3.South = forest4; forest3.West = graveyard;
            forest4.North = forest3; forest4.East = forest5; forest4.South = road1; forest4.West = road2;
            forest5.North = mountain; forest5.East = ocean; forest5.South = forest6; forest5.West = forest3;
            forest6.North = forest5; forest6.East = ocean; forest6.South = castle; forest6.West = forest4;
            mountain.North = mountain; mountain.East = mountain; mountain.South = mountain; mountain.West = mountain; mountain.Current = mountain;
            ocean.North = ocean; ocean.East = ocean; ocean.South = ocean; ocean.West = ocean; ocean.Current = ocean;

            List<Location> rooms = new List<Location>()
            {
                inn, provisioner, sewer, graveyard,castle,mtnPass,road1,road2,road3,swamp1,swamp2,forest1,forest2,forest3,forest4,forest5,forest6,mountain,ocean
            }; 
            
            Location currentLocation = rooms[id -1];
            return currentLocation;
            
        }//end GetRoom()

        public static void InnMenu(Player user, ref Location currentRoom, ConsoleKey menuChoice, ref bool adventureLoop, ref bool newMonster)
        {
            switch (menuChoice)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("You Move North\n" + "Press any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    currentRoom = currentRoom.North;
                    newMonster = true;
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("You Move East\n" + "Press any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    currentRoom = currentRoom.East;
                    newMonster = true;
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("You Move South\n" + "Press any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    currentRoom = currentRoom.South;
                    newMonster = true;
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("You Move West\n" + "Press any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    currentRoom = currentRoom.West;
                    newMonster = true;
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
        }

        public static void ProvisionerMenu(Player user, ref Location currentRoom, ConsoleKey menuChoice, ref bool adventureLoop, ref bool encounterLoop, ref bool newMonster)
        {
            switch (menuChoice)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("You Move North\n" + "Press any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    currentRoom = currentRoom.North;
                    newMonster = true;
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("You Move East\n" + "Press any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    currentRoom = currentRoom.East;
                    newMonster = true;
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("You Move South\n" + "Press any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    currentRoom = currentRoom.South;
                    newMonster = true;
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("You Move West\n" + "Press any Key to Continue");
                    Console.ReadKey();
                    Console.Clear();
                    currentRoom = currentRoom.West;
                    newMonster = true;
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
                        $"8. (15 Gold) Bandage (restores 15 lift)" +
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
                        case ConsoleKey.D8:
                            if (user.Gold < 15)
                            {
                                Console.WriteLine("Cannot Afford That Item.");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine($"You Bought a Bandage!");
                                user.Gold = user.Gold - 15;
                                user.Life = user.Life + 15;
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
                    encounterLoop = false;
                    newMonster = true;
                    break;
                default:
                    Console.WriteLine("Unknown Command - Please try again.");
                    break;
            }//end switch
        }




    }
}
