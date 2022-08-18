using AdventureLibrary;


namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LocationObjects
            //Location inn = new Location();
            //Location provisioner = new Location();
            //Location sewer = new Location();
            //Location graveyard = new Location();
            //Location castle = new Location();
            //Location mtnPass = new Location();
            //Location road1 = new Location();
            //Location road2 = new Location();
            //Location road3 = new Location();
            //Location swamp1 = new Location();
            //Location swamp2 = new Location();
            //Location forest1 = new Location();
            //Location forest2 = new Location();
            //Location forest3 = new Location();
            //Location forest4 = new Location();
            //Location forest5 = new Location();
            //Location forest6 = new Location();
            //Location ocean = new Location();
            //Location mountain = new Location();

            //inn = new Location("Inn", 01, "A place to seek out lodging to rest.", road2, road1, sewer, provisioner, true, 0, false);
            //provisioner = new Location("Provisioner", 02, "Looking to upgrade weapons or buy bandages? Look no further!", forest2, inn, road3, mountain, true, 3, false);
            //sewer = new Location("Sewer", 3, "Risk your death to fight the undead. High risk high rewards here.", inn, swamp1, ocean, road3, false, 5, true);
            //graveyard = new Location("GraveYard", 4, "Risk your death to fight the undead. High risk high rewards here.", mountain, forest3, road2, forest1, false, 10, true);
            //castle = new Location("King's Castle", 5, "The mighty King's Castle in the forest", forest6, ocean, swamp2, road1, false, 10, true);
            //mtnPass = new Location("Mountain Pass", 6, "You see a clearing in the mountains guarded by a goblin fort. You'll have to fight your way through to advance.", mountain, road3, mountain, mountain, false, 10, true);
            //road1 = new Location("Road", 7, "A well traveled road from the Inn to the King's King's Castle.", forest4, castle, swamp1, inn, false, 5, true);
            //road2 = new Location("Road", 8, "Dimmly lit from the over-arching tree line. Dare to venture out for new challenges?", forest4, castle, swamp1, inn, false, 5, true);
            //road3 = new Location("Road", 9, "A road riddled with graves from former travelers.. But that must be something on the other side worth the danger?", provisioner, inn, ocean, mtnPass, false, 5, true);
            //swamp1 = new Location("Swamp", 10, "Water and Mud with the runoff from the sewer.. Gross but might be worth checking out.", road1, swamp2, ocean, sewer, false, 7, true);
            //swamp2 = new Location("Swamp", 11, "Plenty of opportunities for death and wealth in this swamp. ", castle, ocean, ocean, swamp1, false, 7, true);
            //forest1 = new Location("Forest", 12, "Shadowy figures and the unknown in this densly wooded area.", mountain, graveyard, forest2, mountain, false, 7, true);
            //forest2 = new Location("Forest", 13, "Shadowy figures and the unknown in this densly wooded area.", forest1, road2, provisioner, mountain, false, 7, true);
            //forest3 = new Location("Forest", 14, "Shadowy figures and the unknown in this densly wooded area.", mountain, forest5, forest4, graveyard, false, 7, true);
            //forest4 = new Location("Forest", 15, "Shadowy figures and the unknown in this densly wooded area.", forest3, forest6, road1, road2, false, 7, true);
            //forest5 = new Location("Forest", 16, "Shadowy figures and the unknown in this densly wooded area.", mountain, ocean, forest6, forest3, false, 7, true);
            //forest6 = new Location("Forest", 17, "Shadowy figures and the unknown in this densly wooded area.", mountain, ocean, castle, forest4, false, 7, true);
            //ocean = new Location("Ocean", 18, "An Impassible body of water.", ocean, ocean, ocean, ocean, false, 0, false);
            //mountain = new Location("Mountain", 19, "Vast formations of rock and snow. No getting through there..", mountain, mountain, mountain, mountain, false, 0, false);
                        

            //var locations = new Dictionary<int, Location>()
            //{
            //    {inn.Id, inn},
            //    {provisioner.Id, provisioner},
            //    {sewer.Id, sewer},
            //    {graveyard.Id,graveyard},
            //    {castle.Id,castle},
            //    {mtnPass.Id, mtnPass},
            //    {road1.Id, road1},
            //    {road2.Id, road2},
            //    {road3.Id, road3},
            //    {swamp1.Id, swamp1},
            //    {swamp2.Id, swamp2},
            //    {forest1.Id, forest1},
            //    {forest2.Id, forest2},
            //    {forest3.Id, forest3},
            //    {forest4.Id, forest4},
            //    {forest5.Id, forest5},
            //    {forest6.Id, forest6},
            //    {ocean.Id,ocean},
            //    {mountain.Id, mountain},
            //};

            #endregion

            //TODO CreatePlayer();

            bool adventureLoop = true;
            Random rand1 = new Random();

            do
            {
                bool encounterLoop = true;
                //TODO CreateMonster();
                //TODO CreateLocation();
                //Console.WriteLine($"\n{locations[inn.Id].ToString()}");
                //Console.WriteLine($"Location: {locations[inn.Id].Name} - {locations[inn.Id].Description}\n" +
                //    $"Store? {(locations[inn.Id].HasStore ? "Yes" : "No")} -- Loot? {(locations[inn.Id].HasLoot ? "Yes" : "No")} -- Danger Level: {locations[inn.Id].DangerLvl}\n" +
                //    $"\t\tNorth:{locations[inn.Id].North.Name}\n" +
                //    $"West: {locations[inn.Id].West.Name}\t\t\t\tEast: {locations[inn.Id].East.Name}\n" +
                //    $"\t\tSouth: {locations[inn.Id].South.Name}");
                Room(4);
                Console.WriteLine("Monster Created\n");
                Console.Write("Press any key to continue:\n\n");
                Console.ReadKey(true);

                do
                {
                    Console.Write("Choose Your Next Move:\n" +
                       "A. Attack\n" +
                       "B. Run Away\n" +
                       "C. Character Info\n" +
                       "D. Monster Info\n" +
                       "E. Exit\n\n\n");
                    string choice = Console.ReadKey(true).Key.ToString();

                    switch (choice)
                    {
                        case "A":
                            Console.WriteLine("You Attacked");
                            int randAtk = rand1.Next(1, 51);
                            if (randAtk > 15)
                            {
                                Console.WriteLine("You Won");
                                Console.WriteLine("Press Any Key to Continue");
                                Console.ReadKey();
                                Console.Clear();
                                encounterLoop = false;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("You Lost\n\n");
                                adventureLoop = false;
                                encounterLoop = false;
                            }
                            break;

                        case "B":
                            Console.WriteLine("You Ran Away");
                            Console.ReadKey();
                            encounterLoop = false;
                            Console.Clear();
                            break;

                        case "C":
                            Console.WriteLine($"Character Info");

                            break;

                        case "D":
                            Console.WriteLine("Monster Info");
                            break;

                        case "E":
                            adventureLoop = false;
                            encounterLoop = false;
                            break;

                        default:
                            Console.WriteLine("Input not recognized");
                            break;
                    }
                    if (encounterLoop)
                    {
                        Console.WriteLine("Press Any Key to Continue");
                        Console.ReadKey();
                        Console.Clear();
                    }//end if



                } while (encounterLoop);
            } while (adventureLoop);

        }//End Main()

        private static void Room(int Id)

        {
            #region LocationObjects
            #region innerObject

            Location inn = new Location();
            Location provisioner = new Location();
            Location sewer = new Location();
            Location graveyard = new Location();
            Location castle = new Location();
            Location mtnPass = new Location();
            Location road1 = new Location();
            Location road2 = new Location();
            Location road3 = new Location();
            Location swamp1 = new Location();
            Location swamp2 = new Location();
            Location forest1 = new Location();
            Location forest2 = new Location();
            Location forest3 = new Location();
            Location forest4 = new Location();
            Location forest5 = new Location();
            Location forest6 = new Location();
            Location ocean = new Location();
            Location mountain = new Location();

            inn = new Location("Inn", 01, "A place to seek out lodging to rest.", road2, road1, sewer, provisioner, true, 0, false);
            provisioner = new Location("Provisioner", 02, "Looking to upgrade weapons or buy bandages? Look no further!", forest2, inn, road3, mountain, true, 3, false);
            sewer = new Location("Sewer", 3, "Risk your death to fight the undead. High risk high rewards here.", inn, swamp1, ocean, road3, false, 5, true);
            graveyard = new Location("GraveYard", 4, "Risk your death to fight the undead. High risk high rewards here.", mountain, forest3, road2, forest1, false, 10, true);
            castle = new Location("King's Castle", 5, "The mighty King's Castle in the forest", forest6, ocean, swamp2, road1, false, 10, true);
            mtnPass = new Location("Mountain Pass", 6, "You see a clearing in the mountains guarded by a goblin fort. You'll have to fight your way through to advance.", mountain, road3, mountain, mountain, false, 10, true);
            road1 = new Location("Road", 7, "A well traveled road from the Inn to the King's King's Castle.", forest4, castle, swamp1, inn, false, 5, true);
            road2 = new Location("Road", 8, "Dimmly lit from the over-arching tree line. Dare to venture out for new challenges?", forest4, castle, swamp1, inn, false, 5, true);
            road3 = new Location("Road", 9, "A road riddled with graves from former travelers.. But that must be something on the other side worth the danger?", provisioner, inn, ocean, mtnPass, false, 5, true);
            swamp1 = new Location("Swamp", 10, "Water and Mud with the runoff from the sewer.. Gross but might be worth checking out.", road1, swamp2, ocean, sewer, false, 7, true);
            swamp2 = new Location("Swamp", 11, "Plenty of opportunities for death and wealth in this swamp. ", castle, ocean, ocean, swamp1, false, 7, true);
            forest1 = new Location("Forest", 12, "Shadowy figures and the unknown in this densly wooded area.", mountain, graveyard, forest2, mountain, false, 7, true);
            forest2 = new Location("Forest", 13, "Shadowy figures and the unknown in this densly wooded area.", forest1, road2, provisioner, mountain, false, 7, true);
            forest3 = new Location("Forest", 14, "Shadowy figures and the unknown in this densly wooded area.", mountain, forest5, forest4, graveyard, false, 7, true);
            forest4 = new Location("Forest", 15, "Shadowy figures and the unknown in this densly wooded area.", forest3, forest6, road1, road2, false, 7, true);
            forest5 = new Location("Forest", 16, "Shadowy figures and the unknown in this densly wooded area.", mountain, ocean, forest6, forest3, false, 7, true);
            forest6 = new Location("Forest", 17, "Shadowy figures and the unknown in this densly wooded area.", mountain, ocean, castle, forest4, false, 7, true);
            ocean = new Location("Ocean", 18, "An Impassible body of water.", ocean, ocean, ocean, ocean, false, 0, false);
            mountain = new Location("Mountain", 19, "Vast formations of rock and snow. No getting through there..", mountain, mountain, mountain, mountain, false, 0, false);
            #endregion

            var locations = new Dictionary<int, Location>()
            {
                {inn.Id, inn},
                {provisioner.Id, provisioner},
                {sewer.Id, sewer},
                {graveyard.Id,graveyard},
                {castle.Id,castle},
                {mtnPass.Id, mtnPass},
                {road1.Id, road1},
                {road2.Id, road2},
                {road3.Id, road3},
                {swamp1.Id, swamp1},
                {swamp2.Id, swamp2},
                {forest1.Id, forest1},
                {forest2.Id, forest2},
                {forest3.Id, forest3},
                {forest4.Id, forest4},
                {forest5.Id, forest5},
                {forest6.Id, forest6},
                {ocean.Id,ocean},
                {mountain.Id, mountain},
            };

            Console.WriteLine($"\n\nLocation: {locations[Id].Name} - {locations[Id].Description}\n" +
                    $"\t\tStore? {(locations[Id].HasStore ? "Yes" : "No")} -- Loot? {(locations[Id].HasLoot ? "Yes" : "No")} -- Danger Level: {locations[Id].DangerLvl}\n\n\n" +
                    $"\t\tNorth:{locations[Id].North}\n\n\n" +
                    $"West: {locations[Id].West.Name}\t\t\t\tEast: {locations[Id].East.Name}\n\n\n" +
                    $"\t\tSouth: {locations[Id].South.Name}\n\n");
            #endregion
        }


    }//End Class
}//End Namespace