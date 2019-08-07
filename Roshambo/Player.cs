using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    abstract class Player
    {
        public Player(string Name)
        {

        }
        abstract public string ChooseThrow();
    }
}
