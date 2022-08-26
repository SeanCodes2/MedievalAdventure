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


        public Location() { }

        public Location(string name, int id, int idNorth, int idEast, int idSouth, int idWest, string description)
        {
            Name = name;
            ID = id;
            Description = description;
            IdNorth = idNorth;
            IdEast = idEast;
            IdSouth = idSouth;
            IdWest = idWest;
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
            new Location("Inn", 0, 1, 4, 2, 3, "A place to seek out lodging to rest."),
            new Location("Provisioner", 3, 15, 0, 11, 16, "Looking to upgrade weapons or buy bandages? Look no further!"),
            new Location("Sewer", 2, 0, 7, 17, 11, "Risk your death to fight the undead. High risk high rewards here."),
            new Location("GraveYard", 13, 16, 8, 1, 12, "Risk your death to fight the undead. High risk high rewards here."),
            new Location("King's Castle", 6, 9, 17, 10, 4, "The mighty King's Castle in the forest"),
            new Location("Mountain Pass", 14, 16, 17, 9, 8, "You see a clearing in the mountains guarded by a goblin fort. You'll have to fight your way through to advance."),
            new Location("Road", 4, 5, 6, 7, 0, "A well traveled road from the Inn to the King's King's Castle."),
            new Location("Road", 1, 13, 5, 0, 15, "Dimmly lit from the over-arching tree line. Dare to venture out for new challenges?"),
            new Location("Road", 11, 3, 2, 17, 16, "A road riddled with the graves of former travelers.. But there must be something on the other side worth the danger?"),
            new Location("Swamp", 7, 4, 10, 17, 2, "Water and Mud with the runoff from the sewer.. Gross but might be worth checking out."),
            new Location("Swamp", 10, 6, 17, 17, 7, "Plenty of opportunities for death and wealth in this swamp. "),
            new Location("Forest", 12, 16, 13, 15, 16, "Shadowy figures and the unknown in this densly wooded area."),
            new Location("Forest", 15, 12, 1, 3, 16, "Shadowy figures and the unknown in this densly wooded area."),
            new Location("Forest", 8, 16, 14, 5, 13, "Shadowy figures and the unknown in this densly wooded area."),
            new Location("Forest", 5, 8, 9, 4, 1, "Shadowy figures and the unknown in this densly wooded area."),
            new Location("Forest", 9, 14, 17, 6, 5, "Shadowy figures and the unknown in this densly wooded area."),
            new Location("Inaccessable Mountain", 16, 16, 16, 16, 16, "Vast formations of rock and snow. No getting through there.."),
            new Location("Inaccessable Ocean", 17, 17, 17, 17, 17, "An Impassible body of water."),            
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
        {return
            $"\n\n\t\t\tNorth:{GetRoomById(IdNorth).Name}\n\n" +
            $"\tWest:{GetRoomById(IdWest).Name}\n" +
            $"\t\t\t\t\tEast:{GetRoomById(IdEast).Name}\n" +
            $"\t\t\tSouth:{GetRoomById(IdSouth).Name}\n";

        }

        public static ConsoleKey InnMenu(ref Location currentRoom, Player user, /*ref bool adventureLoop,*/ ref bool encounterLoop, ref bool newMonster)
        {
            ConsoleKey menuChoice;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nMake Your Next Move:\n\n" +
                                            "\tUpArrow - Move North\n" +
                                            "\tRightArrow - Move East\n" +
                                            "\tDownArrow - Move South\n" +
                                            "\tLeftArrow - Move West\n" +
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
                    newMonster=true;
                    break;
                case ConsoleKey.DownArrow:
                    Location.MoveSouth(ref currentRoom);
                    newMonster = true;
                    break;
                case ConsoleKey.LeftArrow:
                    Location.MoveWest(ref currentRoom);
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

        public static void MoveNorth(ref Location currentRoom)
        {            
            Console.WriteLine("You Move North\n" + "Press any Key to Continue");            
            Console.ReadKey();
            Console.Clear();
            currentRoom = currentRoom.MoveRoom(currentRoom.IdNorth);           
        }
        public static void MoveEast(ref Location currentRoom){
            
            Console.WriteLine("You Move East\n" + "Press any Key to Continue");
            Console.ReadKey();
            Console.Clear();
            currentRoom = currentRoom.MoveRoom(currentRoom.IdEast);           
        }
        public static void MoveSouth(ref Location currentRoom)
        {
            
            Console.WriteLine("You Move South\n" + "Press any Key to Continue");
            Console.ReadKey();
            Console.Clear();
            currentRoom = currentRoom.MoveRoom(currentRoom.IdSouth);           
        }
        public static void MoveWest(ref Location currentRoom)
        {            
            Console.WriteLine("You Move West\n" + "Press any Key to Continue");
            Console.ReadKey();
            Console.Clear();
            currentRoom = currentRoom.MoveRoom(currentRoom.IdWest);           
        }         




    }
}
