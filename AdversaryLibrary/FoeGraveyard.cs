using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdversaryLibrary
{
    public class FoeGraveyard : Adversary
    {
        public bool IsNight { get; set; }

        public FoeGraveyard(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block, bool isNight) : base(name, maxLife, life, maxDmg, minDmg, hitChance, block)
        {
            IsNight = isNight;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + 20;
        }

        public static FoeGraveyard GetGraveyardFoe()
        {
            FoeGraveyard skeleton = new FoeGraveyard("Skeleton", 20, 20, 3, 1, 5, 3, false);
            FoeGraveyard mummy = new FoeGraveyard("Mummy", 25, 25, 4, 2, 6, 4, false); ;
            FoeGraveyard ghoul = new FoeGraveyard("Ghoul", 30, 30, 5, 4, 7, 5, false);
            FoeGraveyard shade = new FoeGraveyard("Shade", 35, 35, 6, 2, 8, 6, false);
            List<FoeGraveyard> graveyardFoes = new List<FoeGraveyard>()
                {skeleton,mummy,ghoul,shade};

            return graveyardFoes[new Random().Next(graveyardFoes.Count)];
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
