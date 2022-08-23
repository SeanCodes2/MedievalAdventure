using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public sealed class FoeSwamp : Adversary
    {
        public int BonusHitChance { get; set; }

        public FoeSwamp(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block, int bonusHitChance) : base(name, maxLife, life, maxDmg, minDmg, hitChance, block)
        {
            BonusHitChance = bonusHitChance;
        }       
              
        public override int CalcHitChance()
        {
            Random random = new Random();
            int bonusHit = random.Next(BonusHitChance);
            return base.HitChance + bonusHit;
        }

        public static FoeSewer GetSwampFoe()
        {
            FoeSewer turtoise = new FoeSewer("Turtoise", 23, 23, 5, 2, 40, 5, false);
            FoeSewer reaper = new FoeSewer("Reaper", 28, 28, 5, 2, 40, 5, false);
            FoeSewer bogThing = new FoeSewer("Bog Thing", 31, 31, 6, 3, 40, 6, false);
            FoeSewer swampTenticle = new FoeSewer("Swamp Tenticle", 36, 36, 6, 3, 40, 6, false);
            List<FoeSewer> swampFoes = new List<FoeSewer>()
                {turtoise,reaper,bogThing,swampTenticle};

            return swampFoes[new Random().Next(swampFoes.Count)];

        }
        public override string ToString()
        {
            return $"\n\nName: {Name}\n" +
                $"Life: {Life}/{MaxLife}\n" +
                $"Damage: {MinDmg}-{MaxDmg}\n" +
                $"HitChance: {HitChance} Block: {Block}";
        }
    }
}
