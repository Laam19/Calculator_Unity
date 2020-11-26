using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_Unity
{
     public class OperationFactory
    {
        public static Operation getResult(string ope)
        {
            
            Operation op = null;
            
             switch(ope)
            {
                case "+":
                    op = new AddOperation();
                    break;
                case "-":
                    op = new SubOperation();
                    break;
                case "*":
                    op = new MultiOperation();
                    break;
                case "/":
                    op = new DivOperation();
                    break;
            }

            return op;
        }
    }
}
