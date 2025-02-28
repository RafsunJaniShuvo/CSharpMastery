
//using Delegates;

//MyDelegates myDelegates = new MyDelegates();
//MyDemoDelegate del = myDelegates.ClassA;
//MyDemoDelegateWithoudParams del1 = myDelegates.ClassB;
//myDelegates.InvokeDelegateWithParams(del);
//myDelegates.InvokeDelegateWithoudParams(del1);

using Delegates;

///Predicate Delegate
PredicateDelegate predicateDelegate = new PredicateDelegate();
Predicate<int> IsGreter = predicateDelegate.isGreater;
bool res = IsGreter(10);
Console.WriteLine(res);