using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static int getLowestDifferenceNumber(List<(int, int)> list)
    {

        var differences = list.Select(pair => new
        {
            Pair = pair,
            Difference = Math.Abs(pair.Item1 - pair.Item2)
        }).ToList();

        var minimumDiffernce = differences.Min(x => x.Difference);

        return minimumDiffernce;

    }
    public static List<(int, int)> getPairs(List<int> arr)
    {
        List<(int, int)> pairs = new List<(int, int)>();


        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = i+1; j < arr.Count; j++)
            {
                pairs.Add((arr[i], arr[j]));
            }
        }
        return pairs;

    }
    public static int minimumAbsoluteDifference(List<int> arr)
    {
        arr.Sort();
        int minValue = int.MaxValue;
        for (int i = 0; i<arr.Count()-1;i++)
        {
            int diff = Math.Abs(arr[i] - arr[i + 1]);
            if(diff < minValue)
            {
                minValue = diff;
            }
            
        }
        return minValue;
        
    }

    public static void Main(string[] args)
    {
        var result = minimumAbsoluteDifference(new List<int> { -2,2,4 }); 
        Console.WriteLine( result);
    }
}
