using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Unity
{
     public interface IOperation<T>
    {

        public T numberA { get; set; }
        public T numberB { get; set; }
        public T getResult();
    }
}
