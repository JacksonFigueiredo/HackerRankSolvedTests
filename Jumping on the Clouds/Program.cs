using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Result
{
    public static int jumpingOnClouds(List<int> c)
    {
        int n = c.Count;
        int jumps = 0;
        int i = 0;

        while (i < n - 1)
        {
            // Try to jump as far as possible, i.e., 2 steps
            if (i + 2 < n && c[i + 2] != 1)
            {
                i += 2;
            }
            else
            {
                // If unable to jump 2 steps, then jump 1 step
                i += 1;
            }

            // Count each jump
            jumps++;
        }

        return jumps;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        List<int> c = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(cTemp => Convert.ToInt32(cTemp)).ToList();

        int result = Result.jumpingOnClouds(c);
        Console.WriteLine(result);
    }
}
