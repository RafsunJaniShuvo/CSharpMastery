using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExample
{
    public static class Calculator
    {
        private static int _resultStorage = 0;

        public static string type = "Arithmetic";

        public static int sum(int a,int b)
        {
            return a + b;
        }
        public static void Storage(int sum)
        {
            _resultStorage = sum;
        }
    }
}
