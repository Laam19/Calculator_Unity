using System;

namespace Calculator_Unity
{
    class Program
    {
        static void Main(string[] args)
        {
            var op = OperationFactory<int>.getResult("+");
            op.numberA= 2;
            op.numberB  = 3;
            var result = op.getResult();
            Console.WriteLine(result);
        }
    }

}
