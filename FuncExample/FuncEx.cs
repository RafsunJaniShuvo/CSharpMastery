using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncExample
{
   
    public class FuncEx
    {

        public int sum(int a,int b)
        {
            return a + b;
        }

        public int InvokeFunc(Func<int, int, int> func)
        {
           return func(5, 6);
        }
        
    }
}
