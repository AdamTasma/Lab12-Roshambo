using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        protected string Name { get; set; }
        protected int RoshamboValue { get; set; }


        public abstract int GenerateRoshambo();

        public abstract string TheName();
        

            //return roshamboValue;
        
    }
}
