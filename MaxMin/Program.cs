using System;
using System.Collections.Generic;
using System.Text;

class Result
{

    /*
     * Complete the 'maxMin' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */
    public static List<int[]> GenerateSubArray(int k,List<int> arr)
    {
        List<int[]> listSubArray = new List<int[]>();

        for(int i=0;i< arr.Count(); i++)
        {
            for(int j = i +1 ;j< arr.Count();j++)
            {
                listSubArray.Add(new int[] { arr[i], arr[j] });
            }
        }

         
        return listSubArray;
    }
    public static int maxMin(int k, List<int> arr)
    {
        List<int[]> subArray =  Result.GenerateSubArray( k,arr);
        int min = int.MaxValue;
        int max = int.MinValue;

        foreach(var sub in subArray)
        {
            if(sub.Max() > max && sub.Min() < min)
            {
                max = sub.Max();
                min = sub.Min();

            }
        }

        return max - min;       
    }

}

class Solution
{
    public static void Main(string[] args)
    {
       
        //int result = Result.maxMin(8, new List<int> { 6327,571,6599,479,7897,9322,4518,571,6677,7432,815,6920,4329,4104,7775,5708,7991,5802,8619,6053,7539,7454,9000,3267,6343,7165,4095,439,5621,4095,153,1948,1018,6752,8779,5267,2426,9649,2190,9103,7081,3006,2376,7762,3462,151,3471,1453,2305,8442});
        int result = Result.maxMin(3, new List<int> { 10,100,300,200,1000,20,30});
        Console.WriteLine(result);
        
    }
}