namespace AdventureLibrary
{
    public abstract class Character
    {
        //Field | _camelCase | Access Modifier Private
        private int _life;
        private string _name;
        private int _hitChance;
        private int _block;
        private int _maxLife;
        


        //Props | PascalCase of _fieldName | Public Access | Encapsulate the fields from users

        public int Life
        {
            get { return _life; }
            set
            {
                if (value > _maxLife)
                {
                    _life = _maxLife;
                }
                else
                {
                    _life = value;
                }
            }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }

        


        //Constructors | camelCase of props | Public Access | Recreate default CTOR

        public Character() { }

        public Character(string name, int maxLife, int life, int hitChance, int block)
        {
            Name = name;
            MaxLife = maxLife;
            Life = life;
            HitChance = hitChance;
            Block = block;            
            
        }

        //Methods | Actions related to or using props of our object
        public override string ToString()
        {
            return $"\t|  NAME: {Name} | MaxLife: {MaxLife} | Life: {Life} | Blocking: {Block} | Hit Chance: {HitChance}\n";
        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }
        public virtual int CalcDamage()
        {
            
            return 0;
        }
    }
}