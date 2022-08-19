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
            return $"\t|  WEAPON: {Name}  |  HitChance: {BonusHitChance}  |  MinDamage: {MinDamage}  |  MaxDamage: {MaxDamage}\n";
        }
        
    }
}
