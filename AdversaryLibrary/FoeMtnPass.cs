using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeMtnPass : Adversary
    {
        public bool IsBeastMode { get; set; }

        public FoeMtnPass(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block, bool isBeastMode) : base(name, maxLife, life, maxDmg, minDmg, hitChance, block)
        {
            IsBeastMode = isBeastMode;
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

        public static FoeMtnPass GetMtnPassFoe()
        {
            FoeMtnPass orc = new FoeMtnPass("Orc", 20, 20, 3, 1, 5, 3, false);
            FoeMtnPass orcBrute = new FoeMtnPass("Orc Brute", 25, 25, 4, 2, 6, 4, false);
            FoeMtnPass orcCaptain = new FoeMtnPass("Orc Captain", 30, 30, 5, 4, 7, 5, false);
            FoeMtnPass OrcLord = new FoeMtnPass("Orc Lord", 35, 35, 6, 2, 8, 6, false);
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
