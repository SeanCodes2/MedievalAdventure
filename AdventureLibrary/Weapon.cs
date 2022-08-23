using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class Weapon
    {
        //Field | _camelCase | Access Modifier Private
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;  

        //Props | PascalCase of _fieldName | Public Access | Encapsulate the fields from users
        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (_minDamage > _maxDamage)
                {
                    _minDamage = _maxDamage;
                }
                else
                {
                    _minDamage = value;
                }
            }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }        

        public int Block { get; set; }



        //Constructors | camelCase of props | Public Access | Recreate default CTOR
        public Weapon() { }

        public Weapon(string name, int maxDamage, int minDamage, int bonusHitChance, int block)
        {
            Name = name;
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            BonusHitChance = bonusHitChance;            
            Block = block;

        }

        //Methods | Actions related to or using props of our object
                public override string ToString()
        {
            //return base.ToString();
            return $"WEAPON: {Name} | " +
                $"HitChance: {BonusHitChance} | " +
                $"Damage: {MinDamage}-{MaxDamage} ";
        }

        public static Weapon GetWeapon(int index)
        {
            Weapon butterKnife = new Weapon("Butter Knife", 7, 2, 8, 1);
            Weapon katana = new Weapon("Katana", 12, 4, 9, 2);
            Weapon dagger = new Weapon("Dagger", 8, 4, 10, 1);
            Weapon spear = new Weapon("Short Spear", 15, 4, 11, 3);
            Weapon mace = new Weapon("Mace", 18, 5, 12, 2);

            List<Weapon> weapons = new List<Weapon>()
                    { butterKnife, katana, dagger, spear, mace };

            Weapon currentWeapon = weapons[index];
            return currentWeapon;
        }
    }
}
