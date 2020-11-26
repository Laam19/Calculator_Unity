using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Unity
{
     public class SubOperation:IOperation
    {
        public int numberA { get; set; }
        public int numberB { get; set; }
        public int getResult()
        {
            int result = 0;
            result = numberA - numberB;
            return result;
        }
    }
}
