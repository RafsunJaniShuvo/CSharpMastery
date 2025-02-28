using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    
    public static string caesarCipher(string s, int k)
    {
        //(char)(c + k)).ToArray()
        string shifted = new string(s.Select(c =>
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a'; 
                return (char)(offset + (c - offset + k) % 26);
            }
            return c;
        }).ToArray());
        
        return shifted;
    }

    public static void Main(string[] args)
    {
        string result = caesarCipher("middle-Outz",2); 
        Console.WriteLine(string.Join(" ", result));
    }
}
