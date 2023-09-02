using System;
using System.IO;

class Result
{
    public static long repeatedString(string s, long n)
    {
        // Count the number of 'a's in the original string
        long countAInOriginal = 0;
        foreach (char c in s)
        {
            if (c == 'a')
            {
                countAInOriginal++;
            }
        }

        // Calculate how many times the string s is repeated
        long fullRepeats = n / s.Length;
        long remainingChars = n % s.Length;

        // Calculate the number of 'a's in the first n characters of the infinite string
        long totalA = fullRepeats * countAInOriginal;

        // Count the 'a's in the remaining substring
        for (int i = 0; i < remainingChars; i++)
        {
            if (s[i] == 'a')
            {
                totalA++;
            }
        }

        return totalA;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();
        long n = Convert.ToInt64(Console.ReadLine().Trim());

        long result = Result.repeatedString(s, n);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
