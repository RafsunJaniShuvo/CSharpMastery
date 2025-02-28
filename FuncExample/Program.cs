using FuncExample;
FuncEx funcEx = new FuncEx();
Func<int,int,int>  add = funcEx.sum;
int sum = funcEx.InvokeFunc(add);
Console.WriteLine(sum);
