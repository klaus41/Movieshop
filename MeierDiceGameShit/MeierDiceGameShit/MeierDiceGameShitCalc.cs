using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeierDiceGameShit
{
    public class MeierDiceGameShitCalc
    {
        public bool Meier(int die1, int die2)
        {
            return (die1 == 1 && die2 == 2) || (die1 == 2 && die2 == 1);
        }
    }
}
