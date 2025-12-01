using System;
using ProductCodingPractice.Strings.SET1;

class Program
{
    static void Main(string[] args)
    {
        LongestCommonPrefix lcp = new LongestCommonPrefix();
        string[] input = { "flower", "flow", "flight" };

        Console.WriteLine(lcp.LongestCommonPrefixCheck(input));

    }
}