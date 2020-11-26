using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Unity
{
    class AddOperation : Operation
    {
        public int numberA { get; set; }
        public int numberB { get; set; }
        public virtual int getResult()
        {
            Console.WriteLine("Add");
            int result = 0;
            result = this.numberA + this.numberB;
            return result;
        }
    }
}
