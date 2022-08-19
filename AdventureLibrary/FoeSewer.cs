using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeSewer : Character
    {
        public bool IsSlimy { get; set; }

        public FoeSewer(string name, int maxLife, int life, int hitChance, int block, bool isSlimy)
            : base (name, maxLife, life, hitChance, block)
        {
            IsSlimy = isSlimy;
        }

        public override int CalcBlock()
        {   
            int block = 0;
            if (IsSlimy)
            {
                block += 2;
            }
            return block;
        }

    }
}
