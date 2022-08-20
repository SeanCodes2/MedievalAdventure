using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeSewer : Adversary
    {
        public bool IsSlimy { get; set; }
                
        public FoeSewer(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block, bool isSlimy) : base(name, maxLife, life, maxDmg, minDmg, hitChance, block)
        {
            IsSlimy = isSlimy;
        }
              
        public override int CalcBlock()
        {
            int result = Block;
            if (IsSlimy)
            {
                result += Block / 2;
            }
            return result;
        }

        public static FoeSewer GetSewerFoe()
        {
            FoeSewer rat = new FoeSewer("Rat", 20, 20, 3, 1, 5, 3, false);
            FoeSewer slime = new FoeSewer("Slime", 25, 25, 4, 2, 6, 4, false); ;
            FoeSewer serpent = new FoeSewer("Serpent", 30, 30, 5, 4, 7, 5, false);
            FoeSewer alligator = new FoeSewer("Alligator", 35, 35, 6, 2, 8, 6, false);
            List<FoeSewer> sewerFoes = new List<FoeSewer>()
                { rat, slime, serpent, alligator };
            
            return sewerFoes[new Random().Next(sewerFoes.Count)];
        }
        public override string ToString()
        {
            return $"{GetSewerFoe()}";
        }
    }
}
