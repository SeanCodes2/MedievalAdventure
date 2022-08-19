using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace AdventureLibrary
{
    public sealed class Player : Character
    {
        
        public Weapon EquippedWeapon { get; set; }
        public Shield EquippedShield { get; set; }
        public int EscapeChance { get; set; }
        public int Gold { get; set; }

        public Class PlayerClass { get; set; }



        public Player(string name, Class playerClass, int maxLife, int life, int hitChance, int block, Weapon equippedWeapon, Shield equippedShield,int escapeChance,  int gold )
            : base(name, maxLife, life, hitChance, block)
        {
            PlayerClass = playerClass;
            EquippedWeapon = equippedWeapon;
            EquippedShield = equippedShield;
            EscapeChance = escapeChance;
            Gold = gold;
        }

        public Player()
        {
            Name = "Player1";
            PlayerClass = Class.Balanced;
            MaxLife = 100;
            Life = 100;
            HitChance = 70;
            EscapeChance = 50;
            Block = 0;
            Gold = 5;       
        }

        public override string ToString()
        {
            return $"\n\t|  NAME: {Name}  |  Class: {PlayerClass}  |  Life: {Life}/{MaxLife}\n" +
                $"\t|  Hit Chance: {CalcHitChance()}  |  Escape Chance: {EscapeChance}  |  Block: {CalcBlock()}  |  Gold: {Gold}\n";
        }

        public override int CalcBlock()
        {
            return (EquippedShield.Block + EquippedWeapon.Block);
        }
     

        public override int CalcHitChance()
        {
            int hitChance = 50;
            return  hitChance + EquippedWeapon.BonusHitChance;
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
