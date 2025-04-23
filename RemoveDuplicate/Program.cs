
using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static int RemoveDuplicates(int[] nums)
    {
        var UniqueArray = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++) 
        {
            UniqueArray.Add(nums[i]);
        }
        return UniqueArray.Count();
    }

    public static void Main(string[] args)
    {
        int result = RemoveDuplicates([0, 0, 1, 1, 1, 2, 2, 3, 3, 4]);
        Console.WriteLine(string.Join(" ", result));
    }
}
