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

        public Adversary GetAdversary(Location currentRoom)
        {
            Adversary adversary;
            switch (currentRoom.Id)
            {
                case 1:
                case 2:
                    adversary = new Adversary();
                    break;
                case 3:
                    adversary = FoeSewer.GetSewerFoe();
                    break;
                case 4:
                    adversary = FoeGraveyard.GetGraveyardFoe();
                    break;
                case 5:
                    adversary = FoeCastle.GetCastleFoe();
                    break;
                case 6:
                    adversary = FoeMtnPass.GetMtnPassFoe();
                    break;
                case 7:
                case 8:
                case 9:
                    adversary = FoeForestRoad.GetForestRoadFoe();
                    break;
                case 10:
                case 11:
                    adversary = FoeSwamp.GetSwampFoe();
                    break;
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                    adversary = FoeForestRoad.GetForestRoadFoe();
                    break;
                default:
                    adversary = new Adversary();
                    break;
            }

            return adversary;
        }
    }
}
