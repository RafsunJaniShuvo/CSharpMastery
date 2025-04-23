using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static bool IsValid(string s)
    {
        if (s == null || s.Length == 0) return false;

        Stack<char> chars = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '[' || s[i] == '{')
            {
                chars.Push(s[i]);
            }
            else
            {
               
                if( chars.Count() == 0 ) return false;

                    char top = chars.Pop();

                    if (s[i] == ']' && top != '[')
                    {
                        return false;
                    }
                    if (s[i] == ')' && top != '(')
                    {
                        return false;
                    }
                    if (s[i] == '}' && top != '{')
                    {
                        return false;
                    }
                
                

            }
        }


        return chars.Count() == 0 ;
    }

    public static void Main(string[] args)
    {
        bool result = IsValid("]");
        Console.WriteLine(string.Join(" ", result));
    }
}
