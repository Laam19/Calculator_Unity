using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Unity
{
    class DivOperation : IOperation
    {
        public int numberA { get; set; }
        public int numberB { get; set; }
        public int getResult()
        {
            int result = 0;
            if (numberB != 0)
            {
                result = numberA / numberB;
                return result;
            }
            
            else
            {
                Console.WriteLine("Number B can not be 0");
            }
            return 0;
        }
    }
}
