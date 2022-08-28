using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public sealed class FoeMtnPass : Adversary
    {
        public bool IsBeastMode { get; set; }

        public FoeMtnPass(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block, bool isBeastMode) : base(name, maxLife, life, maxDmg, minDmg, hitChance, block)
        {
            IsBeastMode = isBeastMode;
        }

        //public override int CalcBlock()
        //{
        //    return base.CalcBlock();
        //}
        //public override int CalcDamage()
        //{


        //    return base.CalcDamage();
        //}

        //public override int CalcHitChance()
        //{

        //    return base.CalcHitChance();
        //}

        public static FoeMtnPass GetMtnPassFoe()
        {
            FoeMtnPass orc = new FoeMtnPass("Orc", 54, 54, 12, 3, 65, 10, false);
            FoeMtnPass orcBrute = new FoeMtnPass("Orc Brute", 59, 59, 14, 5, 65, 15, false);
            FoeMtnPass orcCaptain = new FoeMtnPass("Orc Captain", 65, 65, 18, 6, 70, 20, false);
            FoeMtnPass OrcLord = new FoeMtnPass("Orc Lord", 70, 70, 20, 8, 70, 25, false);
            List<FoeMtnPass> mtnPassFoes = new List<FoeMtnPass>()
                {orc, orcBrute, orcCaptain, OrcLord};

            return mtnPassFoes[new Random().Next(mtnPassFoes.Count)];
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
