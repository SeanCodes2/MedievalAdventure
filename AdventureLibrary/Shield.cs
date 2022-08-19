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
            return $"\t|  SHIELD: {Name}  |  Block: {Block}\n" +
                $"______________________________________________________________________________________________________________\n" +
                $"______________________________________________________________________________________________________________";
        }
    }
}
