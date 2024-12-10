using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    class Creature
    {
        private string creatureName;
        public string CreatureName
        {
            get { return creatureName; }
        }

        private CastingCost castingCost;
        public CastingCost CastingCost { get { return castingCost; } }

        private string specialAbilities;
        public string SpecialAbilities { get { return specialAbilities; } }

        private string flavourText;
        public string FlavourText { get { return flavourText; } }

        private int attack;
        public int Attack
        {
            get { return attack; }
            private set
            {
                attack = value;
                if (value < 0) { attack = 0; }
            }
        }

        private int defense;
        public int Defense
        {
            get { return defense; }
            private set
            {
                defense = value;
                if (value < 0) { defense = 0; }
            }
        }

        public Creature(string creatureName, CastingCost castingCost, string specialAbilities, string featureText, int attack, int defense) {
            this.creatureName = creatureName;
            this.castingCost = castingCost;
            this.specialAbilities = specialAbilities;
            this.flavourText = featureText;
            this.attack = attack;
            this.defense = defense;
        }

        public void ChangeAttack(bool changeAttack)
        {
            if (changeAttack) { this.attack++; }
            else { this.attack--; }
        }
        public void showCreature()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine($"{this.creatureName} ({this.castingCost.toString()})");
            Console.WriteLine("********************************************");
            Console.WriteLine($"\"{this.flavourText}\"");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"\tAbilities: {this.specialAbilities}");
            Console.WriteLine($"\tAttack: {this.attack}");
            Console.WriteLine($"\tDefense: {this.defense}");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
