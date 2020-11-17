using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Race
{
    public class Bet
    {
        public int Price; 
        public int Pet;
        public Person Betting;

        

        public int Pay(int win)
        {
            // the parameter is the win of the race. If the Pet won, return the Price bet.
            // otherwise return nothing

            if (win == Pet)
            {
                int Pay = Price * 2;
                return Pay;
            }
            else
            {
                int Pay = 0;
                return Pay;
            }
        }
        public string GetDescription()
        {
            if (Price > 0)
                return Betting.Name + " bets " + Price + " bucks on Pet #" + Pet;
            else
                return Betting.Name + " hasnt placed a bet";
        }
    }
}