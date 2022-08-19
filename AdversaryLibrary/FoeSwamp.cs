using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeSwamp : Character
    {
        public int BonusHitChance { get; set; }
        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }

        public FoeSwamp(string name, int maxLife, int life, int hitChance, int block, int bonusHitChance, int maxDmg, int minDmg)
            : base(name, maxLife, life, hitChance, block)
        {
            BonusHitChance=bonusHitChance;
            MaxDmg = maxDmg;
            MinDmg = minDmg;
        }

        public override int CalcHitChance()
        {
            Random random = new Random();
            int bonusHit = random.Next(BonusHitChance);
            return HitChance + bonusHit;
        }
        
    }
}
