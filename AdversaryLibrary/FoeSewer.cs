using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeSewer : Monster
    {
        public bool IsSlimy { get; set; }

        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }

        public FoeSewer(string name, int maxLife, int life, int hitChance, int block, bool isSlimy, int maxDmg, int minDmg)
            : base (name, maxLife, life, hitChance, block)
        {
            IsSlimy = isSlimy;
            MaxDmg = maxDmg;
            MinDmg = minDmg;
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

        public override int CalcDamage()
        {

            
            return base.CalcDamage();
        }

        public static FoeSewer GetSewer()
        {
            FoeSewer rat = new FoeSewer("Rat", 20, 20, 3, 1, true, 5, 3);
            FoeSewer slime = new FoeSewer("Slime", 25, 25, 4, 2, true, 6, 4);
            FoeSewer serpent = new FoeSewer("Serpent", 30, 30, 5, 4, true, 7, 5);
            FoeSewer alligator = new FoeSewer("Alligator", 35, 35, 6, 2, true, 8, 6);
            //List<FoeSewer> sewerFoes = new List<FoeSewer>()
            //    { rat, slime, serpent, alligator };
            List<FoeSewer> sewerFoes = new List<FoeSewer>()
           {
               rat, slime,serpent,alligator
           };
            return sewerFoes[new Random().Next(sewerFoes.Count)];
        }
    }
}
