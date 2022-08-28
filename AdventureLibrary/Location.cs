using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public partial class Location
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public int IdNorth { get; set; }
        public int IdEast { get; set; }
        public int IdSouth { get; set; }
        public int IdWest { get; set; }
        public Location North { get; set; }
        public Location East { get; set; }
        public Location South { get; set; }
        public Location West { get; set; }
        public Location Current { get; set; }
        public string Art { get; set; }

        public Location() { }

        public Location(string name, int id, int idNorth, int idEast, int idSouth, int idWest, string description, string art)
        {
            Name = name;
            ID = id;
            Description = description;
            IdNorth = idNorth;
            IdEast = idEast;
            IdSouth = idSouth;
            IdWest = idWest;
            Art = art;
        }

        public override string ToString()
        {
            //return base.ToString();
            return $"{Name}";
        }

        public static Location[] GetMap()

        {
            return new Location[]
            {
            new Location("Inn", 0, 1, 4, 2, 3, "A place to seek out lodging to rest.", @"      
                         []_____
                        /\      \
                    ___/  \__/\__\__
                ---/\___\ |''''''|__\-- ---
                   ||'''| |''||''|''|   "),
            new Location("Provisioner", 3, 15, 0, 11, 16, "Looking to upgrade weapons or buy bandages? Look no further!", null),
            new Location("Sewer", 2, 0, 7, 17, 11, "Smelly, Slimy, and Wet. At least its not too challenging", @"
                           ..----.._    _
                        .' .--.    ""-.(O)_
            '-.__.-'""'=:|  ,  _)_ \__ . c\'-..
                         ''------'---''---'-"""),
            new Location("GraveYard", 13, 16, 8, 1, 12, "Risk your death to fight the undead. High risk high rewards here.", @"

"),
            new Location("King's Castle", 6, 9, 17, 10, 4, "The mighty King's Castle in the forest", null),
            new Location("Mountain Pass", 14, 16, 17, 9, 8, "You see a clearing in the mountains guarded by a goblin fort. You'll have to fight your way through to advance.", null),
            new Location("Road", 4, 5, 6, 7, 0, "A well traveled road from the Inn to the King's King's Castle.", null),
            new Location("Road", 1, 13, 5, 0, 15, "Dimmly lit from the over-arching tree line. Dare to venture out for new challenges?", null),
            new Location("Road", 11, 3, 2, 17, 16, "A road riddled with the graves of former travelers.. But there must be something on the other side worth the danger?", null),
            new Location("Swamp", 7, 4, 10, 17, 2, "Water and Mud with the runoff from the sewer.. Gross but might be worth checking out.", @" 
               _ _      (0)(0)-._  _.-'^^'^^'^^'^^'^^'--.
              (.(.)----'`        ^^'                /^   ^^-._
              (    `                 \             |    _    ^^-._
               VvvvvvvVv~~`__,/.._>  /:/:/:/:/:/:/:/\  (_..,______^^-.
                `^^^^^^^^`/  /   /  /`^^^^^^^^^>^^>^`>  >        _`)  )
                         (((`   (((`          (((`  (((`        `'--'^"),
            new Location("Swamp", 10, 6, 17, 17, 7, "Plenty of opportunities for death and wealth in this swamp. ", @" 
                _ _      (0)(0)-._  _.-'^^'^^'^^'^^'^^'--.
               (.(.)----'`        ^^'                /^   ^^-._
               (    `                 \             |    _    ^^-._
                VvvvvvvVv~~`__,/.._>  /:/:/:/:/:/:/:/\  (_..,______^^-.
                 `^^^^^^^^`/  /   /  /`^^^^^^^^^>^^>^`>  >        _`)  )
                          (((`   (((`          (((`  (((`        `'--'^"),
            new Location("Forest", 12, 16, 13, 15, 16, "Shadowy figures and the unknown in this densly wooded area.", null),
            new Location("Forest", 15, 12, 1, 3, 16, "Shadowy figures and the unknown in this densly wooded area.", null),
            new Location("Forest", 8, 16, 14, 5, 13, "Shadowy figures and the unknown in this densly wooded area.", null),
            new Location("Forest", 5, 8, 9, 4, 1, "Shadowy figures and the unknown in this densly wooded area.", null),
            new Location("Forest", 9, 14, 17, 6, 5, "Shadowy figures and the unknown in this densly wooded area.", null),
            new Location("Inaccessable Mountain", 16, 16, 16, 16, 16, "Vast formations of rock and snow. No getting through there..", null),
            new Location("Inaccessable Ocean", 17, 17, 17, 17, 17, "An Impassible body of water.", null),
            };
        }

        public static Location GetRoomById(int id)
        {
            return GetMap().FirstOrDefault(x => x.ID == id);
        }

        public Location MoveRoom(int id)
        {
            if (id != 16 && id != 17)
            {
                return GetRoomById(id);
            }
            else
            {
                Console.WriteLine("You can't move that way!");
                return this;
            }
        }

        public string RoomMap()
        {
            return
            $"\n\n\t\t\tNorth:{GetRoomById(IdNorth).Name}\n\n" +
            $"\tWest:{GetRoomById(IdWest).Name}\n" +
            $"\t\t\t\t\tEast:{GetRoomById(IdEast).Name}\n\n" +
            $"\t\t\tSouth:{GetRoomById(IdSouth).Name}\n";

        }
        public static void MoveNorth(ref Location currentRoom)
        {
            //Console.WriteLine("You Move North\n" + "Press any Key to Continue");            
            //Console.ReadKey();
            Console.Clear();
            currentRoom = currentRoom.MoveRoom(currentRoom.IdNorth);
        }
        public static void MoveEast(ref Location currentRoom)
        {

            //Console.WriteLine("You Move East\n" + "Press any Key to Continue");
            //Console.ReadKey();
            Console.Clear();
            currentRoom = currentRoom.MoveRoom(currentRoom.IdEast);
        }
        public static void MoveSouth(ref Location currentRoom)
        {

            //Console.WriteLine("You Move South\n" + "Press any Key to Continue");
            //Console.ReadKey();
            Console.Clear();
            currentRoom = currentRoom.MoveRoom(currentRoom.IdSouth);
        }
        public static void MoveWest(ref Location currentRoom)
        {
            //Console.WriteLine("You Move West\n" + "Press any Key to Continue");
            //Console.ReadKey();
            Console.Clear();
            currentRoom = currentRoom.MoveRoom(currentRoom.IdWest);
        }

        public static ConsoleKey InnMenu(ref Location currentRoom, Player user, /*ref bool adventureLoop,*/ ref bool encounterLoop, ref bool newMonster)
        {
            ConsoleKey menuChoice;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nMake Your Next Move:\n\n" +
                                            "\tUpArrow - Move North\n" +
                                            "\tRightArrow - Move East\n" +
                                            "\tDownArrow - Move South\n" +
                                            "\tLeftArrow - Move West\n\n" +
                                            "\tT. - Talk to InnKeeper\n" +
                                            "\tP. - Player Info\n" +
                                            "\tE. - Exit\n\n");
            Console.ResetColor();
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

                case ConsoleKey.T:
                    Console.Clear();
                    Console.WriteLine("\n\nWelcome to the Jhelom Inn Adventurer!! How can I be of service?\n\n");
                    bool leaveInn = false;
                    while (!leaveInn)
                    {
                        Console.WriteLine("\nTalk to the Innkeeper:\n" +
                            "\t1. - Where am I?\n" +
                            "\t2. - How do I get better equipment?\n" +
                            "\t3. - What is there to do?\n" +
                            "\t4. - Any advice on where to go next?\n" +
                            "\tE. - Leave Inn\n");
                        ConsoleKey talk = Console.ReadKey(true).Key;
                        switch (talk)
                        {
                            case ConsoleKey.D1:
                                Console.WriteLine("You are in the ocean side town of Jhelom. A place full of opportunities and danger alike. ");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D2:
                                Console.WriteLine("To the West of the Inn is the provisioners shop. You'll need gold collected from defeating monsters to make purchases.");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D3:
                                Console.WriteLine("You can explore the area, deafeating foes, collecting gold and equipment");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.D4:
                                Console.WriteLine("I would start to the south in the sewers working your way out to the swamps. \nThe more adventurous type can wander NorthWest to the Graveyard for more of a challenge. \nI've also heard rumors of an Orc Fort established to the Northeast if you are ready for a real challenge. ");
                                Console.ReadKey();
                                Console.Clear();
                                break;
                            case ConsoleKey.E:
                            case ConsoleKey.Escape:
                                leaveInn = true;
                                Console.Clear();
                                break;
                            default:
                                Console.WriteLine("I don't understand your strange language. Be well adventurer!");
                                leaveInn = true;
                                Console.ReadKey();
                                Console.Clear();
                                break;
                        }
                    }
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
                    Console.ReadKey(true);
                    Console.Clear();
                    //adventureLoop = false;
                    encounterLoop = false;
                    newMonster = true;
                    break;
                default:
                    //Console.WriteLine("Unknown Command - Please try again.");
                    Console.Clear();
                    break;
            }//end switch

            return menuChoice;
        }

        public static ConsoleKey ProvisionerMenu(ref Location currentRoom, Player user, int userScore, ref bool encounterLoop, ref bool newMonster)
        {
            ConsoleKey menuChoice;
            Console.Write("\nMake Your Next Move:\n\n" +
                                            "\tUpArrow - Move North\n" +
                                            "\tRightArrow - Move East\n" +
                                            "\tDownArrow - Move South\n" +
                                            "\tLeftArrow - Move West\n\n" +
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
                    Console.WriteLine($"Adversaries Defeated: {userScore}\n");
                    Console.WriteLine(user.EquippedWeapon);
                    Console.WriteLine(user.EquippedShield);
                    break;
                case ConsoleKey.E:
                case ConsoleKey.Escape:
                    Console.WriteLine("\n\nNoone Likes a Quitter!\n\n");
                    Console.Clear();
                    //adventureLoop = false;
                    encounterLoop = false;
                    newMonster = true;
                    break;
                default:
                    Console.WriteLine("Unknown Command - Please try again.");
                    break;
            }//end switch

            return menuChoice;
        }



    }
}
