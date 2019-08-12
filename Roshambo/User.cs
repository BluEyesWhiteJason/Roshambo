using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    class User : Player
    {
        string name;

        public User(string Name) : base(Name)
        {
            this.name = Name;
        }

        public override string GetName()
        {
            return name;
        }

        public override string ChooseThrow()
        {
            Console.WriteLine("Rock, Paper or Scissors? Enter (r/p/s)");
            string choice = Console.ReadLine().Trim();
         

            if (choice == "r")
            {
                return RPSenum.Rock.ToString();
            }
            else if (choice == "p")
            {
                return RPSenum.Paper.ToString();
            }
            else if (choice == "s")
            {
                return RPSenum.Scissors.ToString();
            }
            else
            {
                Console.WriteLine("Didn't understand, please enter one of r/p/s");
                return ChooseThrow();
            }
            

        }
    }
}
