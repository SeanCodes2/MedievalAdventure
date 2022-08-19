using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeMtnPass : Character
    {
        public bool IsBeastMode { get; set; }
        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }

        public FoeMtnPass(string name, int maxLife, int life, int hitChance, int block, bool isBeastMode, int maxDmg, int minDmg)
            : base(name, maxLife, life, hitChance, block)
        {
            IsBeastMode = isBeastMode;
            MaxDmg = maxDmg;
            MinDmg = minDmg;
        }

        public override int CalcBlock()
        {
            int block = 4;
            if (IsBeastMode)
            {
                block += 4;
            }
            return block;
        }
        public override int CalcDamage()
        {
            int damage = 4;
            if (IsBeastMode)
            {
               damage += 4;
            }
            return damage;
        }

        public override int CalcHitChance()
        {
            int hitChance = 4;
            if (IsBeastMode)
            {
                hitChance += 4;
            }
            return hitChance;
        }
    }
}
