using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Player2 : Player
    {
        public Player2()
        {
            //Name = "Player2";
            this.Name = Name;
            this.RoshamboValue = RoshamboValue;
        }

        public override int GenerateRoshambo()
        {
                Random rnd = new Random();
            RoshamboValue = rnd.Next(1, 4);
            //Console.WriteLine(RoshamboValue);
            return RoshamboValue;
        }

        public override string TheName()
        {
            Name = "Johnny";
            return Name;

        }
    }
}
