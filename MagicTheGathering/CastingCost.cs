using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTheGathering
{
    
    class CastingCost
    {
        private Land.ManaType coloredTypeNeeded;
        public Land.ManaType ColoredTypeNeeded { get { return coloredTypeNeeded; } }

        private int amountColoredNeeded;
        public int AmountColoredNeeded { get { return amountColoredNeeded; } }

        private int amountUncoloredNeeded;
        public int AmountUncoloredNeeded { get { return amountUncoloredNeeded; } }

        public CastingCost(Land.ManaType coloredTypeNeeded, int amountColoredNeeded, int amountUncoloredNeeded)
        {
            this.coloredTypeNeeded = coloredTypeNeeded;
            this.amountColoredNeeded = amountColoredNeeded;
            this.amountUncoloredNeeded = amountUncoloredNeeded;
        }

        public string toString()
        {
            return $"{amountUncoloredNeeded} kleurloos, {amountColoredNeeded} {coloredTypeNeeded} mana";
        }
    }
}
