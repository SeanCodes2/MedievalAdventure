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


    }
}
