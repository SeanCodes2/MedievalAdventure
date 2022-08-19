using AdventureLibrary;



namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            bool adventureLoop = true;
            Random rand1 = new Random();

            do
            {
                bool encounterLoop = true;

                Room.GetRoom(1);//param calls room id

                #region Weapons and Shields
                Weapon butterKnife = new Weapon("Butter Knife", 7, 2, 9, 1);
                Weapon katana = new Weapon("Katana", 12, 10, 6,  2);
                Weapon dagger = new Weapon("Dagger", 8, 4, 8, 1);
                Weapon spear = new Weapon("Short Spear", 15, 6, 5, 3);
                Weapon mace = new Weapon("Mace", 18, 7, 4, 2);                
                List<Weapon> weapons = new List<Weapon>()
                    { butterKnife, katana, dagger, spear, mace };

                Shield buckler = new Shield("Buckler", 4);
                Shield kite = new Shield("Kite Shield", 7);
                Shield heater = new Shield("Heater Shield", 10);
                Shield none = new Shield();
                #endregion

                Player user = new Player("Adventurer", 100, 100, 0, 0,  katana, buckler, 5);
                user.Block = user.CalcBlock();
                user.HitChance = user.CalcHitChance();

                Console.WriteLine("\t\t\t\t\t*****PLAYER*****");
                Console.WriteLine(user);
                Console.WriteLine(user.EquippedWeapon);              
                Console.WriteLine(user.EquippedShield);

                Console.WriteLine("\t\t\t\t\t*****Adversary*****\n");

                #region Adversarys
                
                FoeSewer rat = new FoeSewer("Rat", 20, 20, 3, 1, true);
                #endregion
                Console.WriteLine(rat);
                Console.Write("Press any key to enter encounter:\n\n");
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
                    Console.Clear();

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

       
    }//End Class
}//End Namespace