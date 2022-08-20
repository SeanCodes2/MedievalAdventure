using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeForestRoad : Adversary 
    {
        public bool IsShady { get; set; }

        public FoeForestRoad(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block, bool isShady) : base(name, maxLife, life, maxDmg, minDmg, hitChance, block)
        {
            IsShady = isShady;
        }

        public override int CalcBlock()
        {
            int result = Block;
            if (IsShady)
            {
                result += Block / 2;
            }
            return result;
        }

        public static FoeForestRoad GetForestRoadFoe()
        {
            FoeForestRoad mongbat = new FoeForestRoad("Mongbat", 20, 20, 3, 1, 5, 3, false);
            FoeForestRoad spider = new FoeForestRoad("Giant Spider", 25, 25, 4, 2, 6, 4, false); ;
            FoeForestRoad ettin = new FoeForestRoad("Ettin", 30, 30, 5, 4, 7, 5, false);
            FoeForestRoad ogre = new FoeForestRoad("Ogre", 35, 35, 6, 2, 8, 6, false);
            Adversary none = new Adversary();
            List<FoeForestRoad> forestRoadFoes = new List<FoeForestRoad>()
                { mongbat, spider, ettin, ogre,};

            return forestRoadFoes[new Random().Next(forestRoadFoes.Count)];
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
