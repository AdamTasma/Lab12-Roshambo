using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Player1 : Player
    {
        //name = PlayerOne;

        public Player1()
        {
            this.Name = Name;
            this.RoshamboValue = RoshamboValue;
        }

        public override int GenerateRoshambo()
            {           
            RoshamboValue = 1;
            return RoshamboValue;
            } 

        public override string TheName()
        {
            Name = "Billie";
            return Name;
        }
    }
}
