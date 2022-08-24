using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class Shield : Items
    {
        public Shield() { }

        public Shield(string name, int block, int cost ) : base(block, cost, name)
        {}

        public override string ToString()
        {
            return $"SHIELD: {Name} | " +
                $"Block: {Block}";                
        }

        public static Shield GetShield(int index)
        {
            Shield none = new Shield("None Equipped", 0,0);
            Shield buckler = new Shield("Buckler", 4,10);
            Shield kite = new Shield("Kite Shield", 8,25);
            Shield heater = new Shield("Heater Shield", 10,40);
            List<Shield> shields = new List<Shield>()
                    {none, buckler, kite, heater};

            Shield currentShield = shields[index];
            return currentShield;
        }
    }
}
