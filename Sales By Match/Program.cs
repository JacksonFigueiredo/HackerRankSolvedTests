using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Result
{
    public static int sockMerchant(int n, List<int> ar)
    {
        Dictionary<int, int> sockCounts = new Dictionary<int, int>();
        int totalPairs = 0;

        // Count the occurrences of each sock color
        foreach (int sock in ar)
        {
            if (sockCounts.ContainsKey(sock))
            {
                sockCounts[sock]++;
            }
            else
            {
                sockCounts[sock] = 1;
            }
        }

        // Calculate the number of pairs for each color and sum them up
        foreach (KeyValuePair<int, int> entry in sockCounts)
        {
            totalPairs += entry.Value / 2;
        }

        return totalPairs;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
