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
        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }

        public FoeForestRoad(string name, int maxLife, int life, int hitChance, int block, bool isShady, int maxDmg, int minDmg)
            : base(name, maxLife, life, hitChance, block)
        {
            IsShady = isShady;
            MaxDmg = maxDmg;
            MinDmg = minDmg;
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
