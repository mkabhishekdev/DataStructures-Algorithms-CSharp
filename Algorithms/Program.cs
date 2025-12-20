using System;
using System.Runtime.InteropServices;
using Algorithms;

class Program
{
    static void Main(string[] args)
    {
        Algo7_MergeSortImpl_AbdulSir alg6 = new Algo7_MergeSortImpl_AbdulSir();
        int[] test = { 8, 3, 6, 1, 4, 5, 2 };

        int[] result = alg6.MergeSort(test);

        Console.WriteLine("The sorted array is: ");
        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        
    }
}