using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    class Land
    {
        public enum ManaType { Water, Bos, Zon, Vuur, Dood };

        private string naam;
        public string Naam { get { return naam; } }

        private ManaType mana;
        public ManaType Mana { get { return mana; } }

        public Land(string naam, ManaType mana)
        {
            this.naam = naam;
            this.mana = mana;
        }

        public void ShowLand()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine($"{this.naam} ({this.mana} mana)");
            Console.WriteLine("********************************************");
        }
    }
}
