using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Rando : Player
    {
        Random Rando1;
        public Rando(string Name, Random Rando) : base(Name)
        {
            this.Rando1 = Rando;
        }
        public override string ChooseThrow()
        {
            int pick = Rando1.Next(1, 4);

            if (pick == 1)
            {
                return RPSenum.Rock.ToString();
            }
            else if (pick == 2)
            {
                return RPSenum.Paper.ToString();
            }
            else if (pick == 3)
            {
                return RPSenum.Scissors.ToString();
            }

            return "whoops";
        }

        public override string GetName()
        {
            return "Randy";
        }
    }
}
