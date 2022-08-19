using AdventureLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdversaryLibrary
{
    public class Monster : Character
    {


        public Monster(string name, int maxLife, int life, int hitChance, int block) : base(name, maxLife, life, hitChance, block)
        {
        }
    }
}
