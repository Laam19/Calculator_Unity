using System;

namespace Calculator_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation op;
            op = OperationFactory.getResult("*");
            op.numberA = (2);
            op.numberB  = (3);
            int result = op.getResult();
            Console.WriteLine(result);
        }
    }
}
