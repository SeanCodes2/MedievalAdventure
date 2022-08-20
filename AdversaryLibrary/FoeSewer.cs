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
            FoeSewer rat = new FoeSewer("Rat", 15, 15, 4, 1, 40, 3, false);
            FoeSewer slime = new FoeSewer("Slime", 18, 18, 5, 2, 40, 4, false); ;
            FoeSewer serpent = new FoeSewer("Serpent", 23, 23, 6, 2, 40, 5, false);
            FoeSewer alligator = new FoeSewer("Alligator", 28, 328, 7, 2, 40, 6, false);
            List<FoeSewer> sewerFoes = new List<FoeSewer>()
                { rat, slime, serpent, alligator };

            return sewerFoes[new Random().Next(sewerFoes.Count)];
        }
        public override string ToString()
        {
            return $"\n\nName: {Name}\n" +
                $"Life: {Life}/{MaxLife}\n" +
                $"Damage: {MinDmg}-{MaxDmg}\n" +
                $"HitChance: {HitChance}\n" +
                $"Block: {Block}";
        }
    }
}
