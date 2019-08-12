using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class Rocky : Player
    {

        public Rocky(string Name) : base(Name)
        {

        }


        public override string ChooseThrow()
        {
            return RPSenum.Rock.ToString();
        }

        public override string GetName()
        {
            return "Rocky";
        }
    }
}
