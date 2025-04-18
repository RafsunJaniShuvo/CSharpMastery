using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
  
    public static void Main(string[] args)
    {
        Program.NewMethod1();
        Program.NewMethod2();
        Console.WriteLine("Start data input, enter your name");
        string?  str = Console.ReadLine();
        Console.WriteLine(str);
        Console.Read();
    }
    public static async void NewMethod1()
    {
        await Task.Delay(1000);
        Console.WriteLine("Download file 1");
    }
    public static async void NewMethod2()
    {
        await Task.Delay(1000);
        Console.WriteLine("Download file 2");
    }
}
