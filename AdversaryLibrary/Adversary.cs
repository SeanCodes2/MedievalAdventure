using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdversaryLibrary
{
    public class Adversary : Character
    {
        public int MaxDmg { get; set; }
        public int MinDmg { get; set; }


        public Adversary()
        {
            Name = "No Adversary Here";

        }
        public Adversary(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block) : base(name, maxLife, life, hitChance, block)
        {
            MaxDmg = maxDmg;
            MinDmg = minDmg;
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDmg, MaxDmg + 1);
        }

        public override string ToString()
        {
            return $"No Adversary Here";
        }
    }
}
