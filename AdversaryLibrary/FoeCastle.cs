using AdversaryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public sealed class FoeCastle : Adversary
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
            FoeCastle guard = new FoeCastle("Castle Guard", 40, 40, 9, 3, 40, 8, 0);
            FoeCastle captain = new FoeCastle("Castle Captain", 45, 45, 9, 3, 40, 8, 0); ;
            FoeCastle knight = new FoeCastle("Castle Knight", 54, 54, 10, 3, 40, 9, 0);
            FoeCastle king = new FoeCastle("King Arthur", 59, 59, 10, 3, 40, 9, 0);
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
