using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class Items
    {
        public int Block { get; set; }    
        public int Cost { get; set; }
        public string Name { get; set; }

        public Items()
        {

        }

        public Items(int block, int cost, string name)
        {
            Block = block;
            Cost = cost;
            Name = name;
        }

        public static void ShopChoice(Player user, ConsoleKey shopChoice)
        {
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
        }
    }
}
