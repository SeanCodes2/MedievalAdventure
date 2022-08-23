using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdversaryLibrary
{
    public sealed class FoeGraveyard : Adversary
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
            FoeGraveyard skeleton = new FoeGraveyard("Skeleton", 30, 30, 7, 3, 40, 7, false);
            FoeGraveyard mummy = new FoeGraveyard("Mummy", 36, 36, 7,3, 40, 7, false); ;
            FoeGraveyard ghoul = new FoeGraveyard("Ghoul", 40, 40, 8, 3, 40, 8, false);
            FoeGraveyard shade = new FoeGraveyard("Shade", 45, 45, 9, 3, 40, 8, false);
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
