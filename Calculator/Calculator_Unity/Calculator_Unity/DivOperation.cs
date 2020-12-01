using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Unity
{
    class DivOperation<T> : IOperation<T>
    {
        public T numberA { get; set; }
        public T numberB { get; set; }
        public T getResult()
        {
            T result = (dynamic)numberA/(dynamic)numberB;
            return result;
            
        }
    }
}
