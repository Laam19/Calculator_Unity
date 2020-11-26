using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Unity
{
     public interface IOperation
    {
        //public int numberA;
        //public int numberB;
        public int numberA { get; set; }
        public int numberB { get; set; }
        public int getResult();
    }
}
