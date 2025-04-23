using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static string LongestCommonPrefix(string[] strs)
    {

        if (strs.Length == 0)
        {
            return string.Empty;
        }
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++) {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length-1);
                if (string.IsNullOrEmpty(prefix)) return "";
            }
        }



        return prefix;
    }

    public static void Main(string[] args)
    {
        string result = LongestCommonPrefix(["flower", "flow", "flight"]);
        Console.WriteLine(string.Join(" ", result));
    }
}
