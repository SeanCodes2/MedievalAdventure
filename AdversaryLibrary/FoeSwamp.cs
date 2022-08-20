using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeSwamp : Adversary
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
            FoeSewer turtoise = new FoeSewer("Turtoise", 20, 20, 3, 1, 5, 3, false);
            FoeSewer reaper = new FoeSewer("Reaper", 25, 25, 4, 2, 6, 4, false);
            FoeSewer bogThing = new FoeSewer("Bog Thing", 30, 30, 5, 4, 7, 5, false);
            FoeSewer swampTenticle = new FoeSewer("Swamp Tenticle", 35, 35, 6, 2, 8, 6, false);
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
