using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class UserPlayer : Player
    {
        public UserPlayer()
        {
            this.Name = Name;
            this.RoshamboValue = RoshamboValue;
        }

        public override int GenerateRoshambo()
        {
            Console.WriteLine("Please enter 1 for Rock, 2 for Paper, or 3 for Scissors.");
            RoshamboValue = int.Parse(Console.ReadLine());
            //Console.WriteLine(RoshamboValue);
            return RoshamboValue;
        }

        public override string TheName()
        {
            Console.WriteLine("Please enter your name");
            Name = Console.ReadLine();
            return Name;

        }
    }
}
