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
        public CharacterClass PlayerClass { get; set; }
        public int BonusDamage { get; set; }



        public Player(string name, CharacterClass playerClass, int maxLife, int life, int hitChance, int block, Weapon equippedWeapon, Shield equippedShield,int escapeChance, int bonusDamage, int gold )
            : base(name, maxLife, life, hitChance, block)
        {
            PlayerClass = playerClass;
            EquippedWeapon = equippedWeapon;
            EquippedShield = equippedShield;
            EscapeChance = escapeChance;
            BonusDamage = bonusDamage;
            Gold = gold;

            switch (playerClass)
            {
                case CharacterClass.Balanced:
                    break;
                case CharacterClass.Dexer:
                    HitChance += 10;
                    MaxLife -= 5;
                    Life -= 5;
                    break;
                case CharacterClass.Tank:
                    Block += 5;
                    EscapeChance -= 10;
                    HitChance -= 5;
                    MaxLife += 10;
                    Life +=10;
                    break;
                case CharacterClass.Berzerker:
                    Block -= 10;
                    BonusDamage +=5;
                    EscapeChance -=10;
                    break;
                case CharacterClass.Peasant:
                    Block -= 3;
                    EscapeChance -= 3;
                    HitChance -= 3;
                    MaxLife -= 10;
                    Life -= 10;
                    break;
                default:
                    break;
            }
        }

        public Player()
        {
           
        }        

        public override string ToString()
        {
            return $"\nNAME: {Name}\n" +
                $"Class: {PlayerClass}\n" +
                $"Life: {Life}/{MaxLife}\n" +
                $"Hit Chance: {CalcHitChance()}\n" +
                $"Escape Chance: {EscapeChance}\n" +
                $"Block: {CalcBlock()}\n" +
                $"Gold: {Gold}\n\n";         
        }

        public override int CalcBlock()
        {
            return (EquippedShield.Block + EquippedWeapon.Block);
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitChance;
        }

        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1) + BonusDamage;
        }

        public int CalcEscape()
        {
            return EscapeChance;
        }

        private static void ChooseClass(ref bool scope, ref int userInput)
        {
            while (scope)
            {
                Console.Write("\nPlease select a class:\n\n" +
                    "1. Balanced\t\tNo Change\n" +
                    "2. Dexer\t\tHitchance +10 | MaxLife -5\n" +
                    "3. Tank\t\t\tBlock +5 | MaxLife +10 | HitChance -5 | EscapeChance -10\n" +
                    "4. Berzerker\t\tDamage +5 | Block -10 | EscapeChance -10\n" +
                    "5. Peasant:\t\tBlock -3 | EscapChance -3 | HitChance -3 | MaxLife -10\n");

                bool success = int.TryParse(Console.ReadLine(), out userInput);
                if (userInput < 6 && userInput > 0 && success)
                {
                    scope = false;
                }
                Console.Clear();
            }
        }

        public static CharacterClass GetClass(int userClassChoice)
        {
            CharacterClass playerClass = new CharacterClass();

            switch (userClassChoice)
            {
                case 1:
                    playerClass = CharacterClass.Balanced;
                    break;
                case 2:
                    playerClass = CharacterClass.Dexer;
                    break;
                case 3:
                    playerClass = CharacterClass.Tank;
                    break;
                case 4:
                    playerClass = CharacterClass.Berzerker;
                    break;
                case 5:
                    playerClass = CharacterClass.Peasant;
                    break;                
            }
            return playerClass;
        }

    }
}
