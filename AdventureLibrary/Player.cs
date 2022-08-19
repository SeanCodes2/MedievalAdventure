using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public class Player : Character
    {
        
        public Weapon EquippedWeapon { get; set; }
        public Shield EquippedShield { get; set; }

        public int Gold { get; set; }



        public Player(string name, int maxLife, int life, int hitChance, int block, Weapon equippedWeapon, Shield equippedShield, int gold) 
            : base (name, maxLife, life, hitChance, block )
        {
            
            EquippedWeapon = equippedWeapon;
            EquippedShield = equippedShield;
            Gold = gold;
        }

        public Player()
        {
            Name = "Player1";
            MaxLife = 100;
            Life = 100;
            HitChance = 7;
            Block = 0;
            Gold = 5;       
        }

        public override string ToString()
        {
            return $"\n\t|  NAME: {Name}  |  Life: {Life}/{MaxLife}  |  Hit Chance: {HitChance}  |  Block: {Block}  |  Gold: {Gold}\n";
        }

        public override int CalcBlock()
        {
            int block = 2;
            block += (EquippedShield.Block);
            return block;
        }

        public override int CalcHitChance()
        {
            int hitChance = 3;
            hitChance += EquippedWeapon.BonusHitChance;
            return hitChance;
        }

        public override int CalcDamage()
        {
            Random random = new Random();
            int damage = 0;
            damage = random.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage);
            return damage;
        }

    }
}
