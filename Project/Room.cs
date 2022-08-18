using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class Room
    {
        public static void GetRoom(int Id)

        {
            #region LocationObjects
            #region innerObject



            Location mountain = new Location("Inaccessable Mountain", 19, "Vast formations of rock and snow. No getting through there..", false, 0, false);
            Location ocean = new Location("Inaccessable Ocean", 18, "An Impassible body of water.", false, 0, false);
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


            inn.North = road2; inn.East = road1; inn.South = sewer; inn.West = provisioner;
            provisioner.North = forest2; provisioner.East = inn; provisioner.South = road3; provisioner.West = mountain;
            sewer.North = inn; sewer.East = swamp1; sewer.South = ocean; sewer.West = road3;
            graveyard.North = mountain; graveyard.East = forest3; graveyard.South = road2; graveyard.West = forest1;
            castle.North = forest6; castle.East = ocean; castle.South = swamp2; castle.West = road1;
            mtnPass.North = mountain; mtnPass.East = road3; mtnPass.South = mountain; mtnPass.West = mountain;
            road1.North = forest4; road1.East = castle; road1.South = swamp1; road1.West = inn;
            road2.North = forest4; road2.East = forest4; road2.South = swamp1; road2.West = forest2;
            road3.North = provisioner; road3.East = inn; road3.South = ocean; road3.West = mtnPass;
            swamp1.North = road1; swamp1.East = swamp2; swamp1.South = ocean; swamp1.West = sewer;
            swamp2.North = castle; swamp1.East = ocean; swamp1.South = ocean; swamp1.West = swamp1;
            forest1.North = mountain; forest1.East = graveyard; forest1.South = forest2; forest1.West = mountain;
            forest2.North = forest1; forest1.East = road2; forest1.South = provisioner; forest1.West = mountain;
            forest3.North = mountain; forest1.East = forest5; forest1.South = forest4; forest1.West = graveyard;
            forest4.North = forest3; forest1.East = forest5; forest1.South = road1; forest1.West = road2;
            forest5.North = mountain; forest1.East = ocean; forest1.South = forest6; forest1.West = forest3;
            forest6.North = forest5; forest1.East = ocean; forest1.South = castle; forest1.West = forest4;

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

            Console.WriteLine($"\n\t\t\t\t\tNorth: {locations[Id].North.Name} \n\n\n" +
                    $"\t\tWest: {locations[Id].West.Name}" +
                    $"\n\t\t\t\t\t\t\t\t\tEast: {locations[Id].East.Name}\n\n\n" +
                    $"\t\t\t\t\tSouth: {locations[Id].South.Name}\n\n\n\n" +
                $"Current Location: {locations[Id].Name} - {locations[Id].Description}\n\n" +
                    $"\t\t|- Store? {(locations[Id].HasStore ? "Yes" : "No")} -|- Loot? {(locations[Id].HasLoot ? "Yes" : "No")} -|- Danger Level: {locations[Id].DangerLvl} -|\n\n\n");





            #endregion
        }
    }
}
