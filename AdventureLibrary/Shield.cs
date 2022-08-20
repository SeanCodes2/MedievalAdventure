using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class Shield
    {
        public string Name { get; set; }
        public int Block { get; set; }

        public Shield() { }
        public Shield(string name, int block)
        {
            Name = name;
            Block = block;
        }

        public override string ToString()
        {
            return $"\t\tSHIELD: {Name} | Block: {Block}\n";                
        }

        public static Shield GetShield(int index)
        {
            Shield none = new Shield("None Equipped", 0);
            Shield buckler = new Shield("Buckler", 4);
            Shield kite = new Shield("Kite Shield", 7);
            Shield heater = new Shield("Heater Shield", 10);
            List<Shield> shields = new List<Shield>()
                    {none, buckler, kite, heater};

            Shield currentShield = shields[index];
            return currentShield;
        }
    }
}
