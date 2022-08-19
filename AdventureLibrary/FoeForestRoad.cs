using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeForestRoad : Character 
    {
        public bool IsShady { get; set; }

        public FoeForestRoad(string name, int maxLife, int life, int hitChance, int block, bool isShady)
            : base(name, maxLife, life, hitChance, block)
        {
            IsShady = isShady;
        }

        public override int CalcBlock()
        {            
            int block = 0;
            if (IsShady)
            {
                block += 3;
            }
            return block;
        }
    }
}
