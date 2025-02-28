using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void MyDemoDelegate(string Message);
    public delegate void MyDemoDelegateWithoudParams();
    public class MyDelegates
    {
        public void ClassA(string messages)
        {
            Console.WriteLine(messages);
        }

        public void ClassB() { 
            Console.WriteLine("Rafsun Jani shuvo"); 
        }

        public void InvokeDelegateWithParams(MyDemoDelegate del)
        {
            del("Rafsun ");
        }

        public void InvokeDelegateWithoudParams(MyDemoDelegateWithoudParams del) {
            del();
        }

    }
}
