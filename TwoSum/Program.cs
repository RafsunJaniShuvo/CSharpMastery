using System;
using System.Collections.Generic;
using System.Text;

public class Program
{

    public static int[] TwoSum(int[] nums, int target)
    {
        for(int i = 0; i < nums.Count(); i++)
        {
            for(int j = i+1;j<nums.Count();j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
                //Console.WriteLine(nums[i] + " " + nums[j]);
            }
        }

        return [];
    }

    public static void Main(string[] args)
    {
        int[] result = TwoSum([3, 2, 4], 6);
        Console.WriteLine(string.Join(" ", result));
    }
}
