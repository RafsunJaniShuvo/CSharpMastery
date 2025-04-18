
using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static int SingleNumber(int[] nums)
    {
        int result = 0;
        for (int i=0;i<nums.Count();i++)
        {
            result = result ^ nums[i];
        }

        return result;
    }

    public static void Main(string[] args)
    {
        int result = SingleNumber([4, 1, 2, 1, 2]);
        Console.WriteLine(string.Join(" ", result));
    }
}
