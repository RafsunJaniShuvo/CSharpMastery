
using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static bool IsPalindrome(int x)
    {
          if(x<0 || ( x!=0 && x % 10 == 0))
        return false;

        int half = 0;
        while (x > half)
        {
            half = (half * 10) + (x % 10);
            x =x / 10;
        }
        return (x == half ) || (half/10 == x);
    }

    public static void Main(string[] args)
    {
        bool result = IsPalindrome(1221);
        Console.WriteLine(string.Join(" ", result));
    }
}
