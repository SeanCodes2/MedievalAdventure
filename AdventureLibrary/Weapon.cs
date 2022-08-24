using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class Weapon : Items
    {       
        private int _minDamage;
     
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (_minDamage > MaxDamage)
                {
                    _minDamage = MaxDamage;
                }
                else
                {
                    _minDamage = value;
                }
            }
        }

        public int MaxDamage { get; set; }       

        public int BonusHitChance { get; set; }
             
        public Weapon() { }

        public Weapon( string name, int block, int cost, int minDamage, int maxDamage, int bonusHitChance ) : base(block, cost, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BonusHitChance = bonusHitChance;
        }
       
        public override string ToString()
        {
            //return base.ToString();
            return $"WEAPON: {Name} | " +
                $"HitChance: {BonusHitChance} | " +
                $"Damage: {MinDamage}-{MaxDamage} ";
        }
        public static Weapon GetWeapon(int index)
        {
            Weapon butterKnife = new Weapon("Butter Knife", 7, 2, 8, 1, 0);
            Weapon katana = new Weapon("Katana", 12, 4, 9, 2, 15);
            Weapon dagger = new Weapon("Dagger", 8, 4, 10, 1, 10);
            Weapon spear = new Weapon("Short Spear", 15, 4, 10, 3, 20);
            Weapon mace = new Weapon("Mace", 18, 5, 10, 2, 25);

            List<Weapon> weapons = new List<Weapon>()
                    { butterKnife, dagger, katana,  spear, mace };

            Weapon currentWeapon = weapons[index];
            return currentWeapon;
        }
    }
}
