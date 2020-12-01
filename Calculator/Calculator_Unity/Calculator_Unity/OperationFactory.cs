namespace Calculator_Unity
{
     public class OperationFactory<T>
    {
       

        public static IOperation<T> getResult(string ope)
        {
            
            IOperation<T> op = null;
            
             switch(ope)
            {
                case "+":
                    op=new AddOperation<T>();
                    break;
                case "-":
                    op=new SubOperation<T>();
                    break;
                case "*":
                    op=new MultiOperation<T>();
                    break;
                case "/":
                     op=new DivOperation<T>();
                    break;
            }
            return op;
            
        }

        
    }
}
