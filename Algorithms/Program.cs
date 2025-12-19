using System;
using System.Runtime.InteropServices;
using Algorithms;

class Program
{
    static void Main(string[] args)
    {
        Algo6_QuickSort_AbdulSir alg6 = new Algo6_QuickSort_AbdulSir();
        int[] test = { 8, 3, 6, 1, 4, 5, 2 };

        int[] result = alg6.QuickSort(test);

        Console.WriteLine("The sorted array is: ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        
    }
}