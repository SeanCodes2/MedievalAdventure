using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeCastle : Character
    {
        public int BlockBonus { get; set; }

        public FoeCastle(string name, int maxLife, int life, int hitChance, int block, int blockBonus)
            : base(name, maxLife, life, hitChance, block)
        {
            BlockBonus=blockBonus;
        }

        public override int CalcBlock()
        {
            Random random = new Random();
            int newBlock = 0;
            newBlock = random.Next(BlockBonus);
            return Block + newBlock;
        }
    }
}
