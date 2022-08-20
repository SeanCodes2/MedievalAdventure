using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class FoeCastle : Adversary
    {
        public int DamageBonus { get; set; }

        public FoeCastle(string name, int maxLife, int life, int maxDmg, int minDmg, int hitChance, int block, int damageBonus) : base(name, maxLife, life, maxDmg, minDmg, hitChance, block)
        {
            DamageBonus = damageBonus;
        }

        public override int CalcDamage()
        {
            return base.CalcDamage() + DamageBonus;
        }

        public static FoeCastle GetCastleFoe()
        {
            FoeCastle guard = new FoeCastle("Castle Guard", 20, 20, 3, 1, 5, 3, 1);
            FoeCastle captain = new FoeCastle("Castle Captain", 25, 25, 4, 2, 6, 4, 2); ;
            FoeCastle knight = new FoeCastle("Castle Knight", 30, 30, 5, 4, 7, 5, 3);
            FoeCastle king = new FoeCastle("King Arthur", 35, 35, 6, 2, 8, 6, 4);
            List<FoeCastle> castleFoes = new List<FoeCastle>()
                { guard, captain, knight, king };

            return castleFoes[new Random().Next(castleFoes.Count)];

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
